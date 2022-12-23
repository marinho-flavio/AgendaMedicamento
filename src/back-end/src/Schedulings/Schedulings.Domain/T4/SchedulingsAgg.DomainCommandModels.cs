using SES.CrossCutting.Infra.Log.Contexts;
using SES.Core.Domain.Aggregates.CommonAgg.Commands;
namespace SES.Schedulings.Domain.Aggregates.CompaniesAgg.CommandModels
{
    using Queries.Models; 
    using SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests; 
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

}
namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.CommandModels
{
    using Queries.Models; 
    using SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Requests; 
    public partial class CreateSchedulingsAggSettingsCommand : BaseRequestableCommand<SchedulingsAggSettingsQueryModel, SchedulingsAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateSchedulingsAggSettingsCommand(ILogRequestContext ctx, SchedulingsAggSettingsDTO data, bool updateIfExists = true, SchedulingsAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteSchedulingsAggSettingsCommand : BaseDeletionCommand<SchedulingsAggSettingsQueryModel>
    {
        public DeleteSchedulingsAggSettingsCommand(ILogRequestContext ctx, SchedulingsAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeSchedulingsAggSettingsCommand : BaseDeletionCommand<SchedulingsAggSettingsQueryModel>
    {
        public DeleteRangeSchedulingsAggSettingsCommand(ILogRequestContext ctx, SchedulingsAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeSchedulingsAggSettingsCommand : BaseRequestableRangeCommand<SchedulingsAggSettingsQueryModel, SchedulingsAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeSchedulingsAggSettingsCommand(ILogRequestContext ctx, Dictionary<SchedulingsAggSettingsQueryModel, SchedulingsAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeSchedulingsAggSettingsCommand(ILogRequestContext ctx, SchedulingsAggSettingsQueryModel query, SchedulingsAggSettingsDTO data)
            : base(ctx, new Dictionary<SchedulingsAggSettingsQueryModel, SchedulingsAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateSchedulingsAggSettingsCommand : BaseRequestableCommand<SchedulingsAggSettingsQueryModel, SchedulingsAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateSchedulingsAggSettingsCommand(ILogRequestContext ctx, SchedulingsAggSettingsQueryModel query, SchedulingsAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveSchedulingsAggSettingsCommand : SchedulingsAggSettingsSearchableCommand
    {
        public ActiveSchedulingsAggSettingsCommand(ILogRequestContext ctx, SchedulingsAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveSchedulingsAggSettingsCommand : SchedulingsAggSettingsSearchableCommand
    {
        public DeactiveSchedulingsAggSettingsCommand(ILogRequestContext ctx, SchedulingsAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class SchedulingsAggSettingsSearchableCommand : BaseSearchableCommand<SchedulingsAggSettingsQueryModel> {
        public SchedulingsAggSettingsSearchableCommand(ILogRequestContext ctx, SchedulingsAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateFeriadoCommand : BaseRequestableCommand<FeriadoQueryModel, FeriadoDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateFeriadoCommand(ILogRequestContext ctx, FeriadoDTO data, bool updateIfExists = true, FeriadoQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteFeriadoCommand : BaseDeletionCommand<FeriadoQueryModel>
    {
        public DeleteFeriadoCommand(ILogRequestContext ctx, FeriadoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeFeriadoCommand : BaseDeletionCommand<FeriadoQueryModel>
    {
        public DeleteRangeFeriadoCommand(ILogRequestContext ctx, FeriadoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeFeriadoCommand : BaseRequestableRangeCommand<FeriadoQueryModel, FeriadoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeFeriadoCommand(ILogRequestContext ctx, Dictionary<FeriadoQueryModel, FeriadoDTO> query)
            : base(ctx, query) { }
        public UpdateRangeFeriadoCommand(ILogRequestContext ctx, FeriadoQueryModel query, FeriadoDTO data)
            : base(ctx, new Dictionary<FeriadoQueryModel, FeriadoDTO> { { query, data } }) { }
    }
    
    public partial class UpdateFeriadoCommand : BaseRequestableCommand<FeriadoQueryModel, FeriadoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateFeriadoCommand(ILogRequestContext ctx, FeriadoQueryModel query, FeriadoDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveFeriadoCommand : FeriadoSearchableCommand
    {
        public ActiveFeriadoCommand(ILogRequestContext ctx, FeriadoQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveFeriadoCommand : FeriadoSearchableCommand
    {
        public DeactiveFeriadoCommand(ILogRequestContext ctx, FeriadoQueryModel query)
            : base(ctx, query) { }
    }
    public class FeriadoSearchableCommand : BaseSearchableCommand<FeriadoQueryModel> {
        public FeriadoSearchableCommand(ILogRequestContext ctx, FeriadoQueryModel query)
            : base(ctx, query) { }
    }

}
namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.CommandModels
{
    using Queries.Models; 
    using SES.Schedulings.Application.DTO.Aggregates.ProfessionalsAgg.Requests; 
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

}
namespace SES.Schedulings.Domain.Aggregates.UsersAgg.CommandModels
{
    using Queries.Models; 
    using SES.Schedulings.Application.DTO.Aggregates.UsersAgg.Requests; 
    public partial class CreateUserCommand : BaseRequestableCommand<UserQueryModel, UserDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateUserCommand(ILogRequestContext ctx, UserDTO data, bool updateIfExists = true, UserQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteUserCommand : BaseDeletionCommand<UserQueryModel>
    {
        public DeleteUserCommand(ILogRequestContext ctx, UserQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeUserCommand : BaseDeletionCommand<UserQueryModel>
    {
        public DeleteRangeUserCommand(ILogRequestContext ctx, UserQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeUserCommand : BaseRequestableRangeCommand<UserQueryModel, UserDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeUserCommand(ILogRequestContext ctx, Dictionary<UserQueryModel, UserDTO> query)
            : base(ctx, query) { }
        public UpdateRangeUserCommand(ILogRequestContext ctx, UserQueryModel query, UserDTO data)
            : base(ctx, new Dictionary<UserQueryModel, UserDTO> { { query, data } }) { }
    }
    
    public partial class UpdateUserCommand : BaseRequestableCommand<UserQueryModel, UserDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateUserCommand(ILogRequestContext ctx, UserQueryModel query, UserDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveUserCommand : UserSearchableCommand
    {
        public ActiveUserCommand(ILogRequestContext ctx, UserQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveUserCommand : UserSearchableCommand
    {
        public DeactiveUserCommand(ILogRequestContext ctx, UserQueryModel query)
            : base(ctx, query) { }
    }
    public class UserSearchableCommand : BaseSearchableCommand<UserQueryModel> {
        public UserSearchableCommand(ILogRequestContext ctx, UserQueryModel query)
            : base(ctx, query) { }
    }

}
namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.CommandModels
{
    using Queries.Models; 
    using SES.Schedulings.Application.DTO.Aggregates.PartnersAgg.Requests; 
    public partial class CreateFornecedorCommand : BaseRequestableCommand<FornecedorQueryModel, FornecedorDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateFornecedorCommand(ILogRequestContext ctx, FornecedorDTO data, bool updateIfExists = true, FornecedorQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteFornecedorCommand : BaseDeletionCommand<FornecedorQueryModel>
    {
        public DeleteFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeFornecedorCommand : BaseDeletionCommand<FornecedorQueryModel>
    {
        public DeleteRangeFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeFornecedorCommand : BaseRequestableRangeCommand<FornecedorQueryModel, FornecedorDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeFornecedorCommand(ILogRequestContext ctx, Dictionary<FornecedorQueryModel, FornecedorDTO> query)
            : base(ctx, query) { }
        public UpdateRangeFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query, FornecedorDTO data)
            : base(ctx, new Dictionary<FornecedorQueryModel, FornecedorDTO> { { query, data } }) { }
    }
    
    public partial class UpdateFornecedorCommand : BaseRequestableCommand<FornecedorQueryModel, FornecedorDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query, FornecedorDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveFornecedorCommand : FornecedorSearchableCommand
    {
        public ActiveFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveFornecedorCommand : FornecedorSearchableCommand
    {
        public DeactiveFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query)
            : base(ctx, query) { }
    }
    public class FornecedorSearchableCommand : BaseSearchableCommand<FornecedorQueryModel> {
        public FornecedorSearchableCommand(ILogRequestContext ctx, FornecedorQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreatePublicitarioCommand : BaseRequestableCommand<PublicitarioQueryModel, PublicitarioDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreatePublicitarioCommand(ILogRequestContext ctx, PublicitarioDTO data, bool updateIfExists = true, PublicitarioQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeletePublicitarioCommand : BaseDeletionCommand<PublicitarioQueryModel>
    {
        public DeletePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangePublicitarioCommand : BaseDeletionCommand<PublicitarioQueryModel>
    {
        public DeleteRangePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangePublicitarioCommand : BaseRequestableRangeCommand<PublicitarioQueryModel, PublicitarioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangePublicitarioCommand(ILogRequestContext ctx, Dictionary<PublicitarioQueryModel, PublicitarioDTO> query)
            : base(ctx, query) { }
        public UpdateRangePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query, PublicitarioDTO data)
            : base(ctx, new Dictionary<PublicitarioQueryModel, PublicitarioDTO> { { query, data } }) { }
    }
    
    public partial class UpdatePublicitarioCommand : BaseRequestableCommand<PublicitarioQueryModel, PublicitarioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdatePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query, PublicitarioDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActivePublicitarioCommand : PublicitarioSearchableCommand
    {
        public ActivePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactivePublicitarioCommand : PublicitarioSearchableCommand
    {
        public DeactivePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query)
            : base(ctx, query) { }
    }
    public class PublicitarioSearchableCommand : BaseSearchableCommand<PublicitarioQueryModel> {
        public PublicitarioSearchableCommand(ILogRequestContext ctx, PublicitarioQueryModel query)
            : base(ctx, query) { }
    }

}
