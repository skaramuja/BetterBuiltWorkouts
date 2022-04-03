using System.Collections.Generic;

namespace BetterBuiltWorkouts.Data
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List(QueryOptions<T> options);
        T GetIntId(int id);
        T GetStringId(string id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save(); // this will be removed when I implament the UOW pattern

    }

}
