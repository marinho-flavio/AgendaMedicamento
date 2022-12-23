using Bravo.Companies.Domain.Aggregates.UsersAgg.Entities;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities
{
    [MigrationOrder(1), AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class CompaniesAggSettings : BaseAggregateSettings
    {
        [Required]
        public string UserId { get; set; }

        [IgnorePropertyT4OnRequest]
        public User User { get; set; }
    }
}