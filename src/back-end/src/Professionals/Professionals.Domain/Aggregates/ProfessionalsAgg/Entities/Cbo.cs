using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities
{
    [Steppable(1), EndpointsT4(EndpointTypes.HttpAll)]
    public class Cbo : Entity
    {
        [Step(1), RegisterOrder(0), DisplayOnList(0), Title]
        public string? Codigo { get; set; }
        [Step(1), RegisterOrder(1), DisplayOnList(1), Subtitle]
        public string? Titulos { get; set; }
        [Step(1), RegisterOrder(2), DisplayOnList(2)]
        public string? Tipo { get; set; }
    }
}
