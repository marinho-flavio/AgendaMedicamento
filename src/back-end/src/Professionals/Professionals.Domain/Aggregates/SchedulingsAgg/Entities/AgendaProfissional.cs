using Bravo.Core.Domain.Attributes.T4;
using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.ValueObjects;

namespace Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class AgendaProfissional : BaseConfiguracaoAgenda
    {
        public string ProfissionalId { get; set; }
        public Profissional Profissional { get; set; }
    }
}
