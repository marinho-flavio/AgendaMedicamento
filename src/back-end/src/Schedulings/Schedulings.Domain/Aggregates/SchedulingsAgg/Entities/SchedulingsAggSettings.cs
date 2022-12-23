using SES.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using SES.Core.Domain.Attributes.T4;
using SES.Schedulings.Domain.Aggregates.UsersAgg.Entities;
using System.ComponentModel.DataAnnotations;

namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Entities
{
    [AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class SchedulingsAggSettings : BaseAggregateSettings
    {
        [Required]
        public string UserId { get; set; }

        [IgnorePropertyT4OnRequest]
        public User User { get; set; }
    }
}