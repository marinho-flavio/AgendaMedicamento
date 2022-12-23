using SES.Core.Application.DTO.Extensions;
using SES.Core.Domain.Aggregates.CommonAgg.Events;
using SES.CrossCutting.Infra.Log.Entries;
using SES.CrossCutting.Infra.Log.Extensions;
using SES.CrossCutting.Infra.Log.Providers;

namespace SES.Core.Domain.Extensions
{
    public static class NotificationExtensions
    {
        public static void PublishLog<T>(this Serilog.ILogger _logger, T notification)
            where T : BaseEvent
        {
            var className = typeof(T).Name;

            notification.Title = string.IsNullOrWhiteSpace(notification.Title) ?
               $"[{notification.Context.ServiceName} {notification.Context.OperationName}]" :
               $"{notification.Title}";

            _logger.Write(notification.ProjectedAs<LogEntry>());
        }

        public static void Write<T>(this ILogProvider logger, T notification)
            where T : BaseEvent
        {
           Task.Run(() => logger.Provider.PublishLog(notification));
        }
    }
}
