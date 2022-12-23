using SES.Core.Domain.Seedwork;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.Extensions.DependencyInjection;

namespace SES.Core.Domain.Aggregates.CommonAgg.Commands.Handles
{
    public class BaseCommandHandler
    {
        readonly protected ValidationResult ValidationResult;
        protected readonly IMediator _mediator;
        protected readonly IServiceProvider _serviceProvider;

        protected BaseCommandHandler(IMediator mediator, IServiceProvider serviceProvider)
        {
            ValidationResult = new ValidationResult();
            _mediator = mediator;
            _serviceProvider = serviceProvider;
        }

        protected ValidationResult AddError(string mensagem, string propertyName = null)
        {
            ValidationResult.Errors.Add(new ValidationFailure(propertyName ?? string.Empty, mensagem));
            return this.ValidationResult;
        }

        protected async Task<ValidationResult> Commit(IUnitOfWork uow, string message)
        {
            if (ValidationResult.Errors?.Any() != true && !(await uow.CommitAsync()))
            {
                AddError(message);
            }

            return ValidationResult;
        }

        protected async Task<ValidationResult> Commit(IUnitOfWork uow)
        {
            return await Commit(uow, "There was an error saving data").ConfigureAwait(continueOnCapturedContext: false);
        }

        protected void PublishLog<T>(T cmd)
            where T : BaseCommand
        {
            _mediator.Publish(cmd);
        }
    }
}
