using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.Partners.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Partners.Enumerations;

namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Fornecedor : Entity
    {
        [DisplayOnList(Order = 1)]
        public string? Nome { get; set; }
        public string? NomeFantasia { get; set; }
        [DisplayOnList(Order = 2)]
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public int? Tipo { get; set; }
        public string? NomeContato { get; set; }
        public string? Telefone { get; set; }
        public string? Classificacao { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
