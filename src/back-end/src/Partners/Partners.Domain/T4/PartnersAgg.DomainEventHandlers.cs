using MediatR;
using Bravo.Core.Domain.Extensions;
using Bravo.CrossCutting.Infra.Log.Providers;
using Bravo.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Bravo.Partners.Domain.Aggregates.PartnersAgg.ModelEvents;

namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.EventHandlers
{
    public class FornecedorEventHandler : BaseEventHandler,
        INotificationHandler<FornecedorCreatedEvent>,
        INotificationHandler<FornecedorDeletedEvent>,
        INotificationHandler<FornecedorUpdatedEvent>,
        INotificationHandler<FornecedorActivatedEvent>,
        INotificationHandler<FornecedorDeactivatedEvent>{
        public FornecedorEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(FornecedorCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FornecedorDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FornecedorActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FornecedorUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FornecedorDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class PublicitarioEventHandler : BaseEventHandler,
        INotificationHandler<PublicitarioCreatedEvent>,
        INotificationHandler<PublicitarioDeletedEvent>,
        INotificationHandler<PublicitarioUpdatedEvent>,
        INotificationHandler<PublicitarioActivatedEvent>,
        INotificationHandler<PublicitarioDeactivatedEvent>{
        public PublicitarioEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(PublicitarioCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PublicitarioDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PublicitarioActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PublicitarioUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PublicitarioDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class PartnersAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<PartnersAggSettingsCreatedEvent>,
        INotificationHandler<PartnersAggSettingsDeletedEvent>,
        INotificationHandler<PartnersAggSettingsUpdatedEvent>,
        INotificationHandler<PartnersAggSettingsActivatedEvent>,
        INotificationHandler<PartnersAggSettingsDeactivatedEvent>{
        public PartnersAggSettingsEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(PartnersAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PartnersAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PartnersAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PartnersAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PartnersAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
