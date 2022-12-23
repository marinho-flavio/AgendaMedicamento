using Bravo.Companies.Domain.Aggregates.AddressesAgg.ValueObjects;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities
{
    [MigrationOrder(0), EndpointsT4(EndpointTypes.HttpGet)]
    public class Endereco : BaseEndereco
    {
    }
}
