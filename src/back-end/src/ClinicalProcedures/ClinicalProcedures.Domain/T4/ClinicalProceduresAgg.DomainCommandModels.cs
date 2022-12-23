using Bravo.CrossCutting.Infra.Log.Contexts;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.CommandModels
{
    using Queries.Models; 
    using Bravo.ClinicalProcedures.Application.DTO.Aggregates.ClinicalProceduresAgg.Requests; 
    public partial class CreateClinicalProceduresAggSettingsCommand : BaseRequestableCommand<ClinicalProceduresAggSettingsQueryModel, ClinicalProceduresAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateClinicalProceduresAggSettingsCommand(ILogRequestContext ctx, ClinicalProceduresAggSettingsDTO data, bool updateIfExists = true, ClinicalProceduresAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteClinicalProceduresAggSettingsCommand : BaseDeletionCommand<ClinicalProceduresAggSettingsQueryModel>
    {
        public DeleteClinicalProceduresAggSettingsCommand(ILogRequestContext ctx, ClinicalProceduresAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeClinicalProceduresAggSettingsCommand : BaseDeletionCommand<ClinicalProceduresAggSettingsQueryModel>
    {
        public DeleteRangeClinicalProceduresAggSettingsCommand(ILogRequestContext ctx, ClinicalProceduresAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeClinicalProceduresAggSettingsCommand : BaseRequestableRangeCommand<ClinicalProceduresAggSettingsQueryModel, ClinicalProceduresAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeClinicalProceduresAggSettingsCommand(ILogRequestContext ctx, Dictionary<ClinicalProceduresAggSettingsQueryModel, ClinicalProceduresAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeClinicalProceduresAggSettingsCommand(ILogRequestContext ctx, ClinicalProceduresAggSettingsQueryModel query, ClinicalProceduresAggSettingsDTO data)
            : base(ctx, new Dictionary<ClinicalProceduresAggSettingsQueryModel, ClinicalProceduresAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateClinicalProceduresAggSettingsCommand : BaseRequestableCommand<ClinicalProceduresAggSettingsQueryModel, ClinicalProceduresAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateClinicalProceduresAggSettingsCommand(ILogRequestContext ctx, ClinicalProceduresAggSettingsQueryModel query, ClinicalProceduresAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveClinicalProceduresAggSettingsCommand : ClinicalProceduresAggSettingsSearchableCommand
    {
        public ActiveClinicalProceduresAggSettingsCommand(ILogRequestContext ctx, ClinicalProceduresAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveClinicalProceduresAggSettingsCommand : ClinicalProceduresAggSettingsSearchableCommand
    {
        public DeactiveClinicalProceduresAggSettingsCommand(ILogRequestContext ctx, ClinicalProceduresAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class ClinicalProceduresAggSettingsSearchableCommand : BaseSearchableCommand<ClinicalProceduresAggSettingsQueryModel> {
        public ClinicalProceduresAggSettingsSearchableCommand(ILogRequestContext ctx, ClinicalProceduresAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

}
