using SES.CrossCutting.Infra.Log.Contexts;
using SES.Core.Domain.Aggregates.CommonAgg.Commands;
namespace SES.Users.Domain.Aggregates.CompaniesAgg.CommandModels
{
    using Queries.Models; 
    using SES.Users.Application.DTO.Aggregates.CompaniesAgg.Requests; 
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
namespace SES.Users.Domain.Aggregates.UsersAgg.CommandModels
{
    using Queries.Models; 
    using SES.Users.Application.DTO.Aggregates.UsersAgg.Requests; 
    public partial class CreateUsersAggSettingsCommand : BaseRequestableCommand<UsersAggSettingsQueryModel, UsersAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateUsersAggSettingsCommand(ILogRequestContext ctx, UsersAggSettingsDTO data, bool updateIfExists = true, UsersAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteUsersAggSettingsCommand : BaseDeletionCommand<UsersAggSettingsQueryModel>
    {
        public DeleteUsersAggSettingsCommand(ILogRequestContext ctx, UsersAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeUsersAggSettingsCommand : BaseDeletionCommand<UsersAggSettingsQueryModel>
    {
        public DeleteRangeUsersAggSettingsCommand(ILogRequestContext ctx, UsersAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeUsersAggSettingsCommand : BaseRequestableRangeCommand<UsersAggSettingsQueryModel, UsersAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeUsersAggSettingsCommand(ILogRequestContext ctx, Dictionary<UsersAggSettingsQueryModel, UsersAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeUsersAggSettingsCommand(ILogRequestContext ctx, UsersAggSettingsQueryModel query, UsersAggSettingsDTO data)
            : base(ctx, new Dictionary<UsersAggSettingsQueryModel, UsersAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateUsersAggSettingsCommand : BaseRequestableCommand<UsersAggSettingsQueryModel, UsersAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateUsersAggSettingsCommand(ILogRequestContext ctx, UsersAggSettingsQueryModel query, UsersAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveUsersAggSettingsCommand : UsersAggSettingsSearchableCommand
    {
        public ActiveUsersAggSettingsCommand(ILogRequestContext ctx, UsersAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveUsersAggSettingsCommand : UsersAggSettingsSearchableCommand
    {
        public DeactiveUsersAggSettingsCommand(ILogRequestContext ctx, UsersAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class UsersAggSettingsSearchableCommand : BaseSearchableCommand<UsersAggSettingsQueryModel> {
        public UsersAggSettingsSearchableCommand(ILogRequestContext ctx, UsersAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

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
