
using MediatR;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands.Handles;
namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseCompaniesAggCommandHandler :BaseCommandHandler{public BaseCompaniesAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class EmpresaCommandHandler : BaseCompaniesAggCommandHandler,
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
    public partial class CompaniesAggSettingsCommandHandler : BaseCompaniesAggCommandHandler,
        IRequestHandler<CreateCompaniesAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteRangeCompaniesAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteCompaniesAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateRangeCompaniesAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateCompaniesAggSettingsCommand,ValidationResult>,
        IRequestHandler<ActiveCompaniesAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeactiveCompaniesAggSettingsCommand,ValidationResult>
    {
        ICompaniesAggSettingsRepository _companiesAggSettingsRepository;

        public CompaniesAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,ICompaniesAggSettingsRepository companiesAggSettingsRepository ) : base(provider,mediator) { _companiesAggSettingsRepository = companiesAggSettingsRepository; }

        partial void OnCreate(CompaniesAggSettings entity);
        partial void OnUpdate(CompaniesAggSettings entity);

        public async Task<ValidationResult> Handle(CreateCompaniesAggSettingsCommand command,CancellationToken cancellationToken) {

            CompaniesAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = CompaniesAggSettingsFilters.GetFilters(command.Query ?? new CompaniesAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _companiesAggSettingsRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateCompaniesAggSettingsCommand(
                            command.Context,
                            new Queries.Models.CompaniesAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.CompaniesAggSettings>();
            entity.AddDomainEvent(new CompaniesAggSettingsCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_companiesAggSettingsRepository.Add(entity);

            return await Commit(_companiesAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteCompaniesAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = CompaniesAggSettingsFilters.GetFilters(command.Query);
			var entity = await _companiesAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(CompaniesAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _companiesAggSettingsRepository.Delete(entity);

            entity.AddDomainEvent(new CompaniesAggSettingsDeletedEvent(command.Context,entity));
            
            return await Commit(_companiesAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeCompaniesAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = CompaniesAggSettingsFilters.GetFilters(command.Query);
			var entities = await _companiesAggSettingsRepository.FindAllAsync(filter);

			_companiesAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_companiesAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateCompaniesAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeCompaniesAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeCompaniesAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<CompaniesAggSettings>();
            foreach (var item in command.Query)
            {
                var filter = CompaniesAggSettingsFilters.GetFilters(item.Key);
                var entity = await _companiesAggSettingsRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateCompaniesAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(CompaniesAggSettings)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<CompaniesAggSettings>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new CompaniesAggSettingsUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_companiesAggSettingsRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveCompaniesAggSettingsCommand command,CancellationToken cancellationToken) {
            var companiesaggsettings = await _companiesAggSettingsRepository.FindAsync(filter: CompaniesAggSettingsFilters.GetFilters(command.Query));
            //companiesaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_companiesAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveCompaniesAggSettingsCommand command,CancellationToken cancellationToken) {
            var companiesaggsettings = await _companiesAggSettingsRepository.FindAsync(filter: CompaniesAggSettingsFilters.GetFilters(command.Query));
            //companiesaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_companiesAggSettingsRepository.UnitOfWork);
        }
    }
    public partial class GrupoEmpresaCommandHandler : BaseCompaniesAggCommandHandler,
        IRequestHandler<CreateGrupoEmpresaCommand,ValidationResult>,
        IRequestHandler<DeleteRangeGrupoEmpresaCommand,ValidationResult>,
        IRequestHandler<DeleteGrupoEmpresaCommand,ValidationResult>,
        IRequestHandler<UpdateRangeGrupoEmpresaCommand,ValidationResult>,
        IRequestHandler<UpdateGrupoEmpresaCommand,ValidationResult>,
        IRequestHandler<ActiveGrupoEmpresaCommand,ValidationResult>,
        IRequestHandler<DeactiveGrupoEmpresaCommand,ValidationResult>
    {
        IGrupoEmpresaRepository _grupoEmpresaRepository;

        public GrupoEmpresaCommandHandler(IServiceProvider provider,IMediator mediator,IGrupoEmpresaRepository grupoEmpresaRepository ) : base(provider,mediator) { _grupoEmpresaRepository = grupoEmpresaRepository; }

        partial void OnCreate(GrupoEmpresa entity);
        partial void OnUpdate(GrupoEmpresa entity);

        public async Task<ValidationResult> Handle(CreateGrupoEmpresaCommand command,CancellationToken cancellationToken) {

            GrupoEmpresa entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = GrupoEmpresaFilters.GetFilters(command.Query ?? new GrupoEmpresaQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _grupoEmpresaRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateGrupoEmpresaCommand(
                            command.Context,
                            new Queries.Models.GrupoEmpresaQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.GrupoEmpresa>();
            entity.AddDomainEvent(new GrupoEmpresaCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_grupoEmpresaRepository.Add(entity);

            return await Commit(_grupoEmpresaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteGrupoEmpresaCommand command,CancellationToken cancellationToken) {
            var filter = GrupoEmpresaFilters.GetFilters(command.Query);
			var entity = await _grupoEmpresaRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(GrupoEmpresa)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _grupoEmpresaRepository.Delete(entity);

            entity.AddDomainEvent(new GrupoEmpresaDeletedEvent(command.Context,entity));
            
            return await Commit(_grupoEmpresaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeGrupoEmpresaCommand command,CancellationToken cancellationToken) {
            var filter = GrupoEmpresaFilters.GetFilters(command.Query);
			var entities = await _grupoEmpresaRepository.FindAllAsync(filter);

			_grupoEmpresaRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_grupoEmpresaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateGrupoEmpresaCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeGrupoEmpresaCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeGrupoEmpresaCommand command,CancellationToken cancellationToken) {
            var entities = new List<GrupoEmpresa>();
            foreach (var item in command.Query)
            {
                var filter = GrupoEmpresaFilters.GetFilters(item.Key);
                var entity = await _grupoEmpresaRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateGrupoEmpresaCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(GrupoEmpresa)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<GrupoEmpresa>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new GrupoEmpresaUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_grupoEmpresaRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveGrupoEmpresaCommand command,CancellationToken cancellationToken) {
            var grupoempresa = await _grupoEmpresaRepository.FindAsync(filter: GrupoEmpresaFilters.GetFilters(command.Query));
            //grupoempresa.Disable();

            PublishLog(command);
            
            return await Commit(_grupoEmpresaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveGrupoEmpresaCommand command,CancellationToken cancellationToken) {
            var grupoempresa = await _grupoEmpresaRepository.FindAsync(filter: GrupoEmpresaFilters.GetFilters(command.Query));
            //grupoempresa.Enable();

            PublishLog(command);
            
            return await Commit(_grupoEmpresaRepository.UnitOfWork);
        }
    }
}
