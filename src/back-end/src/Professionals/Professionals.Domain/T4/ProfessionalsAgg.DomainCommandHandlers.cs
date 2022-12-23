
using MediatR;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands.Handles;
namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseProfessionalsAggCommandHandler :BaseCommandHandler{public BaseProfessionalsAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class ProfissionalConfiguracaoCommandHandler : BaseProfessionalsAggCommandHandler,
        IRequestHandler<CreateProfissionalConfiguracaoCommand,ValidationResult>,
        IRequestHandler<DeleteRangeProfissionalConfiguracaoCommand,ValidationResult>,
        IRequestHandler<DeleteProfissionalConfiguracaoCommand,ValidationResult>,
        IRequestHandler<UpdateRangeProfissionalConfiguracaoCommand,ValidationResult>,
        IRequestHandler<UpdateProfissionalConfiguracaoCommand,ValidationResult>,
        IRequestHandler<ActiveProfissionalConfiguracaoCommand,ValidationResult>,
        IRequestHandler<DeactiveProfissionalConfiguracaoCommand,ValidationResult>
    {
        IProfissionalConfiguracaoRepository _profissionalConfiguracaoRepository;

        public ProfissionalConfiguracaoCommandHandler(IServiceProvider provider,IMediator mediator,IProfissionalConfiguracaoRepository profissionalConfiguracaoRepository ) : base(provider,mediator) { _profissionalConfiguracaoRepository = profissionalConfiguracaoRepository; }

        partial void OnCreate(ProfissionalConfiguracao entity);
        partial void OnUpdate(ProfissionalConfiguracao entity);

        public async Task<ValidationResult> Handle(CreateProfissionalConfiguracaoCommand command,CancellationToken cancellationToken) {

            ProfissionalConfiguracao entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = ProfissionalConfiguracaoFilters.GetFilters(command.Query ?? new ProfissionalConfiguracaoQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _profissionalConfiguracaoRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateProfissionalConfiguracaoCommand(
                            command.Context,
                            new Queries.Models.ProfissionalConfiguracaoQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.ProfissionalConfiguracao>();
            entity.AddDomainEvent(new ProfissionalConfiguracaoCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_profissionalConfiguracaoRepository.Add(entity);

            return await Commit(_profissionalConfiguracaoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteProfissionalConfiguracaoCommand command,CancellationToken cancellationToken) {
            var filter = ProfissionalConfiguracaoFilters.GetFilters(command.Query);
			var entity = await _profissionalConfiguracaoRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(ProfissionalConfiguracao)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _profissionalConfiguracaoRepository.Delete(entity);

            entity.AddDomainEvent(new ProfissionalConfiguracaoDeletedEvent(command.Context,entity));
            
            return await Commit(_profissionalConfiguracaoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeProfissionalConfiguracaoCommand command,CancellationToken cancellationToken) {
            var filter = ProfissionalConfiguracaoFilters.GetFilters(command.Query);
			var entities = await _profissionalConfiguracaoRepository.FindAllAsync(filter);

			_profissionalConfiguracaoRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_profissionalConfiguracaoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateProfissionalConfiguracaoCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeProfissionalConfiguracaoCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeProfissionalConfiguracaoCommand command,CancellationToken cancellationToken) {
            var entities = new List<ProfissionalConfiguracao>();
            foreach (var item in command.Query)
            {
                var filter = ProfissionalConfiguracaoFilters.GetFilters(item.Key);
                var entity = await _profissionalConfiguracaoRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateProfissionalConfiguracaoCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(ProfissionalConfiguracao)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<ProfissionalConfiguracao>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new ProfissionalConfiguracaoUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_profissionalConfiguracaoRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveProfissionalConfiguracaoCommand command,CancellationToken cancellationToken) {
            var profissionalconfiguracao = await _profissionalConfiguracaoRepository.FindAsync(filter: ProfissionalConfiguracaoFilters.GetFilters(command.Query));
            //profissionalconfiguracao.Disable();

            PublishLog(command);
            
            return await Commit(_profissionalConfiguracaoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveProfissionalConfiguracaoCommand command,CancellationToken cancellationToken) {
            var profissionalconfiguracao = await _profissionalConfiguracaoRepository.FindAsync(filter: ProfissionalConfiguracaoFilters.GetFilters(command.Query));
            //profissionalconfiguracao.Enable();

            PublishLog(command);
            
            return await Commit(_profissionalConfiguracaoRepository.UnitOfWork);
        }
    }
    public partial class FuncionarioCommandHandler : BaseProfessionalsAggCommandHandler,
        IRequestHandler<CreateFuncionarioCommand,ValidationResult>,
        IRequestHandler<DeleteRangeFuncionarioCommand,ValidationResult>,
        IRequestHandler<DeleteFuncionarioCommand,ValidationResult>,
        IRequestHandler<UpdateRangeFuncionarioCommand,ValidationResult>,
        IRequestHandler<UpdateFuncionarioCommand,ValidationResult>,
        IRequestHandler<ActiveFuncionarioCommand,ValidationResult>,
        IRequestHandler<DeactiveFuncionarioCommand,ValidationResult>
    {
        IFuncionarioRepository _funcionarioRepository;

        public FuncionarioCommandHandler(IServiceProvider provider,IMediator mediator,IFuncionarioRepository funcionarioRepository ) : base(provider,mediator) { _funcionarioRepository = funcionarioRepository; }

        partial void OnCreate(Funcionario entity);
        partial void OnUpdate(Funcionario entity);

        public async Task<ValidationResult> Handle(CreateFuncionarioCommand command,CancellationToken cancellationToken) {

            Funcionario entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = FuncionarioFilters.GetFilters(command.Query ?? new FuncionarioQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _funcionarioRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateFuncionarioCommand(
                            command.Context,
                            new Queries.Models.FuncionarioQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Funcionario>();
            entity.AddDomainEvent(new FuncionarioCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_funcionarioRepository.Add(entity);

            return await Commit(_funcionarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteFuncionarioCommand command,CancellationToken cancellationToken) {
            var filter = FuncionarioFilters.GetFilters(command.Query);
			var entity = await _funcionarioRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Funcionario)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _funcionarioRepository.Delete(entity);

            entity.AddDomainEvent(new FuncionarioDeletedEvent(command.Context,entity));
            
            return await Commit(_funcionarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeFuncionarioCommand command,CancellationToken cancellationToken) {
            var filter = FuncionarioFilters.GetFilters(command.Query);
			var entities = await _funcionarioRepository.FindAllAsync(filter);

			_funcionarioRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_funcionarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateFuncionarioCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeFuncionarioCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeFuncionarioCommand command,CancellationToken cancellationToken) {
            var entities = new List<Funcionario>();
            foreach (var item in command.Query)
            {
                var filter = FuncionarioFilters.GetFilters(item.Key);
                var entity = await _funcionarioRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateFuncionarioCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Funcionario)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Funcionario>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new FuncionarioUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_funcionarioRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveFuncionarioCommand command,CancellationToken cancellationToken) {
            var funcionario = await _funcionarioRepository.FindAsync(filter: FuncionarioFilters.GetFilters(command.Query));
            //funcionario.Disable();

            PublishLog(command);
            
            return await Commit(_funcionarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveFuncionarioCommand command,CancellationToken cancellationToken) {
            var funcionario = await _funcionarioRepository.FindAsync(filter: FuncionarioFilters.GetFilters(command.Query));
            //funcionario.Enable();

            PublishLog(command);
            
            return await Commit(_funcionarioRepository.UnitOfWork);
        }
    }
    public partial class ProfissionalCommandHandler : BaseProfessionalsAggCommandHandler,
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
    public partial class ProfessionalsAggSettingsCommandHandler : BaseProfessionalsAggCommandHandler,
        IRequestHandler<CreateProfessionalsAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteRangeProfessionalsAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteProfessionalsAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateRangeProfessionalsAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateProfessionalsAggSettingsCommand,ValidationResult>,
        IRequestHandler<ActiveProfessionalsAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeactiveProfessionalsAggSettingsCommand,ValidationResult>
    {
        IProfessionalsAggSettingsRepository _professionalsAggSettingsRepository;

        public ProfessionalsAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,IProfessionalsAggSettingsRepository professionalsAggSettingsRepository ) : base(provider,mediator) { _professionalsAggSettingsRepository = professionalsAggSettingsRepository; }

        partial void OnCreate(ProfessionalsAggSettings entity);
        partial void OnUpdate(ProfessionalsAggSettings entity);

        public async Task<ValidationResult> Handle(CreateProfessionalsAggSettingsCommand command,CancellationToken cancellationToken) {

            ProfessionalsAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = ProfessionalsAggSettingsFilters.GetFilters(command.Query ?? new ProfessionalsAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _professionalsAggSettingsRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateProfessionalsAggSettingsCommand(
                            command.Context,
                            new Queries.Models.ProfessionalsAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.ProfessionalsAggSettings>();
            entity.AddDomainEvent(new ProfessionalsAggSettingsCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_professionalsAggSettingsRepository.Add(entity);

            return await Commit(_professionalsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteProfessionalsAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = ProfessionalsAggSettingsFilters.GetFilters(command.Query);
			var entity = await _professionalsAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(ProfessionalsAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _professionalsAggSettingsRepository.Delete(entity);

            entity.AddDomainEvent(new ProfessionalsAggSettingsDeletedEvent(command.Context,entity));
            
            return await Commit(_professionalsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeProfessionalsAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = ProfessionalsAggSettingsFilters.GetFilters(command.Query);
			var entities = await _professionalsAggSettingsRepository.FindAllAsync(filter);

			_professionalsAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_professionalsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateProfessionalsAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeProfessionalsAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeProfessionalsAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<ProfessionalsAggSettings>();
            foreach (var item in command.Query)
            {
                var filter = ProfessionalsAggSettingsFilters.GetFilters(item.Key);
                var entity = await _professionalsAggSettingsRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateProfessionalsAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(ProfessionalsAggSettings)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<ProfessionalsAggSettings>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new ProfessionalsAggSettingsUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_professionalsAggSettingsRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveProfessionalsAggSettingsCommand command,CancellationToken cancellationToken) {
            var professionalsaggsettings = await _professionalsAggSettingsRepository.FindAsync(filter: ProfessionalsAggSettingsFilters.GetFilters(command.Query));
            //professionalsaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_professionalsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveProfessionalsAggSettingsCommand command,CancellationToken cancellationToken) {
            var professionalsaggsettings = await _professionalsAggSettingsRepository.FindAsync(filter: ProfessionalsAggSettingsFilters.GetFilters(command.Query));
            //professionalsaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_professionalsAggSettingsRepository.UnitOfWork);
        }
    }
    public partial class CboCommandHandler : BaseProfessionalsAggCommandHandler,
        IRequestHandler<CreateCboCommand,ValidationResult>,
        IRequestHandler<DeleteRangeCboCommand,ValidationResult>,
        IRequestHandler<DeleteCboCommand,ValidationResult>,
        IRequestHandler<UpdateRangeCboCommand,ValidationResult>,
        IRequestHandler<UpdateCboCommand,ValidationResult>,
        IRequestHandler<ActiveCboCommand,ValidationResult>,
        IRequestHandler<DeactiveCboCommand,ValidationResult>
    {
        ICboRepository _cboRepository;

        public CboCommandHandler(IServiceProvider provider,IMediator mediator,ICboRepository cboRepository ) : base(provider,mediator) { _cboRepository = cboRepository; }

        partial void OnCreate(Cbo entity);
        partial void OnUpdate(Cbo entity);

        public async Task<ValidationResult> Handle(CreateCboCommand command,CancellationToken cancellationToken) {

            Cbo entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = CboFilters.GetFilters(command.Query ?? new CboQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _cboRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateCboCommand(
                            command.Context,
                            new Queries.Models.CboQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Cbo>();
            entity.AddDomainEvent(new CboCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_cboRepository.Add(entity);

            return await Commit(_cboRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteCboCommand command,CancellationToken cancellationToken) {
            var filter = CboFilters.GetFilters(command.Query);
			var entity = await _cboRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Cbo)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _cboRepository.Delete(entity);

            entity.AddDomainEvent(new CboDeletedEvent(command.Context,entity));
            
            return await Commit(_cboRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeCboCommand command,CancellationToken cancellationToken) {
            var filter = CboFilters.GetFilters(command.Query);
			var entities = await _cboRepository.FindAllAsync(filter);

			_cboRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_cboRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateCboCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeCboCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeCboCommand command,CancellationToken cancellationToken) {
            var entities = new List<Cbo>();
            foreach (var item in command.Query)
            {
                var filter = CboFilters.GetFilters(item.Key);
                var entity = await _cboRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateCboCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Cbo)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Cbo>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new CboUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_cboRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveCboCommand command,CancellationToken cancellationToken) {
            var cbo = await _cboRepository.FindAsync(filter: CboFilters.GetFilters(command.Query));
            //cbo.Disable();

            PublishLog(command);
            
            return await Commit(_cboRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveCboCommand command,CancellationToken cancellationToken) {
            var cbo = await _cboRepository.FindAsync(filter: CboFilters.GetFilters(command.Query));
            //cbo.Enable();

            PublishLog(command);
            
            return await Commit(_cboRepository.UnitOfWork);
        }
    }
}
