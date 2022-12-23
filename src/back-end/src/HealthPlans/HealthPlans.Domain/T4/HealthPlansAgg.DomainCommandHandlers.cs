
using MediatR;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands.Handles;
namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseHealthPlansAggCommandHandler :BaseCommandHandler{public BaseHealthPlansAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class ConvenioCommandHandler : BaseHealthPlansAggCommandHandler,
        IRequestHandler<CreateConvenioCommand,ValidationResult>,
        IRequestHandler<DeleteRangeConvenioCommand,ValidationResult>,
        IRequestHandler<DeleteConvenioCommand,ValidationResult>,
        IRequestHandler<UpdateRangeConvenioCommand,ValidationResult>,
        IRequestHandler<UpdateConvenioCommand,ValidationResult>,
        IRequestHandler<ActiveConvenioCommand,ValidationResult>,
        IRequestHandler<DeactiveConvenioCommand,ValidationResult>
    {
        IConvenioRepository _convenioRepository;

        public ConvenioCommandHandler(IServiceProvider provider,IMediator mediator,IConvenioRepository convenioRepository ) : base(provider,mediator) { _convenioRepository = convenioRepository; }

        partial void OnCreate(Convenio entity);
        partial void OnUpdate(Convenio entity);

        public async Task<ValidationResult> Handle(CreateConvenioCommand command,CancellationToken cancellationToken) {

            Convenio entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = ConvenioFilters.GetFilters(command.Query ?? new ConvenioQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _convenioRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateConvenioCommand(
                            command.Context,
                            new Queries.Models.ConvenioQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Convenio>();
            entity.AddDomainEvent(new ConvenioCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_convenioRepository.Add(entity);

            return await Commit(_convenioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteConvenioCommand command,CancellationToken cancellationToken) {
            var filter = ConvenioFilters.GetFilters(command.Query);
			var entity = await _convenioRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Convenio)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _convenioRepository.Delete(entity);

            entity.AddDomainEvent(new ConvenioDeletedEvent(command.Context,entity));
            
            return await Commit(_convenioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeConvenioCommand command,CancellationToken cancellationToken) {
            var filter = ConvenioFilters.GetFilters(command.Query);
			var entities = await _convenioRepository.FindAllAsync(filter);

			_convenioRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_convenioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateConvenioCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeConvenioCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeConvenioCommand command,CancellationToken cancellationToken) {
            var entities = new List<Convenio>();
            foreach (var item in command.Query)
            {
                var filter = ConvenioFilters.GetFilters(item.Key);
                var entity = await _convenioRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateConvenioCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Convenio)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Convenio>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new ConvenioUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_convenioRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveConvenioCommand command,CancellationToken cancellationToken) {
            var convenio = await _convenioRepository.FindAsync(filter: ConvenioFilters.GetFilters(command.Query));
            //convenio.Disable();

            PublishLog(command);
            
            return await Commit(_convenioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveConvenioCommand command,CancellationToken cancellationToken) {
            var convenio = await _convenioRepository.FindAsync(filter: ConvenioFilters.GetFilters(command.Query));
            //convenio.Enable();

            PublishLog(command);
            
            return await Commit(_convenioRepository.UnitOfWork);
        }
    }
    public partial class HealthPlansAggSettingsCommandHandler : BaseHealthPlansAggCommandHandler,
        IRequestHandler<CreateHealthPlansAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteRangeHealthPlansAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteHealthPlansAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateRangeHealthPlansAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateHealthPlansAggSettingsCommand,ValidationResult>,
        IRequestHandler<ActiveHealthPlansAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeactiveHealthPlansAggSettingsCommand,ValidationResult>
    {
        IHealthPlansAggSettingsRepository _healthPlansAggSettingsRepository;

        public HealthPlansAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,IHealthPlansAggSettingsRepository healthPlansAggSettingsRepository ) : base(provider,mediator) { _healthPlansAggSettingsRepository = healthPlansAggSettingsRepository; }

        partial void OnCreate(HealthPlansAggSettings entity);
        partial void OnUpdate(HealthPlansAggSettings entity);

        public async Task<ValidationResult> Handle(CreateHealthPlansAggSettingsCommand command,CancellationToken cancellationToken) {

            HealthPlansAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = HealthPlansAggSettingsFilters.GetFilters(command.Query ?? new HealthPlansAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _healthPlansAggSettingsRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateHealthPlansAggSettingsCommand(
                            command.Context,
                            new Queries.Models.HealthPlansAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.HealthPlansAggSettings>();
            entity.AddDomainEvent(new HealthPlansAggSettingsCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_healthPlansAggSettingsRepository.Add(entity);

            return await Commit(_healthPlansAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteHealthPlansAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = HealthPlansAggSettingsFilters.GetFilters(command.Query);
			var entity = await _healthPlansAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(HealthPlansAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _healthPlansAggSettingsRepository.Delete(entity);

            entity.AddDomainEvent(new HealthPlansAggSettingsDeletedEvent(command.Context,entity));
            
            return await Commit(_healthPlansAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeHealthPlansAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = HealthPlansAggSettingsFilters.GetFilters(command.Query);
			var entities = await _healthPlansAggSettingsRepository.FindAllAsync(filter);

			_healthPlansAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_healthPlansAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateHealthPlansAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeHealthPlansAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeHealthPlansAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<HealthPlansAggSettings>();
            foreach (var item in command.Query)
            {
                var filter = HealthPlansAggSettingsFilters.GetFilters(item.Key);
                var entity = await _healthPlansAggSettingsRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateHealthPlansAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(HealthPlansAggSettings)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<HealthPlansAggSettings>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new HealthPlansAggSettingsUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_healthPlansAggSettingsRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveHealthPlansAggSettingsCommand command,CancellationToken cancellationToken) {
            var healthplansaggsettings = await _healthPlansAggSettingsRepository.FindAsync(filter: HealthPlansAggSettingsFilters.GetFilters(command.Query));
            //healthplansaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_healthPlansAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveHealthPlansAggSettingsCommand command,CancellationToken cancellationToken) {
            var healthplansaggsettings = await _healthPlansAggSettingsRepository.FindAsync(filter: HealthPlansAggSettingsFilters.GetFilters(command.Query));
            //healthplansaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_healthPlansAggSettingsRepository.UnitOfWork);
        }
    }
    public partial class PlanoConvenioCommandHandler : BaseHealthPlansAggCommandHandler,
        IRequestHandler<CreatePlanoConvenioCommand,ValidationResult>,
        IRequestHandler<DeleteRangePlanoConvenioCommand,ValidationResult>,
        IRequestHandler<DeletePlanoConvenioCommand,ValidationResult>,
        IRequestHandler<UpdateRangePlanoConvenioCommand,ValidationResult>,
        IRequestHandler<UpdatePlanoConvenioCommand,ValidationResult>,
        IRequestHandler<ActivePlanoConvenioCommand,ValidationResult>,
        IRequestHandler<DeactivePlanoConvenioCommand,ValidationResult>
    {
        IPlanoConvenioRepository _planoConvenioRepository;

        public PlanoConvenioCommandHandler(IServiceProvider provider,IMediator mediator,IPlanoConvenioRepository planoConvenioRepository ) : base(provider,mediator) { _planoConvenioRepository = planoConvenioRepository; }

        partial void OnCreate(PlanoConvenio entity);
        partial void OnUpdate(PlanoConvenio entity);

        public async Task<ValidationResult> Handle(CreatePlanoConvenioCommand command,CancellationToken cancellationToken) {

            PlanoConvenio entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = PlanoConvenioFilters.GetFilters(command.Query ?? new PlanoConvenioQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _planoConvenioRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdatePlanoConvenioCommand(
                            command.Context,
                            new Queries.Models.PlanoConvenioQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.PlanoConvenio>();
            entity.AddDomainEvent(new PlanoConvenioCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_planoConvenioRepository.Add(entity);

            return await Commit(_planoConvenioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeletePlanoConvenioCommand command,CancellationToken cancellationToken) {
            var filter = PlanoConvenioFilters.GetFilters(command.Query);
			var entity = await _planoConvenioRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(PlanoConvenio)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _planoConvenioRepository.Delete(entity);

            entity.AddDomainEvent(new PlanoConvenioDeletedEvent(command.Context,entity));
            
            return await Commit(_planoConvenioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangePlanoConvenioCommand command,CancellationToken cancellationToken) {
            var filter = PlanoConvenioFilters.GetFilters(command.Query);
			var entities = await _planoConvenioRepository.FindAllAsync(filter);

			_planoConvenioRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_planoConvenioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdatePlanoConvenioCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangePlanoConvenioCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangePlanoConvenioCommand command,CancellationToken cancellationToken) {
            var entities = new List<PlanoConvenio>();
            foreach (var item in command.Query)
            {
                var filter = PlanoConvenioFilters.GetFilters(item.Key);
                var entity = await _planoConvenioRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreatePlanoConvenioCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(PlanoConvenio)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<PlanoConvenio>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new PlanoConvenioUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_planoConvenioRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActivePlanoConvenioCommand command,CancellationToken cancellationToken) {
            var planoconvenio = await _planoConvenioRepository.FindAsync(filter: PlanoConvenioFilters.GetFilters(command.Query));
            //planoconvenio.Disable();

            PublishLog(command);
            
            return await Commit(_planoConvenioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactivePlanoConvenioCommand command,CancellationToken cancellationToken) {
            var planoconvenio = await _planoConvenioRepository.FindAsync(filter: PlanoConvenioFilters.GetFilters(command.Query));
            //planoconvenio.Enable();

            PublishLog(command);
            
            return await Commit(_planoConvenioRepository.UnitOfWork);
        }
    }
    public partial class TipoPlanoCommandHandler : BaseHealthPlansAggCommandHandler,
        IRequestHandler<CreateTipoPlanoCommand,ValidationResult>,
        IRequestHandler<DeleteRangeTipoPlanoCommand,ValidationResult>,
        IRequestHandler<DeleteTipoPlanoCommand,ValidationResult>,
        IRequestHandler<UpdateRangeTipoPlanoCommand,ValidationResult>,
        IRequestHandler<UpdateTipoPlanoCommand,ValidationResult>,
        IRequestHandler<ActiveTipoPlanoCommand,ValidationResult>,
        IRequestHandler<DeactiveTipoPlanoCommand,ValidationResult>
    {
        ITipoPlanoRepository _tipoPlanoRepository;

        public TipoPlanoCommandHandler(IServiceProvider provider,IMediator mediator,ITipoPlanoRepository tipoPlanoRepository ) : base(provider,mediator) { _tipoPlanoRepository = tipoPlanoRepository; }

        partial void OnCreate(TipoPlano entity);
        partial void OnUpdate(TipoPlano entity);

        public async Task<ValidationResult> Handle(CreateTipoPlanoCommand command,CancellationToken cancellationToken) {

            TipoPlano entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = TipoPlanoFilters.GetFilters(command.Query ?? new TipoPlanoQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _tipoPlanoRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateTipoPlanoCommand(
                            command.Context,
                            new Queries.Models.TipoPlanoQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.TipoPlano>();
            entity.AddDomainEvent(new TipoPlanoCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_tipoPlanoRepository.Add(entity);

            return await Commit(_tipoPlanoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteTipoPlanoCommand command,CancellationToken cancellationToken) {
            var filter = TipoPlanoFilters.GetFilters(command.Query);
			var entity = await _tipoPlanoRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(TipoPlano)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _tipoPlanoRepository.Delete(entity);

            entity.AddDomainEvent(new TipoPlanoDeletedEvent(command.Context,entity));
            
            return await Commit(_tipoPlanoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeTipoPlanoCommand command,CancellationToken cancellationToken) {
            var filter = TipoPlanoFilters.GetFilters(command.Query);
			var entities = await _tipoPlanoRepository.FindAllAsync(filter);

			_tipoPlanoRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_tipoPlanoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateTipoPlanoCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeTipoPlanoCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeTipoPlanoCommand command,CancellationToken cancellationToken) {
            var entities = new List<TipoPlano>();
            foreach (var item in command.Query)
            {
                var filter = TipoPlanoFilters.GetFilters(item.Key);
                var entity = await _tipoPlanoRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateTipoPlanoCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(TipoPlano)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<TipoPlano>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new TipoPlanoUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_tipoPlanoRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveTipoPlanoCommand command,CancellationToken cancellationToken) {
            var tipoplano = await _tipoPlanoRepository.FindAsync(filter: TipoPlanoFilters.GetFilters(command.Query));
            //tipoplano.Disable();

            PublishLog(command);
            
            return await Commit(_tipoPlanoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveTipoPlanoCommand command,CancellationToken cancellationToken) {
            var tipoplano = await _tipoPlanoRepository.FindAsync(filter: TipoPlanoFilters.GetFilters(command.Query));
            //tipoplano.Enable();

            PublishLog(command);
            
            return await Commit(_tipoPlanoRepository.UnitOfWork);
        }
    }
    public partial class ConvenioHorasEspeciaisCommandHandler : BaseHealthPlansAggCommandHandler,
        IRequestHandler<CreateConvenioHorasEspeciaisCommand,ValidationResult>,
        IRequestHandler<DeleteRangeConvenioHorasEspeciaisCommand,ValidationResult>,
        IRequestHandler<DeleteConvenioHorasEspeciaisCommand,ValidationResult>,
        IRequestHandler<UpdateRangeConvenioHorasEspeciaisCommand,ValidationResult>,
        IRequestHandler<UpdateConvenioHorasEspeciaisCommand,ValidationResult>,
        IRequestHandler<ActiveConvenioHorasEspeciaisCommand,ValidationResult>,
        IRequestHandler<DeactiveConvenioHorasEspeciaisCommand,ValidationResult>
    {
        IConvenioHorasEspeciaisRepository _convenioHorasEspeciaisRepository;

        public ConvenioHorasEspeciaisCommandHandler(IServiceProvider provider,IMediator mediator,IConvenioHorasEspeciaisRepository convenioHorasEspeciaisRepository ) : base(provider,mediator) { _convenioHorasEspeciaisRepository = convenioHorasEspeciaisRepository; }

        partial void OnCreate(ConvenioHorasEspeciais entity);
        partial void OnUpdate(ConvenioHorasEspeciais entity);

        public async Task<ValidationResult> Handle(CreateConvenioHorasEspeciaisCommand command,CancellationToken cancellationToken) {

            ConvenioHorasEspeciais entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = ConvenioHorasEspeciaisFilters.GetFilters(command.Query ?? new ConvenioHorasEspeciaisQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _convenioHorasEspeciaisRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateConvenioHorasEspeciaisCommand(
                            command.Context,
                            new Queries.Models.ConvenioHorasEspeciaisQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.ConvenioHorasEspeciais>();
            entity.AddDomainEvent(new ConvenioHorasEspeciaisCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_convenioHorasEspeciaisRepository.Add(entity);

            return await Commit(_convenioHorasEspeciaisRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteConvenioHorasEspeciaisCommand command,CancellationToken cancellationToken) {
            var filter = ConvenioHorasEspeciaisFilters.GetFilters(command.Query);
			var entity = await _convenioHorasEspeciaisRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(ConvenioHorasEspeciais)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _convenioHorasEspeciaisRepository.Delete(entity);

            entity.AddDomainEvent(new ConvenioHorasEspeciaisDeletedEvent(command.Context,entity));
            
            return await Commit(_convenioHorasEspeciaisRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeConvenioHorasEspeciaisCommand command,CancellationToken cancellationToken) {
            var filter = ConvenioHorasEspeciaisFilters.GetFilters(command.Query);
			var entities = await _convenioHorasEspeciaisRepository.FindAllAsync(filter);

			_convenioHorasEspeciaisRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_convenioHorasEspeciaisRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateConvenioHorasEspeciaisCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeConvenioHorasEspeciaisCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeConvenioHorasEspeciaisCommand command,CancellationToken cancellationToken) {
            var entities = new List<ConvenioHorasEspeciais>();
            foreach (var item in command.Query)
            {
                var filter = ConvenioHorasEspeciaisFilters.GetFilters(item.Key);
                var entity = await _convenioHorasEspeciaisRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateConvenioHorasEspeciaisCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(ConvenioHorasEspeciais)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<ConvenioHorasEspeciais>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new ConvenioHorasEspeciaisUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_convenioHorasEspeciaisRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveConvenioHorasEspeciaisCommand command,CancellationToken cancellationToken) {
            var conveniohorasespeciais = await _convenioHorasEspeciaisRepository.FindAsync(filter: ConvenioHorasEspeciaisFilters.GetFilters(command.Query));
            //conveniohorasespeciais.Disable();

            PublishLog(command);
            
            return await Commit(_convenioHorasEspeciaisRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveConvenioHorasEspeciaisCommand command,CancellationToken cancellationToken) {
            var conveniohorasespeciais = await _convenioHorasEspeciaisRepository.FindAsync(filter: ConvenioHorasEspeciaisFilters.GetFilters(command.Query));
            //conveniohorasespeciais.Enable();

            PublishLog(command);
            
            return await Commit(_convenioHorasEspeciaisRepository.UnitOfWork);
        }
    }
}
