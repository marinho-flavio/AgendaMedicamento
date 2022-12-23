using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SES.Core.Domain.Aggregates.CommonAgg.ValueObjects
{
    public class BaseAggregateSettings : Entity
    {

        [Column(TypeName = "jsonb")]
        public AutoSaveSettings AutoSaveSettings { get; set; }
    }
}
