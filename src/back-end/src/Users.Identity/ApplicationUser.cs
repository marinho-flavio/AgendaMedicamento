using SES.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using SES.Core.Domain.Attributes.T4;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SES.Users.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.ExternalId = Guid.NewGuid().ToString();
            this.CreatedAt = DateTime.UtcNow;
        }
        public string Name { get; set; }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Atualizado em")]
        public DateTime? UpdatedAt { get; set; }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Deletado em")]
        public DateTime? DeletedAt { get; set; }

        public string ExternalId { get; set; }

        [IgnorePropertyT4OnRequest]
        public bool IsDeleted { get; set; }

        [Column(TypeName = "jsonb")]
        public List<EventsHistory>? EventsHistory { get; set; }
        public int? RecoverPasswordCode { get; set; }
        public DateTime? RecoverPasswordCodeDate { get; set; }

        public int? EmpresaId { get; set; }
    }
}
