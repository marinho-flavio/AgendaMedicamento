using MediatR;
using Bravo.Core.Domain.Extensions;
using Bravo.CrossCutting.Infra.Log.Providers;
using Bravo.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.ModelEvents;

namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.EventHandlers
{
    public class ProfissionalConfiguracaoEventHandler : BaseEventHandler,
        INotificationHandler<ProfissionalConfiguracaoCreatedEvent>,
        INotificationHandler<ProfissionalConfiguracaoDeletedEvent>,
        INotificationHandler<ProfissionalConfiguracaoUpdatedEvent>,
        INotificationHandler<ProfissionalConfiguracaoActivatedEvent>,
        INotificationHandler<ProfissionalConfiguracaoDeactivatedEvent>{
        public ProfissionalConfiguracaoEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(ProfissionalConfiguracaoCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfissionalConfiguracaoDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfissionalConfiguracaoActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfissionalConfiguracaoUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfissionalConfiguracaoDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class FuncionarioEventHandler : BaseEventHandler,
        INotificationHandler<FuncionarioCreatedEvent>,
        INotificationHandler<FuncionarioDeletedEvent>,
        INotificationHandler<FuncionarioUpdatedEvent>,
        INotificationHandler<FuncionarioActivatedEvent>,
        INotificationHandler<FuncionarioDeactivatedEvent>{
        public FuncionarioEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(FuncionarioCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FuncionarioDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FuncionarioActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FuncionarioUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FuncionarioDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class ProfissionalEventHandler : BaseEventHandler,
        INotificationHandler<ProfissionalCreatedEvent>,
        INotificationHandler<ProfissionalDeletedEvent>,
        INotificationHandler<ProfissionalUpdatedEvent>,
        INotificationHandler<ProfissionalActivatedEvent>,
        INotificationHandler<ProfissionalDeactivatedEvent>{
        public ProfissionalEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(ProfissionalCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfissionalDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfissionalActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfissionalUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfissionalDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class ProfessionalsAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<ProfessionalsAggSettingsCreatedEvent>,
        INotificationHandler<ProfessionalsAggSettingsDeletedEvent>,
        INotificationHandler<ProfessionalsAggSettingsUpdatedEvent>,
        INotificationHandler<ProfessionalsAggSettingsActivatedEvent>,
        INotificationHandler<ProfessionalsAggSettingsDeactivatedEvent>{
        public ProfessionalsAggSettingsEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(ProfessionalsAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfessionalsAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfessionalsAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfessionalsAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ProfessionalsAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class CboEventHandler : BaseEventHandler,
        INotificationHandler<CboCreatedEvent>,
        INotificationHandler<CboDeletedEvent>,
        INotificationHandler<CboUpdatedEvent>,
        INotificationHandler<CboActivatedEvent>,
        INotificationHandler<CboDeactivatedEvent>{
        public CboEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(CboCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(CboDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(CboActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(CboUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(CboDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
