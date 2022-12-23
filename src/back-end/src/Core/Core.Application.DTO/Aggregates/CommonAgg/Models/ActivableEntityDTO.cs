using System.ComponentModel.DataAnnotations;

namespace SES.Core.Application.DTO.Aggregates.CommonAgg.Models
{
    public abstract class ActivableEntityDTO : EntityDTO
    {
        public bool? Ativo { get; set; }
    }
}
