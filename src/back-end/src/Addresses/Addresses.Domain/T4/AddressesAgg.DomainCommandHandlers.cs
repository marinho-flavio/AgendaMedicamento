
using MediatR;
using FluentValidation.Results;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using Bravo.Core.Application.DTO.Extensions;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands.Handles;
namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Specifications;
    using Queries.Models;
    
    public class BaseAddressesAggCommandHandler :BaseCommandHandler{public BaseAddressesAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class EnderecoCommandHandler : BaseAddressesAggCommandHandler,
        IRequestHandler<CreateEnderecoCommand,ValidationResult>,
        IRequestHandler<DeleteRangeEnderecoCommand,ValidationResult>,
        IRequestHandler<DeleteEnderecoCommand,ValidationResult>,
        IRequestHandler<UpdateRangeEnderecoCommand,ValidationResult>,
        IRequestHandler<UpdateEnderecoCommand,ValidationResult>,
        IRequestHandler<ActiveEnderecoCommand,ValidationResult>,
        IRequestHandler<DeactiveEnderecoCommand,ValidationResult>
    {
        IEnderecoRepository _enderecoRepository;

        public EnderecoCommandHandler(IServiceProvider provider,IMediator mediator,IEnderecoRepository enderecoRepository ) : base(provider,mediator) { _enderecoRepository = enderecoRepository; }

        partial void OnCreate(Endereco entity);
        partial void OnUpdate(Endereco entity);

        public async Task<ValidationResult> Handle(CreateEnderecoCommand command,CancellationToken cancellationToken) {

            Endereco entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = EnderecoFilters.GetFilters(command.Query ?? new EnderecoQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _enderecoRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateEnderecoCommand(
                            command.Context,
                            new Queries.Models.EnderecoQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Endereco>();
            entity.AddDomainEvent(new EnderecoCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_enderecoRepository.Add(entity);

            return await Commit(_enderecoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteEnderecoCommand command,CancellationToken cancellationToken) {
            var filter = EnderecoFilters.GetFilters(command.Query);
			var entity = await _enderecoRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Endereco)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _enderecoRepository.Delete(entity);

            entity.AddDomainEvent(new EnderecoDeletedEvent(command.Context,entity));
            
            return await Commit(_enderecoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeEnderecoCommand command,CancellationToken cancellationToken) {
            var filter = EnderecoFilters.GetFilters(command.Query);
			var entities = await _enderecoRepository.FindAllAsync(filter);

			_enderecoRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_enderecoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateEnderecoCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeEnderecoCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeEnderecoCommand command,CancellationToken cancellationToken) {
            var entities = new List<Endereco>();
            foreach (var item in command.Query)
            {
                var filter = EnderecoFilters.GetFilters(item.Key);
                var entity = await _enderecoRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateEnderecoCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Endereco)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<Endereco>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new EnderecoUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_enderecoRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveEnderecoCommand command,CancellationToken cancellationToken) {
            var endereco = await _enderecoRepository.FindAsync(filter: EnderecoFilters.GetFilters(command.Query));
            //endereco.Disable();

            PublishLog(command);
            
            return await Commit(_enderecoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveEnderecoCommand command,CancellationToken cancellationToken) {
            var endereco = await _enderecoRepository.FindAsync(filter: EnderecoFilters.GetFilters(command.Query));
            //endereco.Enable();

            PublishLog(command);
            
            return await Commit(_enderecoRepository.UnitOfWork);
        }
    }
    public partial class AddressesAggSettingsCommandHandler : BaseAddressesAggCommandHandler,
        IRequestHandler<CreateAddressesAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteRangeAddressesAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeleteAddressesAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateRangeAddressesAggSettingsCommand,ValidationResult>,
        IRequestHandler<UpdateAddressesAggSettingsCommand,ValidationResult>,
        IRequestHandler<ActiveAddressesAggSettingsCommand,ValidationResult>,
        IRequestHandler<DeactiveAddressesAggSettingsCommand,ValidationResult>
    {
        IAddressesAggSettingsRepository _addressesAggSettingsRepository;

        public AddressesAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,IAddressesAggSettingsRepository addressesAggSettingsRepository ) : base(provider,mediator) { _addressesAggSettingsRepository = addressesAggSettingsRepository; }

        partial void OnCreate(AddressesAggSettings entity);
        partial void OnUpdate(AddressesAggSettings entity);

        public async Task<ValidationResult> Handle(CreateAddressesAggSettingsCommand command,CancellationToken cancellationToken) {

            AddressesAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = AddressesAggSettingsFilters.GetFilters(command.Query ?? new AddressesAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _addressesAggSettingsRepository.FindAsync(filter);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateAddressesAggSettingsCommand(
                            command.Context,
                            new Queries.Models.AddressesAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.AddressesAggSettings>();
            entity.AddDomainEvent(new AddressesAggSettingsCreatedEvent(command.Context,entity));

            OnCreate(entity);
			_addressesAggSettingsRepository.Add(entity);

            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = AddressesAggSettingsFilters.GetFilters(command.Query);
			var entity = await _addressesAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(AddressesAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _addressesAggSettingsRepository.Delete(entity);

            entity.AddDomainEvent(new AddressesAggSettingsDeletedEvent(command.Context,entity));
            
            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeleteRangeAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = AddressesAggSettingsFilters.GetFilters(command.Query);
			var entities = await _addressesAggSettingsRepository.FindAllAsync(filter);

			_addressesAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeAddressesAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<ValidationResult> Handle(UpdateRangeAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<AddressesAggSettings>();
            foreach (var item in command.Query)
            {
                var filter = AddressesAggSettingsFilters.GetFilters(item.Key);
                var entity = await _addressesAggSettingsRepository.FindAsync(filter);
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateAddressesAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(AddressesAggSettings)} not found with the request.");
                }

                entity.Update(item.Value.ProjectedAs<AddressesAggSettings>(),"Id");
                OnUpdate(entity);
                entity.AddDomainEvent(new AddressesAggSettingsUpdatedEvent(command.Context,entity));
            }
            
            PublishLog(command);

            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }
         
        public async Task<ValidationResult> Handle(ActiveAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var addressesaggsettings = await _addressesAggSettingsRepository.FindAsync(filter: AddressesAggSettingsFilters.GetFilters(command.Query));
            //addressesaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(DeactiveAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var addressesaggsettings = await _addressesAggSettingsRepository.FindAsync(filter: AddressesAggSettingsFilters.GetFilters(command.Query));
            //addressesaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }
    }
}
