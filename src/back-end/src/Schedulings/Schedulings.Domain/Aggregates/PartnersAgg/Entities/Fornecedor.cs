using SES.Core.Application.DTO.Attributes;
using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using SES.Core.Domain.Attributes.T4;
using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Entities;

namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Fornecedor : Entity
    {
        [DisplayOnList(Order = 1)]
        public string? Nome { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
