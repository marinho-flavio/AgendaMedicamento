using SES.Core.Domain.Aggregates.CommonAgg.Commands;
using SES.CrossCutting.Infra.Log.Contexts;
using MediatR;

namespace SES.Core.Application.Aggregates.Common
{
    public class BaseAppService
    {
        protected readonly IMediator _mediator;
        protected readonly ILogRequestContext _logRequestContext;

        public BaseAppService(ILogRequestContext logRequestContext, IMediator mediator)
        {
            _mediator = mediator;
            _logRequestContext = logRequestContext;
        }

        protected void SendCommand<T>(T command)
            where T : BaseCommand
        {
            _mediator.Send(command);
        }
    }
}
