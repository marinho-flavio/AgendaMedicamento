using SES.Core.Application.DTO.Aggregates.CommonAgg.ValueObjects;

namespace SES.Core.Application.DTO.Aggregates.CommonAgg.Models
{
    public class BaseAggregateSettingsDTO : EntityDTO
    {
        public AutoSaveSettingsDTO AutoSaveSettings { get; set; } = new AutoSaveSettingsDTO();
    }
}
