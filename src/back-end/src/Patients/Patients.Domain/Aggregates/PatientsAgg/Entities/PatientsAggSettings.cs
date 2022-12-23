
using Bravo.Patients.Domain.Aggregates.UsersAgg.Entities;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.Entities
{
    [AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class PatientsAggSettings : BaseAggregateSettings
    {
        [Required]
        public string UserId { get; set; }

        [IgnorePropertyT4OnRequest]
        public User User { get; set; }
    }
}
