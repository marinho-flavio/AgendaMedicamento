using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using SES.Core.Domain.Attributes.T4;
using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SES.Schedulings.Domain.Aggregates.UsersAgg.Entities
{
    [Table("AspNetUsers"), EndpointsT4(EndpointTypes.HttpAll)]
    public class User : Entity<string>
    {
        public int? EmpresaId { get; set; }
        public Empresa? Empresa { get; set; }
    }
}
