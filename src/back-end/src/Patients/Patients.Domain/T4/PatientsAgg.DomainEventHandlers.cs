using MediatR;
using Bravo.Core.Domain.Extensions;
using Bravo.CrossCutting.Infra.Log.Providers;
using Bravo.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Bravo.Patients.Domain.Aggregates.PatientsAgg.ModelEvents;

namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.EventHandlers
{
    public class PacienteEventHandler : BaseEventHandler,
        INotificationHandler<PacienteCreatedEvent>,
        INotificationHandler<PacienteDeletedEvent>,
        INotificationHandler<PacienteUpdatedEvent>,
        INotificationHandler<PacienteActivatedEvent>,
        INotificationHandler<PacienteDeactivatedEvent>{
        public PacienteEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(PacienteCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PacienteDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PacienteActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PacienteUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PacienteDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class PatientsAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<PatientsAggSettingsCreatedEvent>,
        INotificationHandler<PatientsAggSettingsDeletedEvent>,
        INotificationHandler<PatientsAggSettingsUpdatedEvent>,
        INotificationHandler<PatientsAggSettingsActivatedEvent>,
        INotificationHandler<PatientsAggSettingsDeactivatedEvent>{
        public PatientsAggSettingsEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(PatientsAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PatientsAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PatientsAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PatientsAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(PatientsAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
