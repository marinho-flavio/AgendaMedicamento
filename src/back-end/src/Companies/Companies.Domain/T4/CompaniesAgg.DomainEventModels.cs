using Bravo.Core.Domain.Aggregates.CommonAgg.Events;
using Bravo.CrossCutting.Infra.Log.Contexts;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.ModelEvents
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
    public partial class CompaniesAggSettingsCreatedEvent : BaseEvent
    {
        public CompaniesAggSettingsCreatedEvent(ILogRequestContext ctx, CompaniesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class CompaniesAggSettingsDeletedEvent : BaseEvent
    {
        public CompaniesAggSettingsDeletedEvent(ILogRequestContext ctx, CompaniesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class CompaniesAggSettingsDeletedRangeEvent : BaseEvent
    {
        public CompaniesAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<CompaniesAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class CompaniesAggSettingsActivatedEvent : BaseEvent
    {
        public CompaniesAggSettingsActivatedEvent(ILogRequestContext ctx, CompaniesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class CompaniesAggSettingsUpdatedEvent : BaseEvent
    {
        public CompaniesAggSettingsUpdatedEvent(ILogRequestContext ctx, CompaniesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class CompaniesAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public CompaniesAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<CompaniesAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class CompaniesAggSettingsDeactivatedEvent : BaseEvent
    {
        public CompaniesAggSettingsDeactivatedEvent(ILogRequestContext ctx, CompaniesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class GrupoEmpresaCreatedEvent : BaseEvent
    {
        public GrupoEmpresaCreatedEvent(ILogRequestContext ctx, GrupoEmpresa data) 
            : base(ctx, data) { }
    }
    public partial class GrupoEmpresaDeletedEvent : BaseEvent
    {
        public GrupoEmpresaDeletedEvent(ILogRequestContext ctx, GrupoEmpresa data) 
            : base(ctx, data) { }
    }
    public partial class GrupoEmpresaDeletedRangeEvent : BaseEvent
    {
        public GrupoEmpresaDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<GrupoEmpresa> data) 
            : base(ctx, data) { }
    }
    public partial class GrupoEmpresaActivatedEvent : BaseEvent
    {
        public GrupoEmpresaActivatedEvent(ILogRequestContext ctx, GrupoEmpresa data) 
            : base(ctx, data) { }
    }
    public partial class GrupoEmpresaUpdatedEvent : BaseEvent
    {
        public GrupoEmpresaUpdatedEvent(ILogRequestContext ctx, GrupoEmpresa data) 
            : base(ctx, data) { }
    }
    public partial class GrupoEmpresaUpdatedRangeEvent : BaseEvent
    {
        public GrupoEmpresaUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<GrupoEmpresa> data) 
            : base(ctx, data) { }
    }
    public partial class GrupoEmpresaDeactivatedEvent : BaseEvent
    {
        public GrupoEmpresaDeactivatedEvent(ILogRequestContext ctx, GrupoEmpresa data) 
            : base(ctx, data) { }
    }
}
