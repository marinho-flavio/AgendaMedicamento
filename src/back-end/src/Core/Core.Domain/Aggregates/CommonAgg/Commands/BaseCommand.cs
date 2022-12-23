using FluentValidation.Results;
using MediatR;
using SES.Core.Domain.Aggregates.CommonAgg.Events;
using SES.Core.Domain.Aggregates.CommonAgg.Notifications;
using SES.CrossCutting.Infra.Log.Contexts;
using System.Text.Json.Serialization;

namespace SES.Core.Domain.Aggregates.CommonAgg.Commands
{
    public abstract class BaseCommand : BaseNotification, IRequest<ValidationResult>, IBaseRequest
    {
        protected BaseCommand(ILogRequestContext ctx) 
            : base(ctx)
        {
        }

        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        public virtual bool IsValid()
        {
            return !this.ValidationResult.Errors.Any();
        }
    }
}
