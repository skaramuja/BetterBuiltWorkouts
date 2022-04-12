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
    public class FakeExerciseRepository //: IRepository<Exercise>
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
    }
}
