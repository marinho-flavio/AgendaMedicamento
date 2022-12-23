
using SES.Users.Domain.Aggregates.UsersAgg.Entities;
using SES.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using SES.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace SES.Users.Domain.Aggregates.UsersAgg.Entities
{
    [AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class UsersAggSettings : BaseAggregateSettings
    {
        [Required]
        public string UserId { get; set; }

        [IgnorePropertyT4OnRequest]
        public User User { get; set; }
    }
}
