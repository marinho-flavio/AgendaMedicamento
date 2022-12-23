using Bravo.Core.Domain.Aggregates.CommonAgg.Events;
using Bravo.CrossCutting.Infra.Log.Contexts;

namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class EnderecoCreatedEvent : BaseEvent
    {
        public EnderecoCreatedEvent(ILogRequestContext ctx, Endereco data) 
            : base(ctx, data) { }
    }
    public partial class EnderecoDeletedEvent : BaseEvent
    {
        public EnderecoDeletedEvent(ILogRequestContext ctx, Endereco data) 
            : base(ctx, data) { }
    }
    public partial class EnderecoDeletedRangeEvent : BaseEvent
    {
        public EnderecoDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Endereco> data) 
            : base(ctx, data) { }
    }
    public partial class EnderecoActivatedEvent : BaseEvent
    {
        public EnderecoActivatedEvent(ILogRequestContext ctx, Endereco data) 
            : base(ctx, data) { }
    }
    public partial class EnderecoUpdatedEvent : BaseEvent
    {
        public EnderecoUpdatedEvent(ILogRequestContext ctx, Endereco data) 
            : base(ctx, data) { }
    }
    public partial class EnderecoUpdatedRangeEvent : BaseEvent
    {
        public EnderecoUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Endereco> data) 
            : base(ctx, data) { }
    }
    public partial class EnderecoDeactivatedEvent : BaseEvent
    {
        public EnderecoDeactivatedEvent(ILogRequestContext ctx, Endereco data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsCreatedEvent : BaseEvent
    {
        public AddressesAggSettingsCreatedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsDeletedEvent : BaseEvent
    {
        public AddressesAggSettingsDeletedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsDeletedRangeEvent : BaseEvent
    {
        public AddressesAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<AddressesAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsActivatedEvent : BaseEvent
    {
        public AddressesAggSettingsActivatedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsUpdatedEvent : BaseEvent
    {
        public AddressesAggSettingsUpdatedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public AddressesAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<AddressesAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsDeactivatedEvent : BaseEvent
    {
        public AddressesAggSettingsDeactivatedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
}
