
using MediatR;
using FluentValidation.Results;
using SES.CrossCuting.Infra.Utils.Extensions;
using SES.Core.Application.DTO.Extensions;
using SES.Core.Domain.Aggregates.CommonAgg.Commands.Handles;
namespace SES.Users.Domain.Aggregates.CompaniesAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseUsersAggCommandHandler :BaseCommandHandler{public BaseUsersAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class EmpresaCommandHandler : BaseUsersAggCommandHandler,
        IRequestHandler<CreateEmpresaCommand,ValidationResult>,
        IRequestHandler<DeleteRangeEmpresaCommand,ValidationResult>,
        IRequestHandler<DeleteEmpresaCommand,ValidationResult>,
        IRequestHandler<UpdateRangeEmpresaCommand,ValidationResult>,
        IRequestHandler<UpdateEmpresaCommand,ValidationResult>,
        IRequestHandler<ActiveEmpresaCommand,ValidationResult>,
        IRequestHandler<DeactiveEmpresaCommand,ValidationResult>
    {
        IEmpresaRepository _empresaRepository;

        public EmpresaCommandHandler(IServiceProvider provider,IMediator mediator,IEmpresaRepository empresaRepository ) : base(provider,mediator) { _empresaRepository = empresaRepository; }

        partial void OnCreate(Empresa entity);
        partial void OnUpdate(Empresa entity);

        public async Task<ValidationResult> Handle(CreateEmpresaCommand command,CancellationToken cancellationToken) {

            Empresa entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = EmpresaFilters.GetFilters(command.Query ?? new EmpresaQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _empresaRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateEmpresaCommand(
                            command.Context,
                            new Queries.Models.EmpresaQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Empresa>();
            entity.AddDomainEvent(new EmpresaCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_empresaRepository.Add(entity);

            return await Commit(_empresaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteEmpresaCommand command,CancellationToken cancellationToken) {
            var filter = EmpresaFilters.GetFilters(command.Query);
			var entity = await _empresaRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Empresa)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _empresaRepository.Delete(entity);

            entity.AddDomainEvent(new EmpresaDeletedEvent(command.Context,entity));
            
            return await Commit(_empresaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeEmpresaCommand command,CancellationToken cancellationToken) {
            var filter = EmpresaFilters.GetFilters(command.Query);
			var entities = await _empresaRepository.FindAllAsync(filter);

			_empresaRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_empresaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateEmpresaCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeEmpresaCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeEmpresaCommand command,CancellationToken cancellationToken) {
            var entities = new List<Empresa>();
            foreach (var item in command.Query)
            {
                var filter = EmpresaFilters.GetFilters(item.Key);
                var entity = await _empresaRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateEmpresaCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Empresa)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Empresa>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new EmpresaUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_empresaRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveEmpresaCommand command,CancellationToken cancellationToken) {
            var empresa = await _empresaRepository.FindAsync(filter: EmpresaFilters.GetFilters(command.Query));
            //empresa.Disable();

            PublishLog(command);
            
            return await Commit(_empresaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveEmpresaCommand command,CancellationToken cancellationToken) {
            var empresa = await _empresaRepository.FindAsync(filter: EmpresaFilters.GetFilters(command.Query));
            //empresa.Enable();

            PublishLog(command);
            
            return await Commit(_empresaRepository.UnitOfWork);
        }
    }
}
namespace SES.Users.Domain.Aggregates.UsersAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseUsersAggCommandHandler :BaseCommandHandler{public BaseUsersAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class UsersAggSettingsCommandHandler : BaseUsersAggCommandHandler,
        IRequestHandler<CreateUsersAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteRangeUsersAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteUsersAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateRangeUsersAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateUsersAggSettingsCommand,ValidationResult>,
        IRequestHandler<ActiveUsersAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeactiveUsersAggSettingsCommand,ValidationResult>
    {
        IUsersAggSettingsRepository _usersAggSettingsRepository;

        public UsersAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,IUsersAggSettingsRepository usersAggSettingsRepository ) : base(provider,mediator) { _usersAggSettingsRepository = usersAggSettingsRepository; }

        partial void OnCreate(UsersAggSettings entity);
        partial void OnUpdate(UsersAggSettings entity);

        public async Task<ValidationResult> Handle(CreateUsersAggSettingsCommand command,CancellationToken cancellationToken) {

            UsersAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = UsersAggSettingsFilters.GetFilters(command.Query ?? new UsersAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _usersAggSettingsRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateUsersAggSettingsCommand(
                            command.Context,
                            new Queries.Models.UsersAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.UsersAggSettings>();
            entity.AddDomainEvent(new UsersAggSettingsCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_usersAggSettingsRepository.Add(entity);

            return await Commit(_usersAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteUsersAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = UsersAggSettingsFilters.GetFilters(command.Query);
			var entity = await _usersAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(UsersAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _usersAggSettingsRepository.Delete(entity);

            entity.AddDomainEvent(new UsersAggSettingsDeletedEvent(command.Context,entity));
            
            return await Commit(_usersAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeUsersAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = UsersAggSettingsFilters.GetFilters(command.Query);
			var entities = await _usersAggSettingsRepository.FindAllAsync(filter);

			_usersAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_usersAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateUsersAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeUsersAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeUsersAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<UsersAggSettings>();
            foreach (var item in command.Query)
            {
                var filter = UsersAggSettingsFilters.GetFilters(item.Key);
                var entity = await _usersAggSettingsRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateUsersAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(UsersAggSettings)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<UsersAggSettings>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new UsersAggSettingsUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_usersAggSettingsRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveUsersAggSettingsCommand command,CancellationToken cancellationToken) {
            var usersaggsettings = await _usersAggSettingsRepository.FindAsync(filter: UsersAggSettingsFilters.GetFilters(command.Query));
            //usersaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_usersAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveUsersAggSettingsCommand command,CancellationToken cancellationToken) {
            var usersaggsettings = await _usersAggSettingsRepository.FindAsync(filter: UsersAggSettingsFilters.GetFilters(command.Query));
            //usersaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_usersAggSettingsRepository.UnitOfWork);
        }
    }
    public partial class UserCommandHandler : BaseUsersAggCommandHandler,
        IRequestHandler<CreateUserCommand,ValidationResult>,
        IRequestHandler<DeleteRangeUserCommand,ValidationResult>,
        IRequestHandler<DeleteUserCommand,ValidationResult>,
        IRequestHandler<UpdateRangeUserCommand,ValidationResult>,
        IRequestHandler<UpdateUserCommand,ValidationResult>,
        IRequestHandler<ActiveUserCommand,ValidationResult>,
        IRequestHandler<DeactiveUserCommand,ValidationResult>
    {
        IUserRepository _userRepository;

        public UserCommandHandler(IServiceProvider provider,IMediator mediator,IUserRepository userRepository ) : base(provider,mediator) { _userRepository = userRepository; }

        partial void OnCreate(User entity);
        partial void OnUpdate(User entity);

        public async Task<ValidationResult> Handle(CreateUserCommand command,CancellationToken cancellationToken) {

            User entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = UserFilters.GetFilters(command.Query ?? new UserQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _userRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateUserCommand(
                            command.Context,
                            new Queries.Models.UserQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.User>();
            entity.AddDomainEvent(new UserCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_userRepository.Add(entity);

            return await Commit(_userRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteUserCommand command,CancellationToken cancellationToken) {
            var filter = UserFilters.GetFilters(command.Query);
			var entity = await _userRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(User)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _userRepository.Delete(entity);

            entity.AddDomainEvent(new UserDeletedEvent(command.Context,entity));
            
            return await Commit(_userRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeUserCommand command,CancellationToken cancellationToken) {
            var filter = UserFilters.GetFilters(command.Query);
			var entities = await _userRepository.FindAllAsync(filter);

			_userRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_userRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateUserCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeUserCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeUserCommand command,CancellationToken cancellationToken) {
            var entities = new List<User>();
            foreach (var item in command.Query)
            {
                var filter = UserFilters.GetFilters(item.Key);
                var entity = await _userRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateUserCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(User)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<User>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new UserUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_userRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveUserCommand command,CancellationToken cancellationToken) {
            var user = await _userRepository.FindAsync(filter: UserFilters.GetFilters(command.Query));
            //user.Disable();

            PublishLog(command);
            
            return await Commit(_userRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveUserCommand command,CancellationToken cancellationToken) {
            var user = await _userRepository.FindAsync(filter: UserFilters.GetFilters(command.Query));
            //user.Enable();

            PublishLog(command);
            
            return await Commit(_userRepository.UnitOfWork);
        }
    }
}
