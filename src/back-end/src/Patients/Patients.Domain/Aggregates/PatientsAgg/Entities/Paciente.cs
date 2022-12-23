using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.Patients.Enumerations;

namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Paciente : Entity
    {
        [DisplayOnList(0)]
        public string Tipo { get; set; }
    }
}
