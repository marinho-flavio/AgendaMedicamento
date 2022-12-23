using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.Partners.Domain.Aggregates.CompaniesAgg.Entities;

namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Publicitario : Entity
    {
        public string? Nome { get; set; }
        public int? Tipo { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
        public int? TipoValorRepasse { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
