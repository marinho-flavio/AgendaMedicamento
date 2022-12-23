
using Bravo.Partners.Domain.Aggregates.UsersAgg.Entities;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities
{
    [AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class PartnersAggSettings : BaseAggregateSettings
    {
        [Required]
        public string UserId { get; set; }

        [IgnorePropertyT4OnRequest]
        public User User { get; set; }
    }
}
