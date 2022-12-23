using MediatR;
using Bravo.Core.Domain.Extensions;
using Bravo.CrossCutting.Infra.Log.Providers;
using Bravo.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.ModelEvents;

namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.EventHandlers
{
    public class ClinicalProceduresAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<ClinicalProceduresAggSettingsCreatedEvent>,
        INotificationHandler<ClinicalProceduresAggSettingsDeletedEvent>,
        INotificationHandler<ClinicalProceduresAggSettingsUpdatedEvent>,
        INotificationHandler<ClinicalProceduresAggSettingsActivatedEvent>,
        INotificationHandler<ClinicalProceduresAggSettingsDeactivatedEvent>{
        public ClinicalProceduresAggSettingsEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(ClinicalProceduresAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ClinicalProceduresAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ClinicalProceduresAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ClinicalProceduresAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ClinicalProceduresAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
