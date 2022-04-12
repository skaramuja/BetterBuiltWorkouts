using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBuiltWorkoutsTest
{
    public class FakeExerciseRepository : IRepository<Exercise>
    {
        public void Delete(Exercise entity)
        {
            throw new NotImplementedException();
        }

        public Exercise GetOne(QueryOptions<Exercise> options)
        {
            throw new NotImplementedException();
        }

        public void Insert(Exercise entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exercise> List(QueryOptions<Exercise> options)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            return;
        }

        public void Update(Exercise entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Exercise>.Delete(Exercise entity)
        {
            throw new NotImplementedException();
        }

        Exercise IRepository<Exercise>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Exercise IRepository<Exercise>.Get(string id)
        {
            throw new NotImplementedException();
        }

        Exercise IRepository<Exercise>.Get(QueryOptions<Exercise> options)
        {
            throw new NotImplementedException();
        }

        void IRepository<Exercise>.Insert(Exercise entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Exercise> IRepository<Exercise>.List(QueryOptions<Exercise> options)
        {
            throw new NotImplementedException();
        }

        void IRepository<Exercise>.Update(Exercise entity)
        {
            throw new NotImplementedException();
        }
    }
}
