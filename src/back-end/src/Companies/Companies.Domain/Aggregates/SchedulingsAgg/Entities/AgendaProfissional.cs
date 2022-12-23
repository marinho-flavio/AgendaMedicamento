using Bravo.Companies.Domain.Aggregates.SchedulingsAgg.ValueObjects;
using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.Schedulings.Domain.Aggregates.SchedulingsAgg.ValueObjects;

namespace Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Entities
{
    [Steppable(1), EndpointsT4(EndpointTypes.HttpAll)]
    public class AgendaProfissional : BaseConfiguracaoAgenda
    {
        [Step(1), Title]
        public string NomeProfissional { get; set; }
        [Step(1), RegisterOrder(0)]
        public string Conselho { get; set; }

        [Step(1), RegisterOrder(1)]
        public string CBOProfissional { get; set; }

        [Step(1), RegisterOrder(2)]
        public string DuracaoConsulta { get; set; }

        [Step(1), RegisterOrder(3)]
        public string CotaAtendimento { get; set; }

    }
}
