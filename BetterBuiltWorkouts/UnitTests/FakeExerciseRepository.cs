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
            return;
        }

        public Exercise GetOne(QueryOptions<Exercise> options)
        {
            return new Exercise();
        }

        public void Insert(Exercise entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exercise> List(QueryOptions<Exercise> options)
        {
            return new List<Exercise>();
        }

        public void SaveChanges()
        {
            return;
        }

        public void Update(Exercise entity)
        {
            throw new NotImplementedException();
        }
    }
}
