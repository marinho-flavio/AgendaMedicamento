using Bravo.Core.Domain.Attributes.T4;
using Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.ValueObjects;

namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Funcionario : BaseFuncionario
    {
        public virtual Cbo Cbo { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
