using SES.Core.Domain.Aggregates.CommonAgg.Repositories;
using SES.Core.Domain.Seedwork;
using SES.Core.Infra.Data.Contexts;
using SES.Core.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SES.Core.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class, new()
    {
        protected BaseContext _ctx;
        public IUnitOfWork UnitOfWork => _ctx;

        public Repository(BaseContext ctx)
        {
            _ctx = ctx;
        }

        public virtual void Add(T entity)
        {
            _ctx.Add(entity);
        }
        public virtual void Delete(T entity)
        {
            _ctx.Remove(entity);
        }
        public virtual void DeleteRange(IEnumerable<T> entity)
        {
            _ctx.RemoveRange();
        }
        public virtual async Task DeleteRange(Expression<Func<T, bool>> filter)
        {
            _ctx.RemoveRange(await FindAllAsync(filter));
        }

        public virtual void Update(T entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
        }

        public async Task<bool> Exists(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> set = Set();

            return await set.AnyAsync(filter);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> set = Set();

            return await set.CountAsync(filter);
        }
        public async Task<K> MaxAsync<K>(Expression<Func<T, bool>> filter, Expression<Func<T, K>> selector)
        {
            IQueryable<T> set = Set();

            return await set.Where(filter).Select(selector).MaxAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> set = Set();

            return await set.AnyAsync(filter);
        }

        protected IQueryable<T> Set()
        {
            return _ctx.Set<T>().Include(_ctx.GetIncludePaths(typeof(T), 2)).AsQueryable();
        }
        public async Task<T> FindAsync(Expression<Func<T, bool>> spec)
        {
            return await FindOneAsync(spec);
        }
        public virtual Task<T> FindAsync(Expression<Func<T, bool>> specification, params Expression<Func<T, object>>[] include)
        {
            return FindOneAsync(specification, include);
        }
        private Task<T> FindOneAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set();

            foreach (var item in include) set = set.Include(item);

            set = set.IncludeAllRecursively();

            return set.FirstOrDefaultAsync(filter);
        }
        private Task<T> FindOneAsync(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> set = Set();

            set = set.IncludeAllRecursively();

            return set.FirstOrDefaultAsync(filter);
        }

        public async Task<IEnumerable<K>> SelectAllAsync<K>(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, K>> selector,
                Expression<Func<T, object>>[] orderBy = null,
            bool ascending = true,
            int? skip = null,
            int? take = null,
            params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set();

            foreach (var item in include) set = set.Include(item);

            if (orderBy != null)
            {
                foreach (var item in orderBy)
                {
                    if (ascending)
                        set = set.OrderBy(item);
                    else
                        set = set.OrderByDescending(item);
                }
            }

            var set2 = set.Where(filter).Select(selector).Distinct();

            if (skip.HasValue)
                set2 = set2.Skip(skip.Value);

            if (take.HasValue)
                set2 = set2.Take(take.Value);

            return await set2.ToArrayAsync();
        }

        public async Task<IEnumerable<K>> FindAllAsync<K>(
                Expression<Func<T, bool>> filter,
                Expression<Func<T, K>> selector,
                Expression<Func<T, object>>[] orderBy = null,
                bool ascending = true,
                int? skip = null,
                int? take = null,
                params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set();

            foreach (var item in include) set = set.Include(item);

            if (orderBy != null)
            {
                foreach (var item in orderBy)
                {
                    if (ascending)
                        set = set.OrderBy(item);
                    else
                        set = set.OrderByDescending(item);
                }
            }

            set = set.Where(filter);

            if (skip.HasValue)
                set = set.Skip(skip.Value);

            if (take.HasValue)
                set = set.Take(take.Value);

            return await set.Select(selector).ToArrayAsync();
        }
        public async Task<K> FindAsync<K>(
            Expression<Func<T, K>> selector,
            Expression<Func<T, bool>> filter,
            params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set();

            foreach (var item in include) set = set.Include(item);

            return await set.Where(filter).Select(selector).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<T>> FindAllAsync(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, object>>[] orderBy = null,
            bool ascending = true,
            params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> set = Set();

            foreach (var item in include) set = set.Include(item);

            if (orderBy != null)
            {
                foreach (var item in orderBy)
                {
                    if (ascending)
                        set = set.OrderBy(item);
                    else
                        set = set.OrderByDescending(item);
                }
            }

            return await set.Where(filter).ToArrayAsync();
        }

        public async Task<IEnumerable<IGrouping<object, K>>> GroupByAsync<K>(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, K>> selector,
            Expression<Func<T, K>>[] orderBy = null,
            Expression<Func<K, object>> groupBy = null,
            bool ascending = true,
            params Expression<Func<T, K>>[] include)
        {
            IQueryable<T> set = Set();

            foreach (var item in include) set = set.Include(item);

            if (orderBy != null)
            {
                foreach (var item in orderBy)
                {
                    if (ascending)
                        set = set.OrderBy(item);
                    else
                        set = set.OrderByDescending(item);
                }
            }

            return await set.Where(filter).Select(selector).GroupBy(groupBy).ToListAsync();
        }

        public void Dispose()
        {
        }
    }

}
