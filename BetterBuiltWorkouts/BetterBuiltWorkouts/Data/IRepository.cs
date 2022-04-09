using System.Collections.Generic;

namespace BetterBuiltWorkouts.Data
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List(QueryOptions<T> options);

        T GetOne(QueryOptions<T> options);
        void Insert(T entity);
        void SaveChanges();
        void Update(T entity);
        void Delete(T entity);
    }

}
