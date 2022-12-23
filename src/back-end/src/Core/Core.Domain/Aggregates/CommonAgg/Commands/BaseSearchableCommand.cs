using SES.CrossCutting.Infra.Log.Contexts;

namespace SES.Core.Domain.Aggregates.CommonAgg.Commands
{
    public abstract class BaseSearchableCommand<T> : BaseCommand
        where T : class
    {
        public T Query { get; private set; }

        protected BaseSearchableCommand(ILogRequestContext ctx, T query)
            : base(ctx)
        {
            this.Query = query;
        }
    }
}
