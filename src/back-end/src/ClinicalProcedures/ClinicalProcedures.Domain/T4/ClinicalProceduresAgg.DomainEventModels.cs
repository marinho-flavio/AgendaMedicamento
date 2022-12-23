using Bravo.Core.Domain.Aggregates.CommonAgg.Events;
using Bravo.CrossCutting.Infra.Log.Contexts;

namespace Bravo.ClinicalProcedures.Domain.Aggregates.ClinicalProceduresAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class ClinicalProceduresAggSettingsCreatedEvent : BaseEvent
    {
        public ClinicalProceduresAggSettingsCreatedEvent(ILogRequestContext ctx, ClinicalProceduresAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ClinicalProceduresAggSettingsDeletedEvent : BaseEvent
    {
        public ClinicalProceduresAggSettingsDeletedEvent(ILogRequestContext ctx, ClinicalProceduresAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ClinicalProceduresAggSettingsDeletedRangeEvent : BaseEvent
    {
        public ClinicalProceduresAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<ClinicalProceduresAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class ClinicalProceduresAggSettingsActivatedEvent : BaseEvent
    {
        public ClinicalProceduresAggSettingsActivatedEvent(ILogRequestContext ctx, ClinicalProceduresAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ClinicalProceduresAggSettingsUpdatedEvent : BaseEvent
    {
        public ClinicalProceduresAggSettingsUpdatedEvent(ILogRequestContext ctx, ClinicalProceduresAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ClinicalProceduresAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public ClinicalProceduresAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<ClinicalProceduresAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class ClinicalProceduresAggSettingsDeactivatedEvent : BaseEvent
    {
        public ClinicalProceduresAggSettingsDeactivatedEvent(ILogRequestContext ctx, ClinicalProceduresAggSettings data) 
            : base(ctx, data) { }
    }
}
