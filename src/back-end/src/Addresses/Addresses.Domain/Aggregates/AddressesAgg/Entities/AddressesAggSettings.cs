using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.Entities
{
    [MigrationOrder(0), AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class AddressesAggSettings : Entity
    {
    }
}