using SES.Core.Domain.Aggregates.CommonAgg.Events;
using SES.CrossCutting.Infra.Log.Contexts;

namespace SES.Schedulings.Domain.Aggregates.CompaniesAgg.ModelEvents
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
namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class SchedulingsAggSettingsCreatedEvent : BaseEvent
    {
        public SchedulingsAggSettingsCreatedEvent(ILogRequestContext ctx, SchedulingsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class SchedulingsAggSettingsDeletedEvent : BaseEvent
    {
        public SchedulingsAggSettingsDeletedEvent(ILogRequestContext ctx, SchedulingsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class SchedulingsAggSettingsDeletedRangeEvent : BaseEvent
    {
        public SchedulingsAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<SchedulingsAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class SchedulingsAggSettingsActivatedEvent : BaseEvent
    {
        public SchedulingsAggSettingsActivatedEvent(ILogRequestContext ctx, SchedulingsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class SchedulingsAggSettingsUpdatedEvent : BaseEvent
    {
        public SchedulingsAggSettingsUpdatedEvent(ILogRequestContext ctx, SchedulingsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class SchedulingsAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public SchedulingsAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<SchedulingsAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class SchedulingsAggSettingsDeactivatedEvent : BaseEvent
    {
        public SchedulingsAggSettingsDeactivatedEvent(ILogRequestContext ctx, SchedulingsAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class FeriadoCreatedEvent : BaseEvent
    {
        public FeriadoCreatedEvent(ILogRequestContext ctx, Feriado data) 
            : base(ctx, data) { }
    }
    public partial class FeriadoDeletedEvent : BaseEvent
    {
        public FeriadoDeletedEvent(ILogRequestContext ctx, Feriado data) 
            : base(ctx, data) { }
    }
    public partial class FeriadoDeletedRangeEvent : BaseEvent
    {
        public FeriadoDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Feriado> data) 
            : base(ctx, data) { }
    }
    public partial class FeriadoActivatedEvent : BaseEvent
    {
        public FeriadoActivatedEvent(ILogRequestContext ctx, Feriado data) 
            : base(ctx, data) { }
    }
    public partial class FeriadoUpdatedEvent : BaseEvent
    {
        public FeriadoUpdatedEvent(ILogRequestContext ctx, Feriado data) 
            : base(ctx, data) { }
    }
    public partial class FeriadoUpdatedRangeEvent : BaseEvent
    {
        public FeriadoUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Feriado> data) 
            : base(ctx, data) { }
    }
    public partial class FeriadoDeactivatedEvent : BaseEvent
    {
        public FeriadoDeactivatedEvent(ILogRequestContext ctx, Feriado data) 
            : base(ctx, data) { }
    }
}
namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
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
}
namespace SES.Schedulings.Domain.Aggregates.UsersAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
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
namespace SES.Schedulings.Domain.Aggregates.PartnersAgg.ModelEvents
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
}
