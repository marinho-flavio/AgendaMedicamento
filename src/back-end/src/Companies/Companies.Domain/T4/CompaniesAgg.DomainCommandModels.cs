using Bravo.CrossCutting.Infra.Log.Contexts;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.CommandModels
{
    using Queries.Models; 
    using Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Requests; 
    public partial class CreateEmpresaCommand : BaseRequestableCommand<EmpresaQueryModel, EmpresaDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateEmpresaCommand(ILogRequestContext ctx, EmpresaDTO data, bool updateIfExists = true, EmpresaQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteEmpresaCommand : BaseDeletionCommand<EmpresaQueryModel>
    {
        public DeleteEmpresaCommand(ILogRequestContext ctx, EmpresaQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeEmpresaCommand : BaseDeletionCommand<EmpresaQueryModel>
    {
        public DeleteRangeEmpresaCommand(ILogRequestContext ctx, EmpresaQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeEmpresaCommand : BaseRequestableRangeCommand<EmpresaQueryModel, EmpresaDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeEmpresaCommand(ILogRequestContext ctx, Dictionary<EmpresaQueryModel, EmpresaDTO> query)
            : base(ctx, query) { }
        public UpdateRangeEmpresaCommand(ILogRequestContext ctx, EmpresaQueryModel query, EmpresaDTO data)
            : base(ctx, new Dictionary<EmpresaQueryModel, EmpresaDTO> { { query, data } }) { }
    }
    
    public partial class UpdateEmpresaCommand : BaseRequestableCommand<EmpresaQueryModel, EmpresaDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateEmpresaCommand(ILogRequestContext ctx, EmpresaQueryModel query, EmpresaDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveEmpresaCommand : EmpresaSearchableCommand
    {
        public ActiveEmpresaCommand(ILogRequestContext ctx, EmpresaQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveEmpresaCommand : EmpresaSearchableCommand
    {
        public DeactiveEmpresaCommand(ILogRequestContext ctx, EmpresaQueryModel query)
            : base(ctx, query) { }
    }
    public class EmpresaSearchableCommand : BaseSearchableCommand<EmpresaQueryModel> {
        public EmpresaSearchableCommand(ILogRequestContext ctx, EmpresaQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateCompaniesAggSettingsCommand : BaseRequestableCommand<CompaniesAggSettingsQueryModel, CompaniesAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateCompaniesAggSettingsCommand(ILogRequestContext ctx, CompaniesAggSettingsDTO data, bool updateIfExists = true, CompaniesAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteCompaniesAggSettingsCommand : BaseDeletionCommand<CompaniesAggSettingsQueryModel>
    {
        public DeleteCompaniesAggSettingsCommand(ILogRequestContext ctx, CompaniesAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeCompaniesAggSettingsCommand : BaseDeletionCommand<CompaniesAggSettingsQueryModel>
    {
        public DeleteRangeCompaniesAggSettingsCommand(ILogRequestContext ctx, CompaniesAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeCompaniesAggSettingsCommand : BaseRequestableRangeCommand<CompaniesAggSettingsQueryModel, CompaniesAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeCompaniesAggSettingsCommand(ILogRequestContext ctx, Dictionary<CompaniesAggSettingsQueryModel, CompaniesAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeCompaniesAggSettingsCommand(ILogRequestContext ctx, CompaniesAggSettingsQueryModel query, CompaniesAggSettingsDTO data)
            : base(ctx, new Dictionary<CompaniesAggSettingsQueryModel, CompaniesAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateCompaniesAggSettingsCommand : BaseRequestableCommand<CompaniesAggSettingsQueryModel, CompaniesAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateCompaniesAggSettingsCommand(ILogRequestContext ctx, CompaniesAggSettingsQueryModel query, CompaniesAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveCompaniesAggSettingsCommand : CompaniesAggSettingsSearchableCommand
    {
        public ActiveCompaniesAggSettingsCommand(ILogRequestContext ctx, CompaniesAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveCompaniesAggSettingsCommand : CompaniesAggSettingsSearchableCommand
    {
        public DeactiveCompaniesAggSettingsCommand(ILogRequestContext ctx, CompaniesAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class CompaniesAggSettingsSearchableCommand : BaseSearchableCommand<CompaniesAggSettingsQueryModel> {
        public CompaniesAggSettingsSearchableCommand(ILogRequestContext ctx, CompaniesAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateGrupoEmpresaCommand : BaseRequestableCommand<GrupoEmpresaQueryModel, GrupoEmpresaDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateGrupoEmpresaCommand(ILogRequestContext ctx, GrupoEmpresaDTO data, bool updateIfExists = true, GrupoEmpresaQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteGrupoEmpresaCommand : BaseDeletionCommand<GrupoEmpresaQueryModel>
    {
        public DeleteGrupoEmpresaCommand(ILogRequestContext ctx, GrupoEmpresaQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeGrupoEmpresaCommand : BaseDeletionCommand<GrupoEmpresaQueryModel>
    {
        public DeleteRangeGrupoEmpresaCommand(ILogRequestContext ctx, GrupoEmpresaQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeGrupoEmpresaCommand : BaseRequestableRangeCommand<GrupoEmpresaQueryModel, GrupoEmpresaDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeGrupoEmpresaCommand(ILogRequestContext ctx, Dictionary<GrupoEmpresaQueryModel, GrupoEmpresaDTO> query)
            : base(ctx, query) { }
        public UpdateRangeGrupoEmpresaCommand(ILogRequestContext ctx, GrupoEmpresaQueryModel query, GrupoEmpresaDTO data)
            : base(ctx, new Dictionary<GrupoEmpresaQueryModel, GrupoEmpresaDTO> { { query, data } }) { }
    }
    
    public partial class UpdateGrupoEmpresaCommand : BaseRequestableCommand<GrupoEmpresaQueryModel, GrupoEmpresaDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateGrupoEmpresaCommand(ILogRequestContext ctx, GrupoEmpresaQueryModel query, GrupoEmpresaDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveGrupoEmpresaCommand : GrupoEmpresaSearchableCommand
    {
        public ActiveGrupoEmpresaCommand(ILogRequestContext ctx, GrupoEmpresaQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveGrupoEmpresaCommand : GrupoEmpresaSearchableCommand
    {
        public DeactiveGrupoEmpresaCommand(ILogRequestContext ctx, GrupoEmpresaQueryModel query)
            : base(ctx, query) { }
    }
    public class GrupoEmpresaSearchableCommand : BaseSearchableCommand<GrupoEmpresaQueryModel> {
        public GrupoEmpresaSearchableCommand(ILogRequestContext ctx, GrupoEmpresaQueryModel query)
            : base(ctx, query) { }
    }

}
