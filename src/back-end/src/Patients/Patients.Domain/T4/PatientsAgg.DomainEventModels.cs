using Bravo.Core.Domain.Aggregates.CommonAgg.Events;
using Bravo.CrossCutting.Infra.Log.Contexts;

namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class PacienteCreatedEvent : BaseEvent
    {
        public PacienteCreatedEvent(ILogRequestContext ctx, Paciente data) 
            : base(ctx, data) { }
    }
    public partial class PacienteDeletedEvent : BaseEvent
    {
        public PacienteDeletedEvent(ILogRequestContext ctx, Paciente data) 
            : base(ctx, data) { }
    }
    public partial class PacienteDeletedRangeEvent : BaseEvent
    {
        public PacienteDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Paciente> data) 
            : base(ctx, data) { }
    }
    public partial class PacienteActivatedEvent : BaseEvent
    {
        public PacienteActivatedEvent(ILogRequestContext ctx, Paciente data) 
            : base(ctx, data) { }
    }
    public partial class PacienteUpdatedEvent : BaseEvent
    {
        public PacienteUpdatedEvent(ILogRequestContext ctx, Paciente data) 
            : base(ctx, data) { }
    }
    public partial class PacienteUpdatedRangeEvent : BaseEvent
    {
        public PacienteUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Paciente> data) 
            : base(ctx, data) { }
    }
    public partial class PacienteDeactivatedEvent : BaseEvent
    {
        public PacienteDeactivatedEvent(ILogRequestContext ctx, Paciente data) 
            : base(ctx, data) { }
    }
    public partial class PatientsAggSettingsCreatedEvent : BaseEvent
    {
        public PatientsAggSettingsCreatedEvent(ILogRequestContext ctx, PatientsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class PatientsAggSettingsDeletedEvent : BaseEvent
    {
        public PatientsAggSettingsDeletedEvent(ILogRequestContext ctx, PatientsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class PatientsAggSettingsDeletedRangeEvent : BaseEvent
    {
        public PatientsAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<PatientsAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class PatientsAggSettingsActivatedEvent : BaseEvent
    {
        public PatientsAggSettingsActivatedEvent(ILogRequestContext ctx, PatientsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class PatientsAggSettingsUpdatedEvent : BaseEvent
    {
        public PatientsAggSettingsUpdatedEvent(ILogRequestContext ctx, PatientsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class PatientsAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public PatientsAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<PatientsAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class PatientsAggSettingsDeactivatedEvent : BaseEvent
    {
        public PatientsAggSettingsDeactivatedEvent(ILogRequestContext ctx, PatientsAggSettings data) 
            : base(ctx, data) { }
    }
}
