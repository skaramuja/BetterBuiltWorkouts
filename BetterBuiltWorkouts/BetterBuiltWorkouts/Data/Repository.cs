using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace BetterBuiltWorkouts.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext context { get; set; }
        private DbSet<T> dbset { get; set; }
        public Repository(ApplicationDbContext ctx)
        {
            context = ctx;
            dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> List(QueryOptions<T> options)
        {
            IQueryable<T> query = dbset;
            foreach(string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
            {
                query = query.Where(options.Where);
            }
            if (options.HasOrderBy)
            {
                query = query.OrderBy(options.OrderBy);
            }
            return query.ToList();
        }

        public virtual void Delete(T entity) => dbset.Remove(entity);

        public virtual T GetIntId(int id) => dbset.Find(id);

        public virtual T GetOne(QueryOptions<T> options)
        {
            IQueryable<T> query = dbset;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
            {
                query = query.Where(options.Where);
            }
    
            return query.FirstOrDefault<T>();
        }

        public virtual T GetStringId(string id) => dbset.Find(id);

        public virtual void Insert(T entity) => dbset.Add(entity);

        public virtual void Update(T entity) => dbset.Update(entity);

    }
}
