using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Companies.Domain.Aggregates.PatientsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Paciente : Entity
    {
        public string? Nome { get; set; }
        public string Cpf { get; set; }
    }
}
