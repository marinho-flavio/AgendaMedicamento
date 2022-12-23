using MediatR;
using Bravo.Core.Domain.Extensions;
using Bravo.CrossCutting.Infra.Log.Providers;
using Bravo.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Bravo.Companies.Domain.Aggregates.CompaniesAgg.ModelEvents;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.EventHandlers
{
    public class EmpresaEventHandler : BaseEventHandler,
        INotificationHandler<EmpresaCreatedEvent>,
        INotificationHandler<EmpresaDeletedEvent>,
        INotificationHandler<EmpresaUpdatedEvent>,
        INotificationHandler<EmpresaActivatedEvent>,
        INotificationHandler<EmpresaDeactivatedEvent>{
        public EmpresaEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(EmpresaCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(EmpresaDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(EmpresaActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(EmpresaUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(EmpresaDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class CompaniesAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<CompaniesAggSettingsCreatedEvent>,
        INotificationHandler<CompaniesAggSettingsDeletedEvent>,
        INotificationHandler<CompaniesAggSettingsUpdatedEvent>,
        INotificationHandler<CompaniesAggSettingsActivatedEvent>,
        INotificationHandler<CompaniesAggSettingsDeactivatedEvent>{
        public CompaniesAggSettingsEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(CompaniesAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(CompaniesAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(CompaniesAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(CompaniesAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(CompaniesAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class GrupoEmpresaEventHandler : BaseEventHandler,
        INotificationHandler<GrupoEmpresaCreatedEvent>,
        INotificationHandler<GrupoEmpresaDeletedEvent>,
        INotificationHandler<GrupoEmpresaUpdatedEvent>,
        INotificationHandler<GrupoEmpresaActivatedEvent>,
        INotificationHandler<GrupoEmpresaDeactivatedEvent>{
        public GrupoEmpresaEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(GrupoEmpresaCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(GrupoEmpresaDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(GrupoEmpresaActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(GrupoEmpresaUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(GrupoEmpresaDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
