using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.Professionals.Domain.Aggregates.UsersAgg.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities
{
    [AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class ProfessionalsAggSettings : BaseAggregateSettings
    {
        [Required]
        public string UserId { get; set; }

        [IgnorePropertyT4OnRequest]
        public User User { get; set; }
    }
}