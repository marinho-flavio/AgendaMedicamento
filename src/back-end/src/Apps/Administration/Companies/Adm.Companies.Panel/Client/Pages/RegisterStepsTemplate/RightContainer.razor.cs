using SES.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests;
using Microsoft.AspNetCore.Components;

namespace Companies.Adm.Panel.Client.Pages.RegisterStepsTemplate
{
    public class RightContainerContext
    {
        NavigationManager _navigation { get; set; }

        public RightContainerContext(NavigationManager navigation)
        {
            _navigation = navigation;
        }

        public void OnGroupClicked(string id)
        {
            if (IsMouseHoverPlusBtn) return;
            if (string.IsNullOrWhiteSpace(GroupClickedId))
            {
                this.GroupClickedId = id;
                _navigation.NavigateTo($"/{new GrupoEmpresaDTO().GetMyTypeName()}/cadastro/{id}");
            }
            this.IsGroupClicked = !this.IsGroupClicked;
        }

        public void OnEmpresaClicked(string id, bool isFilial = false)
        {
            if (IsMouseHoverPlusBtn) return;
            if (this.EmpresaClickedId?.Equals(id) == true && !isFilial)
            {
                this.EmpresaClickedId = null;
            }
            else
            {
                this.EmpresaClickedId = id;
                _navigation.NavigateTo($"/{(isFilial ? "Filial" : new EmpresaDTO().GetMyTypeName())}/cadastro/{id}");
            }
            this.GroupClickedId = null;
        }

        public bool IsGroupClicked { get; set; }
        public string EmpresaClickedId { get; set; }
        public string GroupClickedId { get; set; }

        public string EmpresaId { get; set; }

        public bool IsMouseHoverPlusBtn { get; set; }
    }
}
