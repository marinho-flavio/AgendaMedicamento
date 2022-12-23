using SES.Core.Domain.Aggregates.CommonAgg.Events;
using SES.CrossCutting.Infra.Log.Contexts;

namespace SES.Users.Domain.Aggregates.CompaniesAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class EmpresaCreatedEvent : BaseEvent
    {
        public EmpresaCreatedEvent(ILogRequestContext ctx, Empresa data) 
            : base(ctx, data) { }
    }
    public partial class EmpresaDeletedEvent : BaseEvent
    {
        public EmpresaDeletedEvent(ILogRequestContext ctx, Empresa data) 
            : base(ctx, data) { }
    }
    public partial class EmpresaDeletedRangeEvent : BaseEvent
    {
        public EmpresaDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Empresa> data) 
            : base(ctx, data) { }
    }
    public partial class EmpresaActivatedEvent : BaseEvent
    {
        public EmpresaActivatedEvent(ILogRequestContext ctx, Empresa data) 
            : base(ctx, data) { }
    }
    public partial class EmpresaUpdatedEvent : BaseEvent
    {
        public EmpresaUpdatedEvent(ILogRequestContext ctx, Empresa data) 
            : base(ctx, data) { }
    }
    public partial class EmpresaUpdatedRangeEvent : BaseEvent
    {
        public EmpresaUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Empresa> data) 
            : base(ctx, data) { }
    }
    public partial class EmpresaDeactivatedEvent : BaseEvent
    {
        public EmpresaDeactivatedEvent(ILogRequestContext ctx, Empresa data) 
            : base(ctx, data) { }
    }
}
namespace SES.Users.Domain.Aggregates.UsersAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class UsersAggSettingsCreatedEvent : BaseEvent
    {
        public UsersAggSettingsCreatedEvent(ILogRequestContext ctx, UsersAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class UsersAggSettingsDeletedEvent : BaseEvent
    {
        public UsersAggSettingsDeletedEvent(ILogRequestContext ctx, UsersAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class UsersAggSettingsDeletedRangeEvent : BaseEvent
    {
        public UsersAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<UsersAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class UsersAggSettingsActivatedEvent : BaseEvent
    {
        public UsersAggSettingsActivatedEvent(ILogRequestContext ctx, UsersAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class UsersAggSettingsUpdatedEvent : BaseEvent
    {
        public UsersAggSettingsUpdatedEvent(ILogRequestContext ctx, UsersAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class UsersAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public UsersAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<UsersAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class UsersAggSettingsDeactivatedEvent : BaseEvent
    {
        public UsersAggSettingsDeactivatedEvent(ILogRequestContext ctx, UsersAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class UserCreatedEvent : BaseEvent
    {
        public UserCreatedEvent(ILogRequestContext ctx, User data) 
            : base(ctx, data) { }
    }
    public partial class UserDeletedEvent : BaseEvent
    {
        public UserDeletedEvent(ILogRequestContext ctx, User data) 
            : base(ctx, data) { }
    }
    public partial class UserDeletedRangeEvent : BaseEvent
    {
        public UserDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<User> data) 
            : base(ctx, data) { }
    }
    public partial class UserActivatedEvent : BaseEvent
    {
        public UserActivatedEvent(ILogRequestContext ctx, User data) 
            : base(ctx, data) { }
    }
    public partial class UserUpdatedEvent : BaseEvent
    {
        public UserUpdatedEvent(ILogRequestContext ctx, User data) 
            : base(ctx, data) { }
    }
    public partial class UserUpdatedRangeEvent : BaseEvent
    {
        public UserUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<User> data) 
            : base(ctx, data) { }
    }
    public partial class UserDeactivatedEvent : BaseEvent
    {
        public UserDeactivatedEvent(ILogRequestContext ctx, User data) 
            : base(ctx, data) { }
    }
}
