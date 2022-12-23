using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;

namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class ConvenioHorasEspeciais : Entity
    {
        [Step(1)]
        public string Dia { get; set; }

        [Step(1), DisplayName("Hora inicial")]
        public string HoraInicial { get; set; }

        [Step(1), DisplayName("Hora final")]
        public string HoraFinal { get; set; }

        public int ConvenioId { get; set; }
        public Convenio Convenio { get; set; }
    }
}
