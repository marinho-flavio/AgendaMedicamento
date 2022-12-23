using Bravo.CrossCutting.Infra.Log.Contexts;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.CommandModels
{
    using Queries.Models; 
    using Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Requests; 
    public partial class CreateProfissionalConfiguracaoCommand : BaseRequestableCommand<ProfissionalConfiguracaoQueryModel, ProfissionalConfiguracaoDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateProfissionalConfiguracaoCommand(ILogRequestContext ctx, ProfissionalConfiguracaoDTO data, bool updateIfExists = true, ProfissionalConfiguracaoQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteProfissionalConfiguracaoCommand : BaseDeletionCommand<ProfissionalConfiguracaoQueryModel>
    {
        public DeleteProfissionalConfiguracaoCommand(ILogRequestContext ctx, ProfissionalConfiguracaoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeProfissionalConfiguracaoCommand : BaseDeletionCommand<ProfissionalConfiguracaoQueryModel>
    {
        public DeleteRangeProfissionalConfiguracaoCommand(ILogRequestContext ctx, ProfissionalConfiguracaoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeProfissionalConfiguracaoCommand : BaseRequestableRangeCommand<ProfissionalConfiguracaoQueryModel, ProfissionalConfiguracaoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeProfissionalConfiguracaoCommand(ILogRequestContext ctx, Dictionary<ProfissionalConfiguracaoQueryModel, ProfissionalConfiguracaoDTO> query)
            : base(ctx, query) { }
        public UpdateRangeProfissionalConfiguracaoCommand(ILogRequestContext ctx, ProfissionalConfiguracaoQueryModel query, ProfissionalConfiguracaoDTO data)
            : base(ctx, new Dictionary<ProfissionalConfiguracaoQueryModel, ProfissionalConfiguracaoDTO> { { query, data } }) { }
    }
    
    public partial class UpdateProfissionalConfiguracaoCommand : BaseRequestableCommand<ProfissionalConfiguracaoQueryModel, ProfissionalConfiguracaoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateProfissionalConfiguracaoCommand(ILogRequestContext ctx, ProfissionalConfiguracaoQueryModel query, ProfissionalConfiguracaoDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveProfissionalConfiguracaoCommand : ProfissionalConfiguracaoSearchableCommand
    {
        public ActiveProfissionalConfiguracaoCommand(ILogRequestContext ctx, ProfissionalConfiguracaoQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveProfissionalConfiguracaoCommand : ProfissionalConfiguracaoSearchableCommand
    {
        public DeactiveProfissionalConfiguracaoCommand(ILogRequestContext ctx, ProfissionalConfiguracaoQueryModel query)
            : base(ctx, query) { }
    }
    public class ProfissionalConfiguracaoSearchableCommand : BaseSearchableCommand<ProfissionalConfiguracaoQueryModel> {
        public ProfissionalConfiguracaoSearchableCommand(ILogRequestContext ctx, ProfissionalConfiguracaoQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateFuncionarioCommand : BaseRequestableCommand<FuncionarioQueryModel, FuncionarioDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateFuncionarioCommand(ILogRequestContext ctx, FuncionarioDTO data, bool updateIfExists = true, FuncionarioQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteFuncionarioCommand : BaseDeletionCommand<FuncionarioQueryModel>
    {
        public DeleteFuncionarioCommand(ILogRequestContext ctx, FuncionarioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeFuncionarioCommand : BaseDeletionCommand<FuncionarioQueryModel>
    {
        public DeleteRangeFuncionarioCommand(ILogRequestContext ctx, FuncionarioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeFuncionarioCommand : BaseRequestableRangeCommand<FuncionarioQueryModel, FuncionarioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeFuncionarioCommand(ILogRequestContext ctx, Dictionary<FuncionarioQueryModel, FuncionarioDTO> query)
            : base(ctx, query) { }
        public UpdateRangeFuncionarioCommand(ILogRequestContext ctx, FuncionarioQueryModel query, FuncionarioDTO data)
            : base(ctx, new Dictionary<FuncionarioQueryModel, FuncionarioDTO> { { query, data } }) { }
    }
    
    public partial class UpdateFuncionarioCommand : BaseRequestableCommand<FuncionarioQueryModel, FuncionarioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateFuncionarioCommand(ILogRequestContext ctx, FuncionarioQueryModel query, FuncionarioDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveFuncionarioCommand : FuncionarioSearchableCommand
    {
        public ActiveFuncionarioCommand(ILogRequestContext ctx, FuncionarioQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveFuncionarioCommand : FuncionarioSearchableCommand
    {
        public DeactiveFuncionarioCommand(ILogRequestContext ctx, FuncionarioQueryModel query)
            : base(ctx, query) { }
    }
    public class FuncionarioSearchableCommand : BaseSearchableCommand<FuncionarioQueryModel> {
        public FuncionarioSearchableCommand(ILogRequestContext ctx, FuncionarioQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateProfissionalCommand : BaseRequestableCommand<ProfissionalQueryModel, ProfissionalDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateProfissionalCommand(ILogRequestContext ctx, ProfissionalDTO data, bool updateIfExists = true, ProfissionalQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteProfissionalCommand : BaseDeletionCommand<ProfissionalQueryModel>
    {
        public DeleteProfissionalCommand(ILogRequestContext ctx, ProfissionalQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeProfissionalCommand : BaseDeletionCommand<ProfissionalQueryModel>
    {
        public DeleteRangeProfissionalCommand(ILogRequestContext ctx, ProfissionalQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeProfissionalCommand : BaseRequestableRangeCommand<ProfissionalQueryModel, ProfissionalDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeProfissionalCommand(ILogRequestContext ctx, Dictionary<ProfissionalQueryModel, ProfissionalDTO> query)
            : base(ctx, query) { }
        public UpdateRangeProfissionalCommand(ILogRequestContext ctx, ProfissionalQueryModel query, ProfissionalDTO data)
            : base(ctx, new Dictionary<ProfissionalQueryModel, ProfissionalDTO> { { query, data } }) { }
    }
    
    public partial class UpdateProfissionalCommand : BaseRequestableCommand<ProfissionalQueryModel, ProfissionalDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateProfissionalCommand(ILogRequestContext ctx, ProfissionalQueryModel query, ProfissionalDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveProfissionalCommand : ProfissionalSearchableCommand
    {
        public ActiveProfissionalCommand(ILogRequestContext ctx, ProfissionalQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveProfissionalCommand : ProfissionalSearchableCommand
    {
        public DeactiveProfissionalCommand(ILogRequestContext ctx, ProfissionalQueryModel query)
            : base(ctx, query) { }
    }
    public class ProfissionalSearchableCommand : BaseSearchableCommand<ProfissionalQueryModel> {
        public ProfissionalSearchableCommand(ILogRequestContext ctx, ProfissionalQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateProfessionalsAggSettingsCommand : BaseRequestableCommand<ProfessionalsAggSettingsQueryModel, ProfessionalsAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateProfessionalsAggSettingsCommand(ILogRequestContext ctx, ProfessionalsAggSettingsDTO data, bool updateIfExists = true, ProfessionalsAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteProfessionalsAggSettingsCommand : BaseDeletionCommand<ProfessionalsAggSettingsQueryModel>
    {
        public DeleteProfessionalsAggSettingsCommand(ILogRequestContext ctx, ProfessionalsAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeProfessionalsAggSettingsCommand : BaseDeletionCommand<ProfessionalsAggSettingsQueryModel>
    {
        public DeleteRangeProfessionalsAggSettingsCommand(ILogRequestContext ctx, ProfessionalsAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeProfessionalsAggSettingsCommand : BaseRequestableRangeCommand<ProfessionalsAggSettingsQueryModel, ProfessionalsAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeProfessionalsAggSettingsCommand(ILogRequestContext ctx, Dictionary<ProfessionalsAggSettingsQueryModel, ProfessionalsAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeProfessionalsAggSettingsCommand(ILogRequestContext ctx, ProfessionalsAggSettingsQueryModel query, ProfessionalsAggSettingsDTO data)
            : base(ctx, new Dictionary<ProfessionalsAggSettingsQueryModel, ProfessionalsAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateProfessionalsAggSettingsCommand : BaseRequestableCommand<ProfessionalsAggSettingsQueryModel, ProfessionalsAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateProfessionalsAggSettingsCommand(ILogRequestContext ctx, ProfessionalsAggSettingsQueryModel query, ProfessionalsAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveProfessionalsAggSettingsCommand : ProfessionalsAggSettingsSearchableCommand
    {
        public ActiveProfessionalsAggSettingsCommand(ILogRequestContext ctx, ProfessionalsAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveProfessionalsAggSettingsCommand : ProfessionalsAggSettingsSearchableCommand
    {
        public DeactiveProfessionalsAggSettingsCommand(ILogRequestContext ctx, ProfessionalsAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class ProfessionalsAggSettingsSearchableCommand : BaseSearchableCommand<ProfessionalsAggSettingsQueryModel> {
        public ProfessionalsAggSettingsSearchableCommand(ILogRequestContext ctx, ProfessionalsAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateCboCommand : BaseRequestableCommand<CboQueryModel, CboDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateCboCommand(ILogRequestContext ctx, CboDTO data, bool updateIfExists = true, CboQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteCboCommand : BaseDeletionCommand<CboQueryModel>
    {
        public DeleteCboCommand(ILogRequestContext ctx, CboQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeCboCommand : BaseDeletionCommand<CboQueryModel>
    {
        public DeleteRangeCboCommand(ILogRequestContext ctx, CboQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeCboCommand : BaseRequestableRangeCommand<CboQueryModel, CboDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeCboCommand(ILogRequestContext ctx, Dictionary<CboQueryModel, CboDTO> query)
            : base(ctx, query) { }
        public UpdateRangeCboCommand(ILogRequestContext ctx, CboQueryModel query, CboDTO data)
            : base(ctx, new Dictionary<CboQueryModel, CboDTO> { { query, data } }) { }
    }
    
    public partial class UpdateCboCommand : BaseRequestableCommand<CboQueryModel, CboDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateCboCommand(ILogRequestContext ctx, CboQueryModel query, CboDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveCboCommand : CboSearchableCommand
    {
        public ActiveCboCommand(ILogRequestContext ctx, CboQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveCboCommand : CboSearchableCommand
    {
        public DeactiveCboCommand(ILogRequestContext ctx, CboQueryModel query)
            : base(ctx, query) { }
    }
    public class CboSearchableCommand : BaseSearchableCommand<CboQueryModel> {
        public CboSearchableCommand(ILogRequestContext ctx, CboQueryModel query)
            : base(ctx, query) { }
    }

}
