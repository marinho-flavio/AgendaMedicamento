using SES.Core.Domain.Aggregates.CommonAgg.Notifications;
using SES.CrossCutting.Infra.Log.Contexts;

namespace SES.Core.Domain.Aggregates.CommonAgg.Events
{
    public class BaseEvent : BaseNotification
    {
        public object Data { get; set; }

        public BaseEvent()
        {

        }

        private BaseEvent(ILogRequestContext ctx)
            :base(ctx)
        {
        }

        public BaseEvent(ILogRequestContext context, object data)
            : this(context)
        {
            this.Data = data;
        }
    }
}
