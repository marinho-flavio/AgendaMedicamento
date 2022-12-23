using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Companies.Domain.Aggregates.SchedulingsAgg.ValueObjects
{
    public class BaseConfiguracaoAgenda : ActivableEntity
    {
        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int TempoAtendimento { get; set; }

        [Step(1)]
        public string Tipo { get; set; }

        public string ScheduleStatus { get; set; }

        public int QuantidadeAgendamentos { get; set; }

        public int QuantidadeEncaixes { get; set; }
    }
}
