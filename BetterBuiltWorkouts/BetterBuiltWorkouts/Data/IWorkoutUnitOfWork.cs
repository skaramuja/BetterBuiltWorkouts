﻿using BetterBuiltWorkouts.Models;
using System.Collections.Generic;

namespace BetterBuiltWorkouts.Data
{
    interface IWorkoutUnitOfWork
    {

        // Exercise model
        IEnumerable<Exercise> ListOfExercises(string activeType);

        Exercise GetExercise(int id);
        void InsertExercise(Exercise entity);
        void UpdateExercise(Exercise entity);
        void DeleteExercise(Exercise entity);


        // ExerciseType model
        IEnumerable<ExerciseType> ListOfExerciseTypes(QueryOptions<ExerciseType> options);

        IEnumerable<ExerciseType> ListAllExerciseTypes();

        ExerciseType GetExerciseType(string id);

        // General Context Save
        void Save();
    }
}