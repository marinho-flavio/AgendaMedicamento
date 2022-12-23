using Bravo.CrossCutting.Infra.Log.Contexts;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.CommandModels
{
    using Queries.Models; 
    using Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests; 
    public partial class CreateConvenioCommand : BaseRequestableCommand<ConvenioQueryModel, ConvenioDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateConvenioCommand(ILogRequestContext ctx, ConvenioDTO data, bool updateIfExists = true, ConvenioQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteConvenioCommand : BaseDeletionCommand<ConvenioQueryModel>
    {
        public DeleteConvenioCommand(ILogRequestContext ctx, ConvenioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeConvenioCommand : BaseDeletionCommand<ConvenioQueryModel>
    {
        public DeleteRangeConvenioCommand(ILogRequestContext ctx, ConvenioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeConvenioCommand : BaseRequestableRangeCommand<ConvenioQueryModel, ConvenioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeConvenioCommand(ILogRequestContext ctx, Dictionary<ConvenioQueryModel, ConvenioDTO> query)
            : base(ctx, query) { }
        public UpdateRangeConvenioCommand(ILogRequestContext ctx, ConvenioQueryModel query, ConvenioDTO data)
            : base(ctx, new Dictionary<ConvenioQueryModel, ConvenioDTO> { { query, data } }) { }
    }
    
    public partial class UpdateConvenioCommand : BaseRequestableCommand<ConvenioQueryModel, ConvenioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateConvenioCommand(ILogRequestContext ctx, ConvenioQueryModel query, ConvenioDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveConvenioCommand : ConvenioSearchableCommand
    {
        public ActiveConvenioCommand(ILogRequestContext ctx, ConvenioQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveConvenioCommand : ConvenioSearchableCommand
    {
        public DeactiveConvenioCommand(ILogRequestContext ctx, ConvenioQueryModel query)
            : base(ctx, query) { }
    }
    public class ConvenioSearchableCommand : BaseSearchableCommand<ConvenioQueryModel> {
        public ConvenioSearchableCommand(ILogRequestContext ctx, ConvenioQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateHealthPlansAggSettingsCommand : BaseRequestableCommand<HealthPlansAggSettingsQueryModel, HealthPlansAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateHealthPlansAggSettingsCommand(ILogRequestContext ctx, HealthPlansAggSettingsDTO data, bool updateIfExists = true, HealthPlansAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteHealthPlansAggSettingsCommand : BaseDeletionCommand<HealthPlansAggSettingsQueryModel>
    {
        public DeleteHealthPlansAggSettingsCommand(ILogRequestContext ctx, HealthPlansAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeHealthPlansAggSettingsCommand : BaseDeletionCommand<HealthPlansAggSettingsQueryModel>
    {
        public DeleteRangeHealthPlansAggSettingsCommand(ILogRequestContext ctx, HealthPlansAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeHealthPlansAggSettingsCommand : BaseRequestableRangeCommand<HealthPlansAggSettingsQueryModel, HealthPlansAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeHealthPlansAggSettingsCommand(ILogRequestContext ctx, Dictionary<HealthPlansAggSettingsQueryModel, HealthPlansAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeHealthPlansAggSettingsCommand(ILogRequestContext ctx, HealthPlansAggSettingsQueryModel query, HealthPlansAggSettingsDTO data)
            : base(ctx, new Dictionary<HealthPlansAggSettingsQueryModel, HealthPlansAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateHealthPlansAggSettingsCommand : BaseRequestableCommand<HealthPlansAggSettingsQueryModel, HealthPlansAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateHealthPlansAggSettingsCommand(ILogRequestContext ctx, HealthPlansAggSettingsQueryModel query, HealthPlansAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveHealthPlansAggSettingsCommand : HealthPlansAggSettingsSearchableCommand
    {
        public ActiveHealthPlansAggSettingsCommand(ILogRequestContext ctx, HealthPlansAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveHealthPlansAggSettingsCommand : HealthPlansAggSettingsSearchableCommand
    {
        public DeactiveHealthPlansAggSettingsCommand(ILogRequestContext ctx, HealthPlansAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class HealthPlansAggSettingsSearchableCommand : BaseSearchableCommand<HealthPlansAggSettingsQueryModel> {
        public HealthPlansAggSettingsSearchableCommand(ILogRequestContext ctx, HealthPlansAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreatePlanoConvenioCommand : BaseRequestableCommand<PlanoConvenioQueryModel, PlanoConvenioDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreatePlanoConvenioCommand(ILogRequestContext ctx, PlanoConvenioDTO data, bool updateIfExists = true, PlanoConvenioQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeletePlanoConvenioCommand : BaseDeletionCommand<PlanoConvenioQueryModel>
    {
        public DeletePlanoConvenioCommand(ILogRequestContext ctx, PlanoConvenioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangePlanoConvenioCommand : BaseDeletionCommand<PlanoConvenioQueryModel>
    {
        public DeleteRangePlanoConvenioCommand(ILogRequestContext ctx, PlanoConvenioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangePlanoConvenioCommand : BaseRequestableRangeCommand<PlanoConvenioQueryModel, PlanoConvenioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangePlanoConvenioCommand(ILogRequestContext ctx, Dictionary<PlanoConvenioQueryModel, PlanoConvenioDTO> query)
            : base(ctx, query) { }
        public UpdateRangePlanoConvenioCommand(ILogRequestContext ctx, PlanoConvenioQueryModel query, PlanoConvenioDTO data)
            : base(ctx, new Dictionary<PlanoConvenioQueryModel, PlanoConvenioDTO> { { query, data } }) { }
    }
    
    public partial class UpdatePlanoConvenioCommand : BaseRequestableCommand<PlanoConvenioQueryModel, PlanoConvenioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdatePlanoConvenioCommand(ILogRequestContext ctx, PlanoConvenioQueryModel query, PlanoConvenioDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActivePlanoConvenioCommand : PlanoConvenioSearchableCommand
    {
        public ActivePlanoConvenioCommand(ILogRequestContext ctx, PlanoConvenioQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactivePlanoConvenioCommand : PlanoConvenioSearchableCommand
    {
        public DeactivePlanoConvenioCommand(ILogRequestContext ctx, PlanoConvenioQueryModel query)
            : base(ctx, query) { }
    }
    public class PlanoConvenioSearchableCommand : BaseSearchableCommand<PlanoConvenioQueryModel> {
        public PlanoConvenioSearchableCommand(ILogRequestContext ctx, PlanoConvenioQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateTipoPlanoCommand : BaseRequestableCommand<TipoPlanoQueryModel, TipoPlanoDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateTipoPlanoCommand(ILogRequestContext ctx, TipoPlanoDTO data, bool updateIfExists = true, TipoPlanoQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteTipoPlanoCommand : BaseDeletionCommand<TipoPlanoQueryModel>
    {
        public DeleteTipoPlanoCommand(ILogRequestContext ctx, TipoPlanoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeTipoPlanoCommand : BaseDeletionCommand<TipoPlanoQueryModel>
    {
        public DeleteRangeTipoPlanoCommand(ILogRequestContext ctx, TipoPlanoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeTipoPlanoCommand : BaseRequestableRangeCommand<TipoPlanoQueryModel, TipoPlanoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeTipoPlanoCommand(ILogRequestContext ctx, Dictionary<TipoPlanoQueryModel, TipoPlanoDTO> query)
            : base(ctx, query) { }
        public UpdateRangeTipoPlanoCommand(ILogRequestContext ctx, TipoPlanoQueryModel query, TipoPlanoDTO data)
            : base(ctx, new Dictionary<TipoPlanoQueryModel, TipoPlanoDTO> { { query, data } }) { }
    }
    
    public partial class UpdateTipoPlanoCommand : BaseRequestableCommand<TipoPlanoQueryModel, TipoPlanoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateTipoPlanoCommand(ILogRequestContext ctx, TipoPlanoQueryModel query, TipoPlanoDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveTipoPlanoCommand : TipoPlanoSearchableCommand
    {
        public ActiveTipoPlanoCommand(ILogRequestContext ctx, TipoPlanoQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveTipoPlanoCommand : TipoPlanoSearchableCommand
    {
        public DeactiveTipoPlanoCommand(ILogRequestContext ctx, TipoPlanoQueryModel query)
            : base(ctx, query) { }
    }
    public class TipoPlanoSearchableCommand : BaseSearchableCommand<TipoPlanoQueryModel> {
        public TipoPlanoSearchableCommand(ILogRequestContext ctx, TipoPlanoQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateConvenioHorasEspeciaisCommand : BaseRequestableCommand<ConvenioHorasEspeciaisQueryModel, ConvenioHorasEspeciaisDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateConvenioHorasEspeciaisCommand(ILogRequestContext ctx, ConvenioHorasEspeciaisDTO data, bool updateIfExists = true, ConvenioHorasEspeciaisQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteConvenioHorasEspeciaisCommand : BaseDeletionCommand<ConvenioHorasEspeciaisQueryModel>
    {
        public DeleteConvenioHorasEspeciaisCommand(ILogRequestContext ctx, ConvenioHorasEspeciaisQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeConvenioHorasEspeciaisCommand : BaseDeletionCommand<ConvenioHorasEspeciaisQueryModel>
    {
        public DeleteRangeConvenioHorasEspeciaisCommand(ILogRequestContext ctx, ConvenioHorasEspeciaisQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeConvenioHorasEspeciaisCommand : BaseRequestableRangeCommand<ConvenioHorasEspeciaisQueryModel, ConvenioHorasEspeciaisDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeConvenioHorasEspeciaisCommand(ILogRequestContext ctx, Dictionary<ConvenioHorasEspeciaisQueryModel, ConvenioHorasEspeciaisDTO> query)
            : base(ctx, query) { }
        public UpdateRangeConvenioHorasEspeciaisCommand(ILogRequestContext ctx, ConvenioHorasEspeciaisQueryModel query, ConvenioHorasEspeciaisDTO data)
            : base(ctx, new Dictionary<ConvenioHorasEspeciaisQueryModel, ConvenioHorasEspeciaisDTO> { { query, data } }) { }
    }
    
    public partial class UpdateConvenioHorasEspeciaisCommand : BaseRequestableCommand<ConvenioHorasEspeciaisQueryModel, ConvenioHorasEspeciaisDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateConvenioHorasEspeciaisCommand(ILogRequestContext ctx, ConvenioHorasEspeciaisQueryModel query, ConvenioHorasEspeciaisDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveConvenioHorasEspeciaisCommand : ConvenioHorasEspeciaisSearchableCommand
    {
        public ActiveConvenioHorasEspeciaisCommand(ILogRequestContext ctx, ConvenioHorasEspeciaisQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveConvenioHorasEspeciaisCommand : ConvenioHorasEspeciaisSearchableCommand
    {
        public DeactiveConvenioHorasEspeciaisCommand(ILogRequestContext ctx, ConvenioHorasEspeciaisQueryModel query)
            : base(ctx, query) { }
    }
    public class ConvenioHorasEspeciaisSearchableCommand : BaseSearchableCommand<ConvenioHorasEspeciaisQueryModel> {
        public ConvenioHorasEspeciaisSearchableCommand(ILogRequestContext ctx, ConvenioHorasEspeciaisQueryModel query)
            : base(ctx, query) { }
    }

}
