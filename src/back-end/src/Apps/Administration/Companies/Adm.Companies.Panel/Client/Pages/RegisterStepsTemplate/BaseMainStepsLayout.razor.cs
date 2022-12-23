using Companies.Adm.Panel.Client.Pages.RegisterStepsTemplate;
using Companies.Adm.Panel.Shared;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Commands.Responses;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;

namespace Companies.Adm.Panel.Client.Pages.Base
{
    public class TestSubclass
    {
        public string Test { get; set; }
    }

    public class StepsContext<ModelType>
        where ModelType : EntityDTO, new()
    {
        public StepsContext()
        {

        }
        public BaseMainStepsLayout<ModelType>? layout { get; set; }
        public Action<int> ChangeStep { get; set; }

        public StepsContext(string myId, int step, int maxSetpsCount, ModelType model, Action backward, BaseMainStepsLayout<ModelType> layout, Action<int> changeStep)
        {
            this.MyId = MyId;
            this.CurrentStep = step;
            this.MaxSteps = maxSetpsCount;
            this.Model = model;
            Backward = backward;
            this.layout = layout;
            ChangeStep = changeStep;
        }

        public string MyId { get; set; }
        public int CurrentStep { get; set; }
        public int MaxSteps { get; set; }
        public ModelType Model { get; set; }
        public string CurrentUrl { get; set; }
        public Action Backward { get; set; }
        public Action RefreshHeader { get; set; }
        public TestSubclass Subclass { get; set; } = new TestSubclass();
    }

