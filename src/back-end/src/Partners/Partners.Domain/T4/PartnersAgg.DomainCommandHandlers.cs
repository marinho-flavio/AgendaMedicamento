
using MediatR;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands.Handles;
namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BasePartnersAggCommandHandler :BaseCommandHandler{public BasePartnersAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class FornecedorCommandHandler : BasePartnersAggCommandHandler,
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
    public partial class PublicitarioCommandHandler : BasePartnersAggCommandHandler,
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
    public partial class PartnersAggSettingsCommandHandler : BasePartnersAggCommandHandler,
        IRequestHandler<CreatePartnersAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteRangePartnersAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeletePartnersAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateRangePartnersAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdatePartnersAggSettingsCommand,ValidationResult>,
        IRequestHandler<ActivePartnersAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeactivePartnersAggSettingsCommand,ValidationResult>
    {
        IPartnersAggSettingsRepository _partnersAggSettingsRepository;

        public PartnersAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,IPartnersAggSettingsRepository partnersAggSettingsRepository ) : base(provider,mediator) { _partnersAggSettingsRepository = partnersAggSettingsRepository; }

        partial void OnCreate(PartnersAggSettings entity);
        partial void OnUpdate(PartnersAggSettings entity);

        public async Task<ValidationResult> Handle(CreatePartnersAggSettingsCommand command,CancellationToken cancellationToken) {

            PartnersAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = PartnersAggSettingsFilters.GetFilters(command.Query ?? new PartnersAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _partnersAggSettingsRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdatePartnersAggSettingsCommand(
                            command.Context,
                            new Queries.Models.PartnersAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.PartnersAggSettings>();
            entity.AddDomainEvent(new PartnersAggSettingsCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_partnersAggSettingsRepository.Add(entity);

            return await Commit(_partnersAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeletePartnersAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = PartnersAggSettingsFilters.GetFilters(command.Query);
			var entity = await _partnersAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(PartnersAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _partnersAggSettingsRepository.Delete(entity);

            entity.AddDomainEvent(new PartnersAggSettingsDeletedEvent(command.Context,entity));
            
            return await Commit(_partnersAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangePartnersAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = PartnersAggSettingsFilters.GetFilters(command.Query);
			var entities = await _partnersAggSettingsRepository.FindAllAsync(filter);

			_partnersAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_partnersAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdatePartnersAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangePartnersAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangePartnersAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<PartnersAggSettings>();
            foreach (var item in command.Query)
            {
                var filter = PartnersAggSettingsFilters.GetFilters(item.Key);
                var entity = await _partnersAggSettingsRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreatePartnersAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(PartnersAggSettings)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<PartnersAggSettings>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new PartnersAggSettingsUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_partnersAggSettingsRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActivePartnersAggSettingsCommand command,CancellationToken cancellationToken) {
            var partnersaggsettings = await _partnersAggSettingsRepository.FindAsync(filter: PartnersAggSettingsFilters.GetFilters(command.Query));
            //partnersaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_partnersAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactivePartnersAggSettingsCommand command,CancellationToken cancellationToken) {
            var partnersaggsettings = await _partnersAggSettingsRepository.FindAsync(filter: PartnersAggSettingsFilters.GetFilters(command.Query));
            //partnersaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_partnersAggSettingsRepository.UnitOfWork);
        }
    }
}
