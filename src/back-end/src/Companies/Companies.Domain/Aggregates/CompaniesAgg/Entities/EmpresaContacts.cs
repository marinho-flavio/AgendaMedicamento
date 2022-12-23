using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities
{
    public class EmpresaContacts : Entity
    {
        [RequiredT4]
        public string? Email { get; set; }
        
        [RequiredT4]
        public string? Telefone { get; set; }

        [RequiredT4, DisplayName("Tipo de Telefone")]
        public string? TipoTelefone { get; set; }

        public string? WebSite { get; set; }
    }
}
