using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.ValueObjects;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Entities
{
    [Steppable(1), EndpointsT4(EndpointTypes.HttpAll)]
    public class Funcionario : BaseFuncionario
    {
        [IgnorePropertyT4]
        public virtual Empresa Empresa { get; set; }
    }
}