using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.ValueObjects;
using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Entities
{
    [Steppable(2), MigrationOrder(3), EndpointsT4(EndpointTypes.HttpAll)]
    public class Profissional : BaseFuncionario
    {
        [ForeignDataSelectorDropDownWithAutoComplete]
        public virtual Cbo Cbo { get; set; }

        [IgnorePropertyT4]
        public virtual Empresa Empresa { get; set; }

        [Step(2)]
        public virtual ProfissionalConfiguracao ProfissionalConfiguracao { get; set; }
    }
}