using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using SES.Core.Domain.Seedwork;
using System.Linq.Expressions;

namespace SES.Core.Domain.Aggregates.CommonAgg.Repositories
{
    public interface IRepository<T> : IDisposable
        where T : class, new()
    {
        void Add(T entity);
        void DeleteRange(IEnumerable<T> entity);
        void Delete(T entity);
        void Update(T entity);
        Task<bool> Exists(Expression<Func<T, bool>> spec);
        Task<T> FindAsync(Expression<Func<T, bool>> spec);
        Task<int> CountAsync(Expression<Func<T, bool>> filter);
        Task<T> FindAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] include);
        Task<K> FindAsync<K>(Expression<Func<T, K>> selector, Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] include);
        Task<IEnumerable<T>> FindAllAsync(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, object>>[] orderBy = null,
            bool ascending = true,
            params Expression<Func<T, object>>[] include);
        Task<IEnumerable<K>> FindAllAsync<K>(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, K>> selector,
            Expression<Func<T, object>>[] orderBy = null,
            bool ascending = true,
            int? skip = null,
            int? take = null,
            params Expression<Func<T, object>>[] include);
        Task<IEnumerable<K>> SelectAllAsync<K>(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, K>> selector,
                Expression<Func<T, object>>[] orderBy = null,
            bool ascending = true,
            int? skip = null,
            int? take = null,
            params Expression<Func<T, object>>[] include);
        public IUnitOfWork UnitOfWork { get; }
    }
}
