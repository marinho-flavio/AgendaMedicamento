using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using System.Linq.Expressions;

namespace SES.Core.Domain.Aggregates.CommonAgg.Queries
{
    public interface IQueryModel<E>
        where E : Entity
    {
        Expression<Func<E, bool>> GetFilter();
    }
}
