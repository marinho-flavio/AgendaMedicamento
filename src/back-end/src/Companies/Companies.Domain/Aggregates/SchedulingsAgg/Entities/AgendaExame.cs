using Bravo.Companies.Domain.Aggregates.SchedulingsAgg.ValueObjects;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Entities
{
    [Steppable(1), EndpointsT4(EndpointTypes.HttpAll)]
    public class AgendaExame : BaseConfiguracaoAgenda
    {

    }
}
