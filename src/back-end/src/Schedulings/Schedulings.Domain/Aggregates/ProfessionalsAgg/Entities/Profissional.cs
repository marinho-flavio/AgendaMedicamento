using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using SES.Core.Domain.Attributes.T4;
using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Entities;

namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Profissional : Entity<string>
    {
    }
}
