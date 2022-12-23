using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities
{
    public class GrupoEmpresaContacts : Entity
    {
        [RequiredT4, DisplayOnList(4), DisplayName("E-Mail")]
        public string? Email { get; set; }
        
        [RequiredT4, DisplayOnList(4), DisplayName("Telefone")]
        public string? Telefone { get; set; }

        [RequiredT4, DisplayName("Tipo de Telefone")]
        public string? TipoTelefone { get; set; }

        public string? WebSite { get; set; }
    }
}
