using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bravo.Addresses.Domain.Aggregates.UsersAgg.Entities
{
    [Table("AspNetUsers")]
    [EndpointsT4(EndpointTypes.HttpGet)]
    public partial class User : Entity<string>
    {
    }
}
