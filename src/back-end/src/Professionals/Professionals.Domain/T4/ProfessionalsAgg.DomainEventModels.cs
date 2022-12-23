using Bravo.Core.Domain.Aggregates.CommonAgg.Events;
using Bravo.CrossCutting.Infra.Log.Contexts;

namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class ProfissionalConfiguracaoCreatedEvent : BaseEvent
    {
        public ProfissionalConfiguracaoCreatedEvent(ILogRequestContext ctx, ProfissionalConfiguracao data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalConfiguracaoDeletedEvent : BaseEvent
    {
        public ProfissionalConfiguracaoDeletedEvent(ILogRequestContext ctx, ProfissionalConfiguracao data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalConfiguracaoDeletedRangeEvent : BaseEvent
    {
        public ProfissionalConfiguracaoDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<ProfissionalConfiguracao> data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalConfiguracaoActivatedEvent : BaseEvent
    {
        public ProfissionalConfiguracaoActivatedEvent(ILogRequestContext ctx, ProfissionalConfiguracao data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalConfiguracaoUpdatedEvent : BaseEvent
    {
        public ProfissionalConfiguracaoUpdatedEvent(ILogRequestContext ctx, ProfissionalConfiguracao data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalConfiguracaoUpdatedRangeEvent : BaseEvent
    {
        public ProfissionalConfiguracaoUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<ProfissionalConfiguracao> data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalConfiguracaoDeactivatedEvent : BaseEvent
    {
        public ProfissionalConfiguracaoDeactivatedEvent(ILogRequestContext ctx, ProfissionalConfiguracao data) 
            : base(ctx, data) { }
    }
    public partial class FuncionarioCreatedEvent : BaseEvent
    {
        public FuncionarioCreatedEvent(ILogRequestContext ctx, Funcionario data) 
            : base(ctx, data) { }
    }
    public partial class FuncionarioDeletedEvent : BaseEvent
    {
        public FuncionarioDeletedEvent(ILogRequestContext ctx, Funcionario data) 
            : base(ctx, data) { }
    }
    public partial class FuncionarioDeletedRangeEvent : BaseEvent
    {
        public FuncionarioDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Funcionario> data) 
            : base(ctx, data) { }
    }
    public partial class FuncionarioActivatedEvent : BaseEvent
    {
        public FuncionarioActivatedEvent(ILogRequestContext ctx, Funcionario data) 
            : base(ctx, data) { }
    }
    public partial class FuncionarioUpdatedEvent : BaseEvent
    {
        public FuncionarioUpdatedEvent(ILogRequestContext ctx, Funcionario data) 
            : base(ctx, data) { }
    }
    public partial class FuncionarioUpdatedRangeEvent : BaseEvent
    {
        public FuncionarioUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Funcionario> data) 
            : base(ctx, data) { }
    }
    public partial class FuncionarioDeactivatedEvent : BaseEvent
    {
        public FuncionarioDeactivatedEvent(ILogRequestContext ctx, Funcionario data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalCreatedEvent : BaseEvent
    {
        public ProfissionalCreatedEvent(ILogRequestContext ctx, Profissional data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalDeletedEvent : BaseEvent
    {
        public ProfissionalDeletedEvent(ILogRequestContext ctx, Profissional data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalDeletedRangeEvent : BaseEvent
    {
        public ProfissionalDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Profissional> data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalActivatedEvent : BaseEvent
    {
        public ProfissionalActivatedEvent(ILogRequestContext ctx, Profissional data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalUpdatedEvent : BaseEvent
    {
        public ProfissionalUpdatedEvent(ILogRequestContext ctx, Profissional data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalUpdatedRangeEvent : BaseEvent
    {
        public ProfissionalUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Profissional> data) 
            : base(ctx, data) { }
    }
    public partial class ProfissionalDeactivatedEvent : BaseEvent
    {
        public ProfissionalDeactivatedEvent(ILogRequestContext ctx, Profissional data) 
            : base(ctx, data) { }
    }
    public partial class ProfessionalsAggSettingsCreatedEvent : BaseEvent
    {
        public ProfessionalsAggSettingsCreatedEvent(ILogRequestContext ctx, ProfessionalsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ProfessionalsAggSettingsDeletedEvent : BaseEvent
    {
        public ProfessionalsAggSettingsDeletedEvent(ILogRequestContext ctx, ProfessionalsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ProfessionalsAggSettingsDeletedRangeEvent : BaseEvent
    {
        public ProfessionalsAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<ProfessionalsAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class ProfessionalsAggSettingsActivatedEvent : BaseEvent
    {
        public ProfessionalsAggSettingsActivatedEvent(ILogRequestContext ctx, ProfessionalsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ProfessionalsAggSettingsUpdatedEvent : BaseEvent
    {
        public ProfessionalsAggSettingsUpdatedEvent(ILogRequestContext ctx, ProfessionalsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ProfessionalsAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public ProfessionalsAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<ProfessionalsAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class ProfessionalsAggSettingsDeactivatedEvent : BaseEvent
    {
        public ProfessionalsAggSettingsDeactivatedEvent(ILogRequestContext ctx, ProfessionalsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class CboCreatedEvent : BaseEvent
    {
        public CboCreatedEvent(ILogRequestContext ctx, Cbo data) 
            : base(ctx, data) { }
    }
    public partial class CboDeletedEvent : BaseEvent
    {
        public CboDeletedEvent(ILogRequestContext ctx, Cbo data) 
            : base(ctx, data) { }
    }
    public partial class CboDeletedRangeEvent : BaseEvent
    {
        public CboDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Cbo> data) 
            : base(ctx, data) { }
    }
    public partial class CboActivatedEvent : BaseEvent
    {
        public CboActivatedEvent(ILogRequestContext ctx, Cbo data) 
            : base(ctx, data) { }
    }
    public partial class CboUpdatedEvent : BaseEvent
    {
        public CboUpdatedEvent(ILogRequestContext ctx, Cbo data) 
            : base(ctx, data) { }
    }
    public partial class CboUpdatedRangeEvent : BaseEvent
    {
        public CboUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Cbo> data) 
            : base(ctx, data) { }
    }
    public partial class CboDeactivatedEvent : BaseEvent
    {
        public CboDeactivatedEvent(ILogRequestContext ctx, Cbo data) 
            : base(ctx, data) { }
    }
}
