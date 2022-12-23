namespace SES.Core.Application.DTO.Aggregates.CommonAgg.ValueObjects
{
    public class AutoSaveSettingsDTO
    {
        public bool Enabled { get; set; }
        public List<string> Errors { get; set; } = new List<string>();

        public void AddError(params string[] errors)
        {
            this.Errors.AddRange(errors);
        }

        public event Action<bool> OnUpdateEvent;
        public void OnUpdate(bool recipe) => OnUpdateEvent?.Invoke(recipe);
    }
}
