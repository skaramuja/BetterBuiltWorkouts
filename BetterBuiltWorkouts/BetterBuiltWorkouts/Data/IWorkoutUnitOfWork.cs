using BetterBuiltWorkouts.Models;
using System.Collections.Generic;

namespace BetterBuiltWorkouts.Data
{
    public interface IWorkoutUnitOfWork
    {

        // Exercise model
        Repository<Exercise> Exercises { get; }
        IEnumerable<Exercise> ListOfExercises(string activeType);

        Exercise GetExercise(int id);
        void InsertExercise(Exercise entity);
        void UpdateExercise(Exercise entity);
        void DeleteExercise(Exercise entity);


        // Plan model
        Repository<Plan> Plans { get; }
        IEnumerable<Plan> ListOfPlans();
        IEnumerable<Plan> ListOfPlans(string userName);
        Plan GetPlan(int id);
        void InsertPlan(Plan entity);
        void UpdatePlan(Plan entity);
        void DeletePlan(Plan entity);

        // Workout model
        Repository<Workout> Workouts { get; }
        IEnumerable<Workout> ListOfWorkouts();
        Workout GetWorkout(int id);
        void InsertWorkout(Workout entity);
        void DeleteWorkout(Workout entity);

        // ExerciseType model
        Repository<ExerciseType> ExerciseTypes { get; }
        ExerciseType GetExerciseType(string id);
        IEnumerable<ExerciseType> ListAllExerciseTypes();


        // General Context Save
        void Save();
    }
}
