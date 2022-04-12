using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Evan
{
    public interface IDataStore
    {
        public IRepository<Exercise> Exercises { get; }
        public IRepository<Plan> Plans { get; }
        public IRepository<ExerciseType> ExerciseTypes { get; }

        public void SaveChanges();
    }
}
