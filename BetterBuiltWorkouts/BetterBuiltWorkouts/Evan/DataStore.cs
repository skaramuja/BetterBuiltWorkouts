using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Evan
{
    public class DataStore : IDataStore
    {
        private ApplicationDbContext context { get; set; }
        public DataStore(ApplicationDbContext ctx) => context = ctx;

        private Repository<Exercise> exerciseData;
        public IRepository<Exercise> Exercises
        {
            get
            {
                if (exerciseData == null)
                {
                    exerciseData = new Repository<Exercise>(context);
                }
                return exerciseData;
            }
        }
        private Repository<Plan> planData;
        public IRepository<Plan> Plans
        {
            get
            {
                if (planData == null)
                {
                    planData = new Repository<Plan>(context);
                }
                return planData;
            }
        }

        private Repository<ExerciseType> exerciseTypeData;
        public IRepository<ExerciseType> ExerciseTypes
        {
            get
            {
                if (exerciseTypeData == null)
                {
                    exerciseTypeData = new Repository<ExerciseType>(context);
                }
                return exerciseTypeData;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
