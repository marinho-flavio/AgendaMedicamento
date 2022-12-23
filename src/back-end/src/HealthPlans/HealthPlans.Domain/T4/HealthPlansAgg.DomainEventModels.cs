using Bravo.Core.Domain.Aggregates.CommonAgg.Events;
using Bravo.CrossCutting.Infra.Log.Contexts;

namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class ConvenioCreatedEvent : BaseEvent
    {
        public ConvenioCreatedEvent(ILogRequestContext ctx, Convenio data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioDeletedEvent : BaseEvent
    {
        public ConvenioDeletedEvent(ILogRequestContext ctx, Convenio data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioDeletedRangeEvent : BaseEvent
    {
        public ConvenioDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Convenio> data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioActivatedEvent : BaseEvent
    {
        public ConvenioActivatedEvent(ILogRequestContext ctx, Convenio data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioUpdatedEvent : BaseEvent
    {
        public ConvenioUpdatedEvent(ILogRequestContext ctx, Convenio data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioUpdatedRangeEvent : BaseEvent
    {
        public ConvenioUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Convenio> data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioDeactivatedEvent : BaseEvent
    {
        public ConvenioDeactivatedEvent(ILogRequestContext ctx, Convenio data) 
            : base(ctx, data) { }
    }
    public partial class HealthPlansAggSettingsCreatedEvent : BaseEvent
    {
        public HealthPlansAggSettingsCreatedEvent(ILogRequestContext ctx, HealthPlansAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class HealthPlansAggSettingsDeletedEvent : BaseEvent
    {
        public HealthPlansAggSettingsDeletedEvent(ILogRequestContext ctx, HealthPlansAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class HealthPlansAggSettingsDeletedRangeEvent : BaseEvent
    {
        public HealthPlansAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<HealthPlansAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class HealthPlansAggSettingsActivatedEvent : BaseEvent
    {
        public HealthPlansAggSettingsActivatedEvent(ILogRequestContext ctx, HealthPlansAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class HealthPlansAggSettingsUpdatedEvent : BaseEvent
    {
        public HealthPlansAggSettingsUpdatedEvent(ILogRequestContext ctx, HealthPlansAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class HealthPlansAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public HealthPlansAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<HealthPlansAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class HealthPlansAggSettingsDeactivatedEvent : BaseEvent
    {
        public HealthPlansAggSettingsDeactivatedEvent(ILogRequestContext ctx, HealthPlansAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class PlanoConvenioCreatedEvent : BaseEvent
    {
        public PlanoConvenioCreatedEvent(ILogRequestContext ctx, PlanoConvenio data) 
            : base(ctx, data) { }
    }
    public partial class PlanoConvenioDeletedEvent : BaseEvent
    {
        public PlanoConvenioDeletedEvent(ILogRequestContext ctx, PlanoConvenio data) 
            : base(ctx, data) { }
    }
    public partial class PlanoConvenioDeletedRangeEvent : BaseEvent
    {
        public PlanoConvenioDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<PlanoConvenio> data) 
            : base(ctx, data) { }
    }
    public partial class PlanoConvenioActivatedEvent : BaseEvent
    {
        public PlanoConvenioActivatedEvent(ILogRequestContext ctx, PlanoConvenio data) 
            : base(ctx, data) { }
    }
    public partial class PlanoConvenioUpdatedEvent : BaseEvent
    {
        public PlanoConvenioUpdatedEvent(ILogRequestContext ctx, PlanoConvenio data) 
            : base(ctx, data) { }
    }
    public partial class PlanoConvenioUpdatedRangeEvent : BaseEvent
    {
        public PlanoConvenioUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<PlanoConvenio> data) 
            : base(ctx, data) { }
    }
    public partial class PlanoConvenioDeactivatedEvent : BaseEvent
    {
        public PlanoConvenioDeactivatedEvent(ILogRequestContext ctx, PlanoConvenio data) 
            : base(ctx, data) { }
    }
    public partial class TipoPlanoCreatedEvent : BaseEvent
    {
        public TipoPlanoCreatedEvent(ILogRequestContext ctx, TipoPlano data) 
            : base(ctx, data) { }
    }
    public partial class TipoPlanoDeletedEvent : BaseEvent
    {
        public TipoPlanoDeletedEvent(ILogRequestContext ctx, TipoPlano data) 
            : base(ctx, data) { }
    }
    public partial class TipoPlanoDeletedRangeEvent : BaseEvent
    {
        public TipoPlanoDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<TipoPlano> data) 
            : base(ctx, data) { }
    }
    public partial class TipoPlanoActivatedEvent : BaseEvent
    {
        public TipoPlanoActivatedEvent(ILogRequestContext ctx, TipoPlano data) 
            : base(ctx, data) { }
    }
    public partial class TipoPlanoUpdatedEvent : BaseEvent
    {
        public TipoPlanoUpdatedEvent(ILogRequestContext ctx, TipoPlano data) 
            : base(ctx, data) { }
    }
    public partial class TipoPlanoUpdatedRangeEvent : BaseEvent
    {
        public TipoPlanoUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<TipoPlano> data) 
            : base(ctx, data) { }
    }
    public partial class TipoPlanoDeactivatedEvent : BaseEvent
    {
        public TipoPlanoDeactivatedEvent(ILogRequestContext ctx, TipoPlano data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioHorasEspeciaisCreatedEvent : BaseEvent
    {
        public ConvenioHorasEspeciaisCreatedEvent(ILogRequestContext ctx, ConvenioHorasEspeciais data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioHorasEspeciaisDeletedEvent : BaseEvent
    {
        public ConvenioHorasEspeciaisDeletedEvent(ILogRequestContext ctx, ConvenioHorasEspeciais data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioHorasEspeciaisDeletedRangeEvent : BaseEvent
    {
        public ConvenioHorasEspeciaisDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<ConvenioHorasEspeciais> data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioHorasEspeciaisActivatedEvent : BaseEvent
    {
        public ConvenioHorasEspeciaisActivatedEvent(ILogRequestContext ctx, ConvenioHorasEspeciais data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioHorasEspeciaisUpdatedEvent : BaseEvent
    {
        public ConvenioHorasEspeciaisUpdatedEvent(ILogRequestContext ctx, ConvenioHorasEspeciais data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioHorasEspeciaisUpdatedRangeEvent : BaseEvent
    {
        public ConvenioHorasEspeciaisUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<ConvenioHorasEspeciais> data) 
            : base(ctx, data) { }
    }
    public partial class ConvenioHorasEspeciaisDeactivatedEvent : BaseEvent
    {
        public ConvenioHorasEspeciaisDeactivatedEvent(ILogRequestContext ctx, ConvenioHorasEspeciais data) 
            : base(ctx, data) { }
    }
}
