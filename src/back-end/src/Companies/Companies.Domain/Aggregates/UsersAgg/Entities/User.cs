using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bravo.Companies.Domain.Aggregates.UsersAgg.Entities
{
    [Table("AspNetUsers")]
    [MigrationOrder(2), EndpointsT4(EndpointTypes.HttpGet)]
    public class User : Entity<string>
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? EmpresaId { get; set; }
        public Empresa? Empresa { get; set; }
    }
}
