
using MediatR;
using FluentValidation.Results;
using SES.CrossCuting.Infra.Utils.Extensions;
using SES.Core.Application.DTO.Extensions;
using SES.Core.Domain.Aggregates.CommonAgg.Commands.Handles;
namespace SES.Schedulings.Domain.Aggregates.CompaniesAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseSchedulingsAggCommandHandler :BaseCommandHandler{public BaseSchedulingsAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class EmpresaCommandHandler : BaseSchedulingsAggCommandHandler,
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
namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseSchedulingsAggCommandHandler :BaseCommandHandler{public BaseSchedulingsAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class SchedulingsAggSettingsCommandHandler : BaseSchedulingsAggCommandHandler,
        IRequestHandler<CreateSchedulingsAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteRangeSchedulingsAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteSchedulingsAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateRangeSchedulingsAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateSchedulingsAggSettingsCommand,ValidationResult>,
        IRequestHandler<ActiveSchedulingsAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeactiveSchedulingsAggSettingsCommand,ValidationResult>
    {
        ISchedulingsAggSettingsRepository _schedulingsAggSettingsRepository;

        public SchedulingsAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,ISchedulingsAggSettingsRepository schedulingsAggSettingsRepository ) : base(provider,mediator) { _schedulingsAggSettingsRepository = schedulingsAggSettingsRepository; }

        partial void OnCreate(SchedulingsAggSettings entity);
        partial void OnUpdate(SchedulingsAggSettings entity);

        public async Task<ValidationResult> Handle(CreateSchedulingsAggSettingsCommand command,CancellationToken cancellationToken) {

            SchedulingsAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = SchedulingsAggSettingsFilters.GetFilters(command.Query ?? new SchedulingsAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _schedulingsAggSettingsRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateSchedulingsAggSettingsCommand(
                            command.Context,
                            new Queries.Models.SchedulingsAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.SchedulingsAggSettings>();
            entity.AddDomainEvent(new SchedulingsAggSettingsCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_schedulingsAggSettingsRepository.Add(entity);

            return await Commit(_schedulingsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteSchedulingsAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = SchedulingsAggSettingsFilters.GetFilters(command.Query);
			var entity = await _schedulingsAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(SchedulingsAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _schedulingsAggSettingsRepository.Delete(entity);

            entity.AddDomainEvent(new SchedulingsAggSettingsDeletedEvent(command.Context,entity));
            
            return await Commit(_schedulingsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeSchedulingsAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = SchedulingsAggSettingsFilters.GetFilters(command.Query);
			var entities = await _schedulingsAggSettingsRepository.FindAllAsync(filter);

			_schedulingsAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_schedulingsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateSchedulingsAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeSchedulingsAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeSchedulingsAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<SchedulingsAggSettings>();
            foreach (var item in command.Query)
            {
                var filter = SchedulingsAggSettingsFilters.GetFilters(item.Key);
                var entity = await _schedulingsAggSettingsRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateSchedulingsAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(SchedulingsAggSettings)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<SchedulingsAggSettings>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new SchedulingsAggSettingsUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_schedulingsAggSettingsRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveSchedulingsAggSettingsCommand command,CancellationToken cancellationToken) {
            var schedulingsaggsettings = await _schedulingsAggSettingsRepository.FindAsync(filter: SchedulingsAggSettingsFilters.GetFilters(command.Query));
            //schedulingsaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_schedulingsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveSchedulingsAggSettingsCommand command,CancellationToken cancellationToken) {
            var schedulingsaggsettings = await _schedulingsAggSettingsRepository.FindAsync(filter: SchedulingsAggSettingsFilters.GetFilters(command.Query));
            //schedulingsaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_schedulingsAggSettingsRepository.UnitOfWork);
        }
    }
    public partial class FeriadoCommandHandler : BaseSchedulingsAggCommandHandler,
        IRequestHandler<CreateFeriadoCommand,ValidationResult>,
        IRequestHandler<DeleteRangeFeriadoCommand,ValidationResult>,
        IRequestHandler<DeleteFeriadoCommand,ValidationResult>,
        IRequestHandler<UpdateRangeFeriadoCommand,ValidationResult>,
        IRequestHandler<UpdateFeriadoCommand,ValidationResult>,
        IRequestHandler<ActiveFeriadoCommand,ValidationResult>,
        IRequestHandler<DeactiveFeriadoCommand,ValidationResult>
    {
        IFeriadoRepository _feriadoRepository;

        public FeriadoCommandHandler(IServiceProvider provider,IMediator mediator,IFeriadoRepository feriadoRepository ) : base(provider,mediator) { _feriadoRepository = feriadoRepository; }

        partial void OnCreate(Feriado entity);
        partial void OnUpdate(Feriado entity);

        public async Task<ValidationResult> Handle(CreateFeriadoCommand command,CancellationToken cancellationToken) {

            Feriado entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = FeriadoFilters.GetFilters(command.Query ?? new FeriadoQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _feriadoRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateFeriadoCommand(
                            command.Context,
                            new Queries.Models.FeriadoQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Feriado>();
            entity.AddDomainEvent(new FeriadoCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_feriadoRepository.Add(entity);

            return await Commit(_feriadoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteFeriadoCommand command,CancellationToken cancellationToken) {
            var filter = FeriadoFilters.GetFilters(command.Query);
			var entity = await _feriadoRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Feriado)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _feriadoRepository.Delete(entity);

            entity.AddDomainEvent(new FeriadoDeletedEvent(command.Context,entity));
            
            return await Commit(_feriadoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeFeriadoCommand command,CancellationToken cancellationToken) {
            var filter = FeriadoFilters.GetFilters(command.Query);
			var entities = await _feriadoRepository.FindAllAsync(filter);

			_feriadoRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_feriadoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateFeriadoCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeFeriadoCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeFeriadoCommand command,CancellationToken cancellationToken) {
            var entities = new List<Feriado>();
            foreach (var item in command.Query)
            {
                var filter = FeriadoFilters.GetFilters(item.Key);
                var entity = await _feriadoRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateFeriadoCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Feriado)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Feriado>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new FeriadoUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_feriadoRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveFeriadoCommand command,CancellationToken cancellationToken) {
            var feriado = await _feriadoRepository.FindAsync(filter: FeriadoFilters.GetFilters(command.Query));
            //feriado.Disable();

            PublishLog(command);
            
            return await Commit(_feriadoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveFeriadoCommand command,CancellationToken cancellationToken) {
            var feriado = await _feriadoRepository.FindAsync(filter: FeriadoFilters.GetFilters(command.Query));
            //feriado.Enable();

            PublishLog(command);
            
            return await Commit(_feriadoRepository.UnitOfWork);
        }
    }
}
namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseSchedulingsAggCommandHandler :BaseCommandHandler{public BaseSchedulingsAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class ProfissionalCommandHandler : BaseSchedulingsAggCommandHandler,
        IRequestHandler<CreateProfissionalCommand,ValidationResult>,
        IRequestHandler<DeleteRangeProfissionalCommand,ValidationResult>,
        IRequestHandler<DeleteProfissionalCommand,ValidationResult>,
        IRequestHandler<UpdateRangeProfissionalCommand,ValidationResult>,
        IRequestHandler<UpdateProfissionalCommand,ValidationResult>,
        IRequestHandler<ActiveProfissionalCommand,ValidationResult>,
        IRequestHandler<DeactiveProfissionalCommand,ValidationResult>
    {
        IProfissionalRepository _profissionalRepository;

        public ProfissionalCommandHandler(IServiceProvider provider,IMediator mediator,IProfissionalRepository profissionalRepository ) : base(provider,mediator) { _profissionalRepository = profissionalRepository; }

        partial void OnCreate(Profissional entity);
        partial void OnUpdate(Profissional entity);

        public async Task<ValidationResult> Handle(CreateProfissionalCommand command,CancellationToken cancellationToken) {

            Profissional entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = ProfissionalFilters.GetFilters(command.Query ?? new ProfissionalQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _profissionalRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateProfissionalCommand(
                            command.Context,
                            new Queries.Models.ProfissionalQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Profissional>();
            entity.AddDomainEvent(new ProfissionalCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_profissionalRepository.Add(entity);

            return await Commit(_profissionalRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteProfissionalCommand command,CancellationToken cancellationToken) {
            var filter = ProfissionalFilters.GetFilters(command.Query);
			var entity = await _profissionalRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Profissional)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _profissionalRepository.Delete(entity);

            entity.AddDomainEvent(new ProfissionalDeletedEvent(command.Context,entity));
            
            return await Commit(_profissionalRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeProfissionalCommand command,CancellationToken cancellationToken) {
            var filter = ProfissionalFilters.GetFilters(command.Query);
			var entities = await _profissionalRepository.FindAllAsync(filter);

			_profissionalRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_profissionalRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateProfissionalCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeProfissionalCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeProfissionalCommand command,CancellationToken cancellationToken) {
            var entities = new List<Profissional>();
            foreach (var item in command.Query)
            {
                var filter = ProfissionalFilters.GetFilters(item.Key);
                var entity = await _profissionalRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateProfissionalCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Profissional)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Profissional>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new ProfissionalUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_profissionalRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveProfissionalCommand command,CancellationToken cancellationToken) {
            var profissional = await _profissionalRepository.FindAsync(filter: ProfissionalFilters.GetFilters(command.Query));
            //profissional.Disable();

            PublishLog(command);
            
            return await Commit(_profissionalRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveProfissionalCommand command,CancellationToken cancellationToken) {
            var profissional = await _profissionalRepository.FindAsync(filter: ProfissionalFilters.GetFilters(command.Query));
            //profissional.Enable();

            PublishLog(command);
            
            return await Commit(_profissionalRepository.UnitOfWork);
        }
    }
}
namespace SES.Schedulings.Domain.Aggregates.UsersAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseSchedulingsAggCommandHandler :BaseCommandHandler{public BaseSchedulingsAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class UserCommandHandler : BaseSchedulingsAggCommandHandler,
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
namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseSchedulingsAggCommandHandler :BaseCommandHandler{public BaseSchedulingsAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class FornecedorCommandHandler : BaseSchedulingsAggCommandHandler,
        IRequestHandler<CreateFornecedorCommand,ValidationResult>,
        IRequestHandler<DeleteRangeFornecedorCommand,ValidationResult>,
        IRequestHandler<DeleteFornecedorCommand,ValidationResult>,
        IRequestHandler<UpdateRangeFornecedorCommand,ValidationResult>,
        IRequestHandler<UpdateFornecedorCommand,ValidationResult>,
        IRequestHandler<ActiveFornecedorCommand,ValidationResult>,
        IRequestHandler<DeactiveFornecedorCommand,ValidationResult>
    {
        IFornecedorRepository _fornecedorRepository;

        public FornecedorCommandHandler(IServiceProvider provider,IMediator mediator,IFornecedorRepository fornecedorRepository ) : base(provider,mediator) { _fornecedorRepository = fornecedorRepository; }

        partial void OnCreate(Fornecedor entity);
        partial void OnUpdate(Fornecedor entity);

        public async Task<ValidationResult> Handle(CreateFornecedorCommand command,CancellationToken cancellationToken) {

            Fornecedor entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = FornecedorFilters.GetFilters(command.Query ?? new FornecedorQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _fornecedorRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateFornecedorCommand(
                            command.Context,
                            new Queries.Models.FornecedorQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Fornecedor>();
            entity.AddDomainEvent(new FornecedorCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_fornecedorRepository.Add(entity);

            return await Commit(_fornecedorRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteFornecedorCommand command,CancellationToken cancellationToken) {
            var filter = FornecedorFilters.GetFilters(command.Query);
			var entity = await _fornecedorRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Fornecedor)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _fornecedorRepository.Delete(entity);

            entity.AddDomainEvent(new FornecedorDeletedEvent(command.Context,entity));
            
            return await Commit(_fornecedorRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeFornecedorCommand command,CancellationToken cancellationToken) {
            var filter = FornecedorFilters.GetFilters(command.Query);
			var entities = await _fornecedorRepository.FindAllAsync(filter);

			_fornecedorRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_fornecedorRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateFornecedorCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeFornecedorCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeFornecedorCommand command,CancellationToken cancellationToken) {
            var entities = new List<Fornecedor>();
            foreach (var item in command.Query)
            {
                var filter = FornecedorFilters.GetFilters(item.Key);
                var entity = await _fornecedorRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateFornecedorCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Fornecedor)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Fornecedor>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new FornecedorUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_fornecedorRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveFornecedorCommand command,CancellationToken cancellationToken) {
            var fornecedor = await _fornecedorRepository.FindAsync(filter: FornecedorFilters.GetFilters(command.Query));
            //fornecedor.Disable();

            PublishLog(command);
            
            return await Commit(_fornecedorRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveFornecedorCommand command,CancellationToken cancellationToken) {
            var fornecedor = await _fornecedorRepository.FindAsync(filter: FornecedorFilters.GetFilters(command.Query));
            //fornecedor.Enable();

            PublishLog(command);
            
            return await Commit(_fornecedorRepository.UnitOfWork);
        }
    }
    public partial class PublicitarioCommandHandler : BaseSchedulingsAggCommandHandler,
        IRequestHandler<CreatePublicitarioCommand,ValidationResult>,
        IRequestHandler<DeleteRangePublicitarioCommand,ValidationResult>,
        IRequestHandler<DeletePublicitarioCommand,ValidationResult>,
        IRequestHandler<UpdateRangePublicitarioCommand,ValidationResult>,
        IRequestHandler<UpdatePublicitarioCommand,ValidationResult>,
        IRequestHandler<ActivePublicitarioCommand,ValidationResult>,
        IRequestHandler<DeactivePublicitarioCommand,ValidationResult>
    {
        IPublicitarioRepository _publicitarioRepository;

        public PublicitarioCommandHandler(IServiceProvider provider,IMediator mediator,IPublicitarioRepository publicitarioRepository ) : base(provider,mediator) { _publicitarioRepository = publicitarioRepository; }

        partial void OnCreate(Publicitario entity);
        partial void OnUpdate(Publicitario entity);

        public async Task<ValidationResult> Handle(CreatePublicitarioCommand command,CancellationToken cancellationToken) {

            Publicitario entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = PublicitarioFilters.GetFilters(command.Query ?? new PublicitarioQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _publicitarioRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdatePublicitarioCommand(
                            command.Context,
                            new Queries.Models.PublicitarioQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Publicitario>();
            entity.AddDomainEvent(new PublicitarioCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_publicitarioRepository.Add(entity);

            return await Commit(_publicitarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeletePublicitarioCommand command,CancellationToken cancellationToken) {
            var filter = PublicitarioFilters.GetFilters(command.Query);
			var entity = await _publicitarioRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Publicitario)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _publicitarioRepository.Delete(entity);

            entity.AddDomainEvent(new PublicitarioDeletedEvent(command.Context,entity));
            
            return await Commit(_publicitarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangePublicitarioCommand command,CancellationToken cancellationToken) {
            var filter = PublicitarioFilters.GetFilters(command.Query);
			var entities = await _publicitarioRepository.FindAllAsync(filter);

			_publicitarioRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_publicitarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdatePublicitarioCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangePublicitarioCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangePublicitarioCommand command,CancellationToken cancellationToken) {
            var entities = new List<Publicitario>();
            foreach (var item in command.Query)
            {
                var filter = PublicitarioFilters.GetFilters(item.Key);
                var entity = await _publicitarioRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreatePublicitarioCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Publicitario)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Publicitario>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new PublicitarioUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_publicitarioRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActivePublicitarioCommand command,CancellationToken cancellationToken) {
            var publicitario = await _publicitarioRepository.FindAsync(filter: PublicitarioFilters.GetFilters(command.Query));
            //publicitario.Disable();

            PublishLog(command);
            
            return await Commit(_publicitarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactivePublicitarioCommand command,CancellationToken cancellationToken) {
            var publicitario = await _publicitarioRepository.FindAsync(filter: PublicitarioFilters.GetFilters(command.Query));
            //publicitario.Enable();

            PublishLog(command);
            
            return await Commit(_publicitarioRepository.UnitOfWork);
        }
    }
}
