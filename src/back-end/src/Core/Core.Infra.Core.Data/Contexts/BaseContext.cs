using SES.Core.Domain.Seedwork;
using SES.Core.Infra.Data.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace SES.Core.Infra.Data.Contexts
{
    public class BaseContext : DbContext, IUnitOfWork
    {
        IMediator _mediator;
        public BaseContext(IMediator mediator, DbContextOptions options)
            : base(options)
        {
            _mediator = mediator;
        }

        public bool Commit()
        {
            return CommitAsync().Result;
        }


        public async Task<bool> CommitAsync()
        {
            // Dispatch Domain Events collection. 
            // Choices:
            // A) Right BEFORE committing data (EF SaveChanges) into the DB will make a single transaction including  
            // side effects from the domain event handlers which are using the same DbContext with "InstancePerLifetimeScope" or "scoped" lifetime
            // B) Right AFTER committing data (EF SaveChanges) into the DB will make multiple transactions. 
            // You will need to handle eventual consistency and compensatory actions in case of failures in any of the Handlers. 

            // After executing this line all the changes (from the Command Handler and Domain Event Handlers) 
            // performed through the DbContext will be committed
            var success = await SaveChangesAsync() > 0;

            await _mediator.PublishDomainEvents(this).ConfigureAwait(false);

            return success;
        }
    }
}
