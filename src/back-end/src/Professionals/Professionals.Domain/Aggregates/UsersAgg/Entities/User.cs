using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bravo.Professionals.Domain.Aggregates.UsersAgg.Entities
{
    [Table("AspNetUsers")]
    [EndpointsT4(EndpointTypes.HttpGet)]
    public class User : Entity<string>
    {
    }
}
