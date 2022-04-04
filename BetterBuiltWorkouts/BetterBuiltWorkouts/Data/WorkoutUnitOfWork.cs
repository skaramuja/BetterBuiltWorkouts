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
            return Exercises.GetIntId(id);
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

        public IEnumerable<ExerciseType> ListOfExerciseTypes(QueryOptions<ExerciseType> options)
        {
            return ExerciseTypes.List(options);
        }

        public IEnumerable<ExerciseType> ListAllExerciseTypes()
        {
            return ExerciseTypes.List(new QueryOptions<ExerciseType> { });
        }


        public ExerciseType GetExerciseType(string id)
        {
            return ExerciseTypes.GetStringId(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
