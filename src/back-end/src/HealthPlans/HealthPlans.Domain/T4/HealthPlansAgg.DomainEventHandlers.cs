using MediatR;
using Bravo.Core.Domain.Extensions;
using Bravo.CrossCutting.Infra.Log.Providers;
using Bravo.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.ModelEvents;

namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.EventHandlers
{
    public class ConvenioEventHandler : BaseEventHandler,
        INotificationHandler<ConvenioCreatedEvent>,
        INotificationHandler<ConvenioDeletedEvent>,
        INotificationHandler<ConvenioUpdatedEvent>,
        INotificationHandler<ConvenioActivatedEvent>,
        INotificationHandler<ConvenioDeactivatedEvent>{
        public ConvenioEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(ConvenioCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConvenioDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConvenioActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConvenioUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConvenioDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class HealthPlansAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<HealthPlansAggSettingsCreatedEvent>,
        INotificationHandler<HealthPlansAggSettingsDeletedEvent>,
        INotificationHandler<HealthPlansAggSettingsUpdatedEvent>,
        INotificationHandler<HealthPlansAggSettingsActivatedEvent>,
        INotificationHandler<HealthPlansAggSettingsDeactivatedEvent>{
        public HealthPlansAggSettingsEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(HealthPlansAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(HealthPlansAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(HealthPlansAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(HealthPlansAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(HealthPlansAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class PlanoConvenioEventHandler : BaseEventHandler,
        INotificationHandler<PlanoConvenioCreatedEvent>,
        INotificationHandler<PlanoConvenioDeletedEvent>,
        INotificationHandler<PlanoConvenioUpdatedEvent>,
        INotificationHandler<PlanoConvenioActivatedEvent>,
        INotificationHandler<PlanoConvenioDeactivatedEvent>{
        public PlanoConvenioEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(PlanoConvenioCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PlanoConvenioDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PlanoConvenioActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PlanoConvenioUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PlanoConvenioDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class TipoPlanoEventHandler : BaseEventHandler,
        INotificationHandler<TipoPlanoCreatedEvent>,
        INotificationHandler<TipoPlanoDeletedEvent>,
        INotificationHandler<TipoPlanoUpdatedEvent>,
        INotificationHandler<TipoPlanoActivatedEvent>,
        INotificationHandler<TipoPlanoDeactivatedEvent>{
        public TipoPlanoEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(TipoPlanoCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(TipoPlanoDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(TipoPlanoActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(TipoPlanoUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(TipoPlanoDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class ConvenioHorasEspeciaisEventHandler : BaseEventHandler,
        INotificationHandler<ConvenioHorasEspeciaisCreatedEvent>,
        INotificationHandler<ConvenioHorasEspeciaisDeletedEvent>,
        INotificationHandler<ConvenioHorasEspeciaisUpdatedEvent>,
        INotificationHandler<ConvenioHorasEspeciaisActivatedEvent>,
        INotificationHandler<ConvenioHorasEspeciaisDeactivatedEvent>{
        public ConvenioHorasEspeciaisEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(ConvenioHorasEspeciaisCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConvenioHorasEspeciaisDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConvenioHorasEspeciaisActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConvenioHorasEspeciaisUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConvenioHorasEspeciaisDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
