using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Companies.Domain.Aggregates.PartnersAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Publicitario : Entity
    {
        public virtual Empresa Empresa { get; set; }
    }
}
