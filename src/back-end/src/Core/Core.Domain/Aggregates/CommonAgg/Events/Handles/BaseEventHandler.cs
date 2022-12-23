using FluentValidation.Results;
using SES.Core.Domain.Extensions;
using SES.Core.Domain.Seedwork;
using SES.CrossCutting.Infra.Log.Providers;

namespace SES.Core.Domain.Aggregates.CommonAgg.Events.Handles
{
    public class BaseEventHandler
    {
        readonly ILogProvider _logProvider;

        protected BaseEventHandler(ILogProvider logProvider)
        {
            _logProvider = logProvider;
        }

        protected void PublishLog<T>(T evnt)
            where T : BaseEvent
        {
            _logProvider.Write(evnt);
        }
    }
}
