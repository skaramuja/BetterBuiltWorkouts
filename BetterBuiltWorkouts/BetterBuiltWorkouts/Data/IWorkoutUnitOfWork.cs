using BetterBuiltWorkouts.Models;
using System.Collections.Generic;

namespace BetterBuiltWorkouts.Data
{
    public interface IWorkoutUnitOfWork
    {

        // Exercise model
        IRepository<Exercise> Exercises { get; }
        IEnumerable<Exercise> ListOfExercises(string activeType);

        Exercise GetExercise(int id);
        void InsertExercise(Exercise entity);
        void UpdateExercise(Exercise entity);
        void DeleteExercise(Exercise entity);


        // Plan model
        IRepository<Plan> Plans { get; }
        IEnumerable<Plan> ListOfPlans();
        Plan GetPlan(int id);
        void InsertPlan(Plan entity);
        void UpdatePlan(Plan entity);
        void DeletePlan(Plan entity);


        // ExerciseType model
        IRepository<ExerciseType> ExerciseTypes { get; }
        ExerciseType GetExerciseType(string id);
        IEnumerable<ExerciseType> ListAllExerciseTypes();


        // General Context Save
        void Save();
    }
}
