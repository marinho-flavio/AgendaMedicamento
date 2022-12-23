using Bravo.Core.Domain.Aggregates.CommonAgg.Events;
using Bravo.CrossCutting.Infra.Log.Contexts;

namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class FornecedorCreatedEvent : BaseEvent
    {
        public FornecedorCreatedEvent(ILogRequestContext ctx, Fornecedor data) 
            : base(ctx, data) { }
    }
    public partial class FornecedorDeletedEvent : BaseEvent
    {
        public FornecedorDeletedEvent(ILogRequestContext ctx, Fornecedor data) 
            : base(ctx, data) { }
    }
    public partial class FornecedorDeletedRangeEvent : BaseEvent
    {
        public FornecedorDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Fornecedor> data) 
            : base(ctx, data) { }
    }
    public partial class FornecedorActivatedEvent : BaseEvent
    {
        public FornecedorActivatedEvent(ILogRequestContext ctx, Fornecedor data) 
            : base(ctx, data) { }
    }
    public partial class FornecedorUpdatedEvent : BaseEvent
    {
        public FornecedorUpdatedEvent(ILogRequestContext ctx, Fornecedor data) 
            : base(ctx, data) { }
    }
    public partial class FornecedorUpdatedRangeEvent : BaseEvent
    {
        public FornecedorUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Fornecedor> data) 
            : base(ctx, data) { }
    }
    public partial class FornecedorDeactivatedEvent : BaseEvent
    {
        public FornecedorDeactivatedEvent(ILogRequestContext ctx, Fornecedor data) 
            : base(ctx, data) { }
    }
    public partial class PublicitarioCreatedEvent : BaseEvent
    {
        public PublicitarioCreatedEvent(ILogRequestContext ctx, Publicitario data) 
            : base(ctx, data) { }
    }
    public partial class PublicitarioDeletedEvent : BaseEvent
    {
        public PublicitarioDeletedEvent(ILogRequestContext ctx, Publicitario data) 
            : base(ctx, data) { }
    }
    public partial class PublicitarioDeletedRangeEvent : BaseEvent
    {
        public PublicitarioDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Publicitario> data) 
            : base(ctx, data) { }
    }
    public partial class PublicitarioActivatedEvent : BaseEvent
    {
        public PublicitarioActivatedEvent(ILogRequestContext ctx, Publicitario data) 
            : base(ctx, data) { }
    }
    public partial class PublicitarioUpdatedEvent : BaseEvent
    {
        public PublicitarioUpdatedEvent(ILogRequestContext ctx, Publicitario data) 
            : base(ctx, data) { }
    }
    public partial class PublicitarioUpdatedRangeEvent : BaseEvent
    {
        public PublicitarioUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Publicitario> data) 
            : base(ctx, data) { }
    }
    public partial class PublicitarioDeactivatedEvent : BaseEvent
    {
        public PublicitarioDeactivatedEvent(ILogRequestContext ctx, Publicitario data) 
            : base(ctx, data) { }
    }
    public partial class PartnersAggSettingsCreatedEvent : BaseEvent
    {
        public PartnersAggSettingsCreatedEvent(ILogRequestContext ctx, PartnersAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class PartnersAggSettingsDeletedEvent : BaseEvent
    {
        public PartnersAggSettingsDeletedEvent(ILogRequestContext ctx, PartnersAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class PartnersAggSettingsDeletedRangeEvent : BaseEvent
    {
        public PartnersAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<PartnersAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class PartnersAggSettingsActivatedEvent : BaseEvent
    {
        public PartnersAggSettingsActivatedEvent(ILogRequestContext ctx, PartnersAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class PartnersAggSettingsUpdatedEvent : BaseEvent
    {
        public PartnersAggSettingsUpdatedEvent(ILogRequestContext ctx, PartnersAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class PartnersAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public PartnersAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<PartnersAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class PartnersAggSettingsDeactivatedEvent : BaseEvent
    {
        public PartnersAggSettingsDeactivatedEvent(ILogRequestContext ctx, PartnersAggSettings data) 
            : base(ctx, data) { }
    }
}
