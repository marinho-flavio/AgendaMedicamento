
using MediatR;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands.Handles;
namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BasePatientsAggCommandHandler :BaseCommandHandler{public BasePatientsAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class PacienteCommandHandler : BasePatientsAggCommandHandler,
        IRequestHandler<CreatePacienteCommand,ValidationResult>,
        IRequestHandler<DeleteRangePacienteCommand,ValidationResult>,
        IRequestHandler<DeletePacienteCommand,ValidationResult>,
        IRequestHandler<UpdateRangePacienteCommand,ValidationResult>,
        IRequestHandler<UpdatePacienteCommand,ValidationResult>,
        IRequestHandler<ActivePacienteCommand,ValidationResult>,
        IRequestHandler<DeactivePacienteCommand,ValidationResult>
    {
        IPacienteRepository _pacienteRepository;

        public PacienteCommandHandler(IServiceProvider provider,IMediator mediator,IPacienteRepository pacienteRepository ) : base(provider,mediator) { _pacienteRepository = pacienteRepository; }

        partial void OnCreate(Paciente entity);
        partial void OnUpdate(Paciente entity);

        public async Task<ValidationResult> Handle(CreatePacienteCommand command,CancellationToken cancellationToken) {

            Paciente entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = PacienteFilters.GetFilters(command.Query ?? new PacienteQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _pacienteRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdatePacienteCommand(
                            command.Context,
                            new Queries.Models.PacienteQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Paciente>();
            entity.AddDomainEvent(new PacienteCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_pacienteRepository.Add(entity);

            return await Commit(_pacienteRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeletePacienteCommand command,CancellationToken cancellationToken) {
            var filter = PacienteFilters.GetFilters(command.Query);
			var entity = await _pacienteRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Paciente)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _pacienteRepository.Delete(entity);

            entity.AddDomainEvent(new PacienteDeletedEvent(command.Context,entity));
            
            return await Commit(_pacienteRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangePacienteCommand command,CancellationToken cancellationToken) {
            var filter = PacienteFilters.GetFilters(command.Query);
			var entities = await _pacienteRepository.FindAllAsync(filter);

			_pacienteRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_pacienteRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdatePacienteCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangePacienteCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangePacienteCommand command,CancellationToken cancellationToken) {
            var entities = new List<Paciente>();
            foreach (var item in command.Query)
            {
                var filter = PacienteFilters.GetFilters(item.Key);
                var entity = await _pacienteRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreatePacienteCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Paciente)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Paciente>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new PacienteUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_pacienteRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActivePacienteCommand command,CancellationToken cancellationToken) {
            var paciente = await _pacienteRepository.FindAsync(filter: PacienteFilters.GetFilters(command.Query));
            //paciente.Disable();

            PublishLog(command);
            
            return await Commit(_pacienteRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactivePacienteCommand command,CancellationToken cancellationToken) {
            var paciente = await _pacienteRepository.FindAsync(filter: PacienteFilters.GetFilters(command.Query));
            //paciente.Enable();

            PublishLog(command);
            
            return await Commit(_pacienteRepository.UnitOfWork);
        }
    }
    public partial class PatientsAggSettingsCommandHandler : BasePatientsAggCommandHandler,
        IRequestHandler<CreatePatientsAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteRangePatientsAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeletePatientsAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateRangePatientsAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdatePatientsAggSettingsCommand,ValidationResult>,
        IRequestHandler<ActivePatientsAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeactivePatientsAggSettingsCommand,ValidationResult>
    {
        IPatientsAggSettingsRepository _patientsAggSettingsRepository;

        public PatientsAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,IPatientsAggSettingsRepository patientsAggSettingsRepository ) : base(provider,mediator) { _patientsAggSettingsRepository = patientsAggSettingsRepository; }

        partial void OnCreate(PatientsAggSettings entity);
        partial void OnUpdate(PatientsAggSettings entity);

        public async Task<ValidationResult> Handle(CreatePatientsAggSettingsCommand command,CancellationToken cancellationToken) {

            PatientsAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = PatientsAggSettingsFilters.GetFilters(command.Query ?? new PatientsAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _patientsAggSettingsRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdatePatientsAggSettingsCommand(
                            command.Context,
                            new Queries.Models.PatientsAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.PatientsAggSettings>();
            entity.AddDomainEvent(new PatientsAggSettingsCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_patientsAggSettingsRepository.Add(entity);

            return await Commit(_patientsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeletePatientsAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = PatientsAggSettingsFilters.GetFilters(command.Query);
			var entity = await _patientsAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(PatientsAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _patientsAggSettingsRepository.Delete(entity);

            entity.AddDomainEvent(new PatientsAggSettingsDeletedEvent(command.Context,entity));
            
            return await Commit(_patientsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangePatientsAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = PatientsAggSettingsFilters.GetFilters(command.Query);
			var entities = await _patientsAggSettingsRepository.FindAllAsync(filter);

			_patientsAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_patientsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdatePatientsAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangePatientsAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangePatientsAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<PatientsAggSettings>();
            foreach (var item in command.Query)
            {
                var filter = PatientsAggSettingsFilters.GetFilters(item.Key);
                var entity = await _patientsAggSettingsRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreatePatientsAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(PatientsAggSettings)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<PatientsAggSettings>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new PatientsAggSettingsUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_patientsAggSettingsRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActivePatientsAggSettingsCommand command,CancellationToken cancellationToken) {
            var patientsaggsettings = await _patientsAggSettingsRepository.FindAsync(filter: PatientsAggSettingsFilters.GetFilters(command.Query));
            //patientsaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_patientsAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactivePatientsAggSettingsCommand command,CancellationToken cancellationToken) {
            var patientsaggsettings = await _patientsAggSettingsRepository.FindAsync(filter: PatientsAggSettingsFilters.GetFilters(command.Query));
            //patientsaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_patientsAggSettingsRepository.UnitOfWork);
        }
    }
}
