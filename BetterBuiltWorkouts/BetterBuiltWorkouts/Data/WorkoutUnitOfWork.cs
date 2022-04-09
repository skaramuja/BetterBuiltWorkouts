using BetterBuiltWorkouts.Models;
using System.Collections.Generic;
using System.Linq;

namespace BetterBuiltWorkouts.Data
{
    public class WorkoutUnitOfWork : IWorkoutUnitOfWork
    {
        public WorkoutUnitOfWork(IRepository<Exercise> exerciseRepository, IRepository<Plan> planRepository, IRepository<ExerciseType> exerciseTypeRepository)
        {
            this.Exercises = exerciseRepository;
            this.Plans = planRepository;
            this.ExerciseTypes = exerciseTypeRepository;
        }


        // Exercise section
        public IRepository<Exercise> Exercises { get; set; }

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
            return  Exercises.GetOne(new QueryOptions<Exercise>
            {
                Includes = "ExerciseType",
                Where = i => i.ExerciseId == id
            });
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
        public IRepository<Plan> Plans { get; set; }

        public IEnumerable<Plan> ListOfPlans()
        {
            return Plans.List(new QueryOptions<Plan> { Includes = "ExercisePlans.Exercise" });
        }

        public Plan GetPlan(int id)
        {
            return Plans.GetOne(new QueryOptions<Plan>
            {
                Includes = "ExercisePlans.Exercise",
                Where = i => i.PlanId == id
            });
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
        public IRepository<ExerciseType> ExerciseTypes { get; set; }

        public ExerciseType GetExerciseType(string id)
        {
            return ExerciseTypes.GetOne(new QueryOptions<ExerciseType>
            {
                Where = i => i.ExerciseTypeID == id
            });
        }

        public IEnumerable<ExerciseType> ListAllExerciseTypes()
        {
            return ExerciseTypes.List(new QueryOptions<ExerciseType> { });
        }



        // UnitOfWork Save
        public void Save()
        {
            Plans.SaveChanges();
            Exercises.SaveChanges();
            ExerciseTypes.SaveChanges();
        }
    }
}
