using MediatR;
using SES.Core.Domain.Extensions;
using SES.CrossCutting.Infra.Log.Providers;
using SES.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using SES.Users.Domain.Aggregates.CompaniesAgg.ModelEvents;
using SES.Users.Domain.Aggregates.UsersAgg.ModelEvents;

namespace SES.Users.Domain.Aggregates.UsersAgg.EventHandlers
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
    public class UsersAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<UsersAggSettingsCreatedEvent>,
        INotificationHandler<UsersAggSettingsDeletedEvent>,
        INotificationHandler<UsersAggSettingsUpdatedEvent>,
        INotificationHandler<UsersAggSettingsActivatedEvent>,
        INotificationHandler<UsersAggSettingsDeactivatedEvent>{
        public UsersAggSettingsEventHandler(ILogProvider logProvider):base(logProvider){}
        public async Task Handle(UsersAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(UsersAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(UsersAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(UsersAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(UsersAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
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
}
