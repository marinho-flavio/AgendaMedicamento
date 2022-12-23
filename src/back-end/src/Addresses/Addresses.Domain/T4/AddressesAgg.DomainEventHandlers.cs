using MediatR;
using Bravo.Core.Domain.Extensions;
using Bravo.CrossCutting.Infra.Log.Providers;
using Bravo.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Bravo.Addresses.Domain.Aggregates.AddressesAgg.ModelEvents;

namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.EventHandlers
{
    public class EnderecoEventHandler : BaseEventHandler,
        INotificationHandler<EnderecoCreatedEvent>,
        INotificationHandler<EnderecoDeletedEvent>,
        INotificationHandler<EnderecoUpdatedEvent>,
        INotificationHandler<EnderecoActivatedEvent>,
        INotificationHandler<EnderecoDeactivatedEvent>{
        public EnderecoEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(EnderecoCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(EnderecoDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(EnderecoActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(EnderecoUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(EnderecoDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class AddressesAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<AddressesAggSettingsCreatedEvent>,
        INotificationHandler<AddressesAggSettingsDeletedEvent>,
        INotificationHandler<AddressesAggSettingsUpdatedEvent>,
        INotificationHandler<AddressesAggSettingsActivatedEvent>,
        INotificationHandler<AddressesAggSettingsDeactivatedEvent>{
        public AddressesAggSettingsEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(AddressesAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressesAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressesAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressesAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressesAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
