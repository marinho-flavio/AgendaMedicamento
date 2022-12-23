
using MediatR;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands.Handles;
namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseClinicalProceduresAggCommandHandler :BaseCommandHandler{public BaseClinicalProceduresAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class ClinicalProceduresAggSettingsCommandHandler : BaseClinicalProceduresAggCommandHandler,
        IRequestHandler<CreateClinicalProceduresAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteRangeClinicalProceduresAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteClinicalProceduresAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateRangeClinicalProceduresAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateClinicalProceduresAggSettingsCommand,ValidationResult>,
        IRequestHandler<ActiveClinicalProceduresAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeactiveClinicalProceduresAggSettingsCommand,ValidationResult>
    {
        IClinicalProceduresAggSettingsRepository _clinicalProceduresAggSettingsRepository;

        public ClinicalProceduresAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,IClinicalProceduresAggSettingsRepository clinicalProceduresAggSettingsRepository ) : base(provider,mediator) { _clinicalProceduresAggSettingsRepository = clinicalProceduresAggSettingsRepository; }

        partial void OnCreate(ClinicalProceduresAggSettings entity);
        partial void OnUpdate(ClinicalProceduresAggSettings entity);

        public async Task<ValidationResult> Handle(CreateClinicalProceduresAggSettingsCommand command,CancellationToken cancellationToken) {

            ClinicalProceduresAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = ClinicalProceduresAggSettingsFilters.GetFilters(command.Query ?? new ClinicalProceduresAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _clinicalProceduresAggSettingsRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateClinicalProceduresAggSettingsCommand(
                            command.Context,
                            new Queries.Models.ClinicalProceduresAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.ClinicalProceduresAggSettings>();
            entity.AddDomainEvent(new ClinicalProceduresAggSettingsCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_clinicalProceduresAggSettingsRepository.Add(entity);

            return await Commit(_clinicalProceduresAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteClinicalProceduresAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = ClinicalProceduresAggSettingsFilters.GetFilters(command.Query);
			var entity = await _clinicalProceduresAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(ClinicalProceduresAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _clinicalProceduresAggSettingsRepository.Delete(entity);

            entity.AddDomainEvent(new ClinicalProceduresAggSettingsDeletedEvent(command.Context,entity));
            
            return await Commit(_clinicalProceduresAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeClinicalProceduresAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = ClinicalProceduresAggSettingsFilters.GetFilters(command.Query);
			var entities = await _clinicalProceduresAggSettingsRepository.FindAllAsync(filter);

			_clinicalProceduresAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_clinicalProceduresAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateClinicalProceduresAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeClinicalProceduresAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeClinicalProceduresAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<ClinicalProceduresAggSettings>();
            foreach (var item in command.Query)
            {
                var filter = ClinicalProceduresAggSettingsFilters.GetFilters(item.Key);
                var entity = await _clinicalProceduresAggSettingsRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateClinicalProceduresAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(ClinicalProceduresAggSettings)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<ClinicalProceduresAggSettings>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new ClinicalProceduresAggSettingsUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_clinicalProceduresAggSettingsRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveClinicalProceduresAggSettingsCommand command,CancellationToken cancellationToken) {
            var clinicalproceduresaggsettings = await _clinicalProceduresAggSettingsRepository.FindAsync(filter: ClinicalProceduresAggSettingsFilters.GetFilters(command.Query));
            //clinicalproceduresaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_clinicalProceduresAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveClinicalProceduresAggSettingsCommand command,CancellationToken cancellationToken) {
            var clinicalproceduresaggsettings = await _clinicalProceduresAggSettingsRepository.FindAsync(filter: ClinicalProceduresAggSettingsFilters.GetFilters(command.Query));
            //clinicalproceduresaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_clinicalProceduresAggSettingsRepository.UnitOfWork);
        }
    }
}
