using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Evan
{
    public class UOW : IWorkoutUnitOfWork
    {
        private IDataStore store { get; set; }
        public UOW(IDataStore ctx) => store = ctx;


        public IRepository<Exercise> Exercises { get { return store.Exercises; } }
        public IRepository<Plan> Plans { get { return store.Plans; } }
        public IRepository<ExerciseType> ExerciseTypes { get { return store.ExerciseTypes; } }


        public IEnumerable<Exercise> ListOfExercises(string activeType)
        {
            if (activeType != "all")
            {
                return Exercises.List(new QueryOptions<Exercise>
                {
                    Where = x => x.ExerciseTypeID == activeType
                }).ToList();
            }
            else
            {
                return Exercises.List(new QueryOptions<Exercise> { });
            }
        }

        public Exercise GetExercise(int id)
        {
            return Exercises.Get(id);
        }

        public void InsertExercise(Exercise entity)
        {
            Exercises.Insert(entity);
        }

        public void UpdateExercise(Exercise entity)
        {
            Exercises.Update(entity);
        }

        public void DeleteExercise(Exercise entity)
        {
            Exercises.Delete(entity);
        }



        public IEnumerable<Plan> ListOfPlans()
        {
            return Plans.List(new QueryOptions<Plan> { Includes = "ExercisePlans.Exercise" });
        }

        public Plan GetPlan(int id)
        {
            return Plans.Get(new QueryOptions<Plan> { Includes = "ExercisePlans.Exercise", Where = p => p.PlanId == id });
        }

        public void InsertPlan(Plan entity)
        {
            Plans.Insert(entity);
        }

        public void UpdatePlan(Plan entity)
        {
            Plans.Update(entity);
        }

        public void DeletePlan(Plan entity)
        {
            Plans.Delete(entity);
        }



        public ExerciseType GetExerciseType(string id)
        {
            return ExerciseTypes.Get(id);
        }

        public IEnumerable<ExerciseType> ListAllExerciseTypes()
        {
            return ExerciseTypes.List(new QueryOptions<ExerciseType> { });
        }



        // UnitOfWork Save
        public void Save()
        {
            store.SaveChanges();
            //Plans.SaveChanges();
            //Exercises.SaveChanges();
            //ExerciseTypes.SaveChanges();
        }
    }
}
