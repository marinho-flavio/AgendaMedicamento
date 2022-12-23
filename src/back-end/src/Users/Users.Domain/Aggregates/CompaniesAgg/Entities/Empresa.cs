using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using SES.Core.Domain.Attributes.T4;

namespace SES.Users.Domain.Aggregates.CompaniesAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Empresa : Entity
    {
    }
}