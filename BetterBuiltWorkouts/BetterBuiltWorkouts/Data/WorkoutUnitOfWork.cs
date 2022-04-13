using BetterBuiltWorkouts.Models;
using System.Collections.Generic;
using System.Linq;

namespace BetterBuiltWorkouts.Data
{
    public class WorkoutUnitOfWork : IWorkoutUnitOfWork
    {

        private ApplicationDbContext context { get; set; }
        public WorkoutUnitOfWork(ApplicationDbContext ctx) => context = ctx;



        // Exercise section
        private Repository<Exercise> exerciseData;
        public Repository<Exercise> Exercises
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
            return  Exercises.Get(id);
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


        // Plan section
        private Repository<Plan> planData;
        public Repository<Plan> Plans
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


        // ExerciseType Section
        private Repository<ExerciseType> exerciseTypeData;
        public Repository<ExerciseType> ExerciseTypes
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
            context.SaveChanges();

        }
    }
}