    public class BaseStepsFormComponent<ModelType, SettingsType, ValidatorType> : LayoutComponentBase
        where ModelType : EntityDTO, new()
        where SettingsType : BaseAggregateSettingsDTO, new()
        where ValidatorType : BaseValidator<ModelType>
    {
        Action MinhaFuncao { get; set; }
        [CascadingParameter] public IValidator TValidator { get; set; }
        protected BaseMainStepsLayout<ModelType>? layout { get; set; }

        [Inject] IServiceProvider _provider { get; set; }

        protected SettingsType AutoSaveSettings { get; set; }

        [Inject] NavigationManager NavigationManager { get; set; }

        [Inject] public IJSRuntime JSRuntime { get; set; }

        [CascadingParameter] public EditContext EditContext { get; set; }

        public BaseStepsFormComponent()
        {
            Model = Model ?? new ModelType() { ExternalId = (Id ?? Guid.NewGuid().ToString()) };
            EditContext = new EditContext(Model);
        }

        [Inject] protected HttpClient _client { get; set; }

        [Parameter] public ModelType Model { get; set; }

        public object ValidationModel { get; set; }

        [Parameter] public string Id { get; set; }

        [Parameter] public int Step { get; set; }

        public RenderFragment CurrentFragment { get; set; }

        public StepsContext<ModelType> Context { get; set; }
        protected async override Task OnInitializedAsync()
        {
            try
            {
                if (Context == null)
                {
                    Context = new StepsContext<ModelType>();

                    ChangeStep(Step);

                    jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./scripts/functions.js");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender || (!string.IsNullOrEmpty(Model?.ExternalId) && !string.IsNullOrEmpty(Id) && Model.ExternalId != Id))
            {
                if (AutoSaveSettings == null)
                {
                    AutoSaveSettings = AutoSaveSettings ?? await GetAutoSaveConfig() ?? new SettingsType();
                    AutoSaveSettings.AutoSaveSettings.OnUpdateEvent += UpdateAutoSaveConfig;
                }

                if (!string.IsNullOrWhiteSpace(Id))
                {
                    Model = await _client.OnInitializedAsync<ModelType>(Id);
                }
                ChangeStep(Step);
            }

            //UpdateHeader();
        }

        protected async Task OnSubmitFormInvalid(EditContext editContext)
        {
        }

        protected async Task OnSubmitForm(EditContext editContext)
        {
            Model.CurrentStep = Step + 1;

            var messages = editContext.GetValidationMessages().ToArray();
            var result =
                await _client.PostAsync(
                    Model.GetRoute(),
                    new StringContent(JsonConvert.SerializeObject(Model),
                    Encoding.UTF8,
                    "application/json"));

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ChangeStep(++Step);
            }
            else
            {
                Model.CurrentStep = Step;
            }
            this.StateHasChanged();
        }

        protected void Backward()
        {
            if (this.Step == 0) return;
            ChangeStep(--Step);
            UpdateHeader();
            this.StateHasChanged();
        }
        protected void UpdateHeader()
        {
            try
            {
                Task.Run(() => { layout?.RefreshHeader(this.StateHasChanged); });
            }
            catch (Exception)
            {
            }
        }

        private IJSObjectReference? jsModule;
        protected int MaxSetpsCount
        {
            get
            {
                var myName = $"{new ModelType().GetMyTypeName()}";
                return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Count(t => t.Name.Substring(0, t.Name.Length - 1) == myName);
            }
        }

        protected void ChangeStep(int step)
        {
            try
            {
                if (layout != null)
                {
                    if (this.Step >= MaxSetpsCount && MaxSetpsCount > 0)
                    {
                        var splitted = NavigationManager.Uri.Split('/');
                        var x = string.Join('/', splitted.SkipLast(splitted.LastOrDefault() == "cadastro" ? 1 : 2));
                        NavigationManager.NavigateTo(x);
                    }
                    else if (step < 0)
                    {
                        this.Step = 0;
                    }
                    else
                    {
                        if (step >= Model.CurrentStep)
                            Model.CurrentStep = (step);

                        CurrentFragment = GetCurrentStep(step, Model);
                        EditContext = new EditContext(Model);
                        SetValidator();
                    }
                    this.Context = new StepsContext<ModelType>(this.Id, step, MaxSetpsCount, Model, Backward, layout, ChangeStep);
                    UpdateHeader();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SetValidator()
        {
            string myName = $"{Model.GetType().Name.Replace("DTO", "")}Step{(Step + 1)}".ToString();
            string dtoName = $"{myName}DTO";
            var test = new { myName, dtoName, xx= typeof(ValidatorType) };


            var validatorType = AssemblyScanner
                .FindValidatorsInAssembly(Assembly.GetAssembly(typeof(ValidatorType)))
                .FirstOrDefault(x => x.ValidatorType.Name.Contains(myName))
                ?.ValidatorType;

            TValidator = _provider.GetRequiredService(validatorType) as IValidator;

            var modelType = Assembly.GetAssembly(validatorType)
                .GetTypes()
                .FirstOrDefault(x => x.Name.Contains(dtoName));
        }

        private RenderFragment GetCurrentStep(int step, object model)
        {
            var main = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t == GetType());

            var mainName = string.Join('.', main.FullName.Split('.').SkipLast(1));
            var x = new { mainName };

            var steps = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t =>
                    t.FullName != main.FullName && char.IsDigit(t.Name.Last()) &&
                    string.Join('.', t.FullName.Split('.').SkipLast(1)) == mainName)
                .ToArray();

            if (steps.Length > 0)
            {

                Type type = null;

                if (step >= steps.Length)
                    step = steps.Length - 1;

                if (step < 0)
                    step = 0;

                Step = step;
                type = steps.ElementAt(step);

                //var properties = type.GetProperties();

                return AddContent(model, type);
            }

            return null;
        }

        private RenderFragment AddContent(object Model, Type type)
            => builder =>
            {
                builder.OpenComponent(1, type);
                builder.AddAttribute(2, "Model", Model);
                builder.CloseComponent();
            };

        private RenderFragment AddContent<T>(params KeyValuePair<string, object>[] parameters)
            where T : class, new()
            => builder =>
            {
                builder.OpenComponent(1, new T().GetType());
                int i = 2;
                foreach (var item in parameters)
                {
                    builder.AddAttribute(i++, item.Key, item.Value);
                }

                builder.CloseComponent();
            };

        private async Task<SettingsType> GetAutoSaveConfig()
        {
            try
            {
                if (AutoSaveSettings == null)
                {
                    var test123 = new { a = new SettingsType().GetRoute() };
                    var response = await _client.GetAsync(new SettingsType().GetRoute());
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var test = new { abc = await response.Content.ReadAsStringAsync() };
                        var result = JsonConvert.DeserializeObject<GetHttpResponseDTO<SettingsType>>(await response.Content.ReadAsStringAsync());
                        return result.Data;
                    }
                }

            }
            catch (Exception)
            {
            }
            return AutoSaveSettings;
        }

        private async void UpdateAutoSaveConfig(bool newVal)
        {
            AutoSaveSettings.AutoSaveSettings.Enabled = newVal;

            var result = await _client.PostAsJsonAsync(AutoSaveSettings.GetRoute(), AutoSaveSettings);

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                AutoSaveSettings.AutoSaveSettings.AddError($"Erro ao habilitar o autosave: {result.ReasonPhrase}");
                AutoSaveSettings.AutoSaveSettings.Enabled = !newVal;
            }
        }
    }
}
