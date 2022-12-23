using MongoDB.Bson.Serialization.Attributes;
using SES.Core.Domain.Aggregates.CommonAgg.Events;
using SES.Core.Domain.Attributes.T4;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SES.CrossCuting.Infra.Utils.Extensions;
using SES.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using SES.Core.Application.DTO.Attributes;
using SES.Core.Application.DTO.Extensions;
using System.Reflection;

namespace SES.Core.Domain.Aggregates.CommonAgg.Entities
{
    public abstract class Entity : Entity<int>
    {
        public Entity()
        {
        }
    }

    public abstract class ActivableEntity : ActivableEntity<int>
    {
    }

    public abstract class ActivableEntity<T> : Entity<T>
        where T : IEquatable<T>
    {
        [DisplayName("Habilitado?")]
        public bool? Ativo { get; set; }

        public void Enable()
        {
        }

        public void Disable()
        {
        }
    }

    public abstract class Entity<T>
        where T : IEquatable<T>
    {
        [NotMapped]
        [IgnorePropertyT4]
        [BsonIgnore]
        private List<BaseEvent> _domainEvents;

        public Entity()
        {
            CreatedAt = CreatedAt ?? DateTime.UtcNow;
        }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Criado em")]
        public DateTime? CreatedAt { get; set; }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Atualizado em")]
        public DateTime? UpdatedAt { get; set; }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Deletado em")]
        public DateTime? DeletedAt { get; set; }

        [Key]
        [BsonId]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }

        public string ExternalId { get; set; }

        [IgnorePropertyT4OnRequest]
        public bool IsDeleted { get; set; }

        [IgnorePropertyT4]
        [NotMapped]
        [BsonIgnore]
        public IReadOnlyCollection<BaseEvent> DomainEvents { get; set; }

        [Column(TypeName = "jsonb")]
        public List<EventsHistory>? EventsHistory { get; set; }

        public void Delete()
        {
            this.IsDeleted = true;
            this.DeletedAt = DateTime.UtcNow;
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public void AddDomainEvent(BaseEvent domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<BaseEvent>();
            _domainEvents.Add(domainEvent);
        }
        public bool IsEmpty()
        {
            return this.IsEmpty();
        }

        
    }
}
