using MediatR;
using Newtonsoft.Json;
using SES.CrossCutting.Infra.Log.Contexts;
using Serilog.Events;
using System.Diagnostics;

namespace SES.Core.Domain.Aggregates.CommonAgg.Notifications
{
    public class BaseNotification : INotification
    {
        public BaseNotification()
        {

        }
        public BaseNotification(ILogRequestContext context)
        {
            Context = context;
            Date = DateTime.UtcNow;
            StopWatch = new Stopwatch();
        }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Stopwatch StopWatch { get; set; }

        public TimeSpan TimeElapsed => StopWatch.Elapsed;

        [JsonIgnore]
        public ILogRequestContext Context { get; }

        public LogEventLevel LogType { get; set; }
    }
}
