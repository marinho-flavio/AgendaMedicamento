using MediatR;
using SES.Core.Domain.Extensions;
using SES.CrossCutting.Infra.Log.Providers;
using SES.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using SES.Schedulings.Domain.Aggregates.CompaniesAgg.ModelEvents;
using SES.Schedulings.Domain.Aggregates.SchedulingsAgg.ModelEvents;
using SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.ModelEvents;
using SES.Schedulings.Domain.Aggregates.UsersAgg.ModelEvents;
using SES.Schedulings.Domain.Aggregates.PartnersAgg.ModelEvents;

namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.EventHandlers
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
    public class SchedulingsAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<SchedulingsAggSettingsCreatedEvent>,
        INotificationHandler<SchedulingsAggSettingsDeletedEvent>,
        INotificationHandler<SchedulingsAggSettingsUpdatedEvent>,
        INotificationHandler<SchedulingsAggSettingsActivatedEvent>,
        INotificationHandler<SchedulingsAggSettingsDeactivatedEvent>{
        public SchedulingsAggSettingsEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(SchedulingsAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(SchedulingsAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(SchedulingsAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(SchedulingsAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(SchedulingsAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public class FeriadoEventHandler : BaseEventHandler,
        INotificationHandler<FeriadoCreatedEvent>,
        INotificationHandler<FeriadoDeletedEvent>,
        INotificationHandler<FeriadoUpdatedEvent>,
        INotificationHandler<FeriadoActivatedEvent>,
        INotificationHandler<FeriadoDeactivatedEvent>{
        public FeriadoEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(FeriadoCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FeriadoDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FeriadoActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FeriadoUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(FeriadoDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
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
    public class UserEventHandler : BaseEventHandler,
        INotificationHandler<UserCreatedEvent>,
        INotificationHandler<UserDeletedEvent>,
        INotificationHandler<UserUpdatedEvent>,
        INotificationHandler<UserActivatedEvent>,
        INotificationHandler<UserDeactivatedEvent>{
        public UserEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(UserDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(UserActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(UserUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(UserDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
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
}
