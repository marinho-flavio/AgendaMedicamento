using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.ValueObjects;
using Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Entities;

namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities
{
    [Steppable(2), EndpointsT4(4, EndpointTypes.HttpAll)]
    public class Profissional : BaseFuncionario
    {
        [ForeignDataSelectorDropDownWithAutoComplete]
        public virtual Cbo Cbo { get; set; }

        [IgnorePropertyT4]
        public virtual Empresa Empresa { get; set; }

        [Step(2)]
        public virtual ProfissionalConfiguracao ProfissionalConfiguracao { get; set; }
        public virtual List<AgendaProfissional> AgendaProfissionalAgenda { get; set; }
    }
}
