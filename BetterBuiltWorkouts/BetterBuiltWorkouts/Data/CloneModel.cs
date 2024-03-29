﻿using BetterBuiltWorkouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Data
{
    public class CloneModel
    {
        private IWorkoutUnitOfWork context;
        private PlanViewModel model;
        private List<Exercise> ClonedExercises = new List<Exercise>();


        public CloneModel(IWorkoutUnitOfWork data)
        {
            context = data;
        }

        public PlanViewModel CloneExercises()
        {
            foreach(Exercise exercise in model.Exercises)
            {
                var newExercise = context.GetExercise(exercise.ExerciseId);
                newExercise.ExerciseId = 0;
                context.InsertExercise(newExercise);
                context.Save();
                ClonedExercises.Add(newExercise);
            }

            model.Exercises = ClonedExercises;

            return model;
        }

        public Exercise CloneExercise(Exercise old, string user)
        {
            var newExercise = context.GetExercise(old.ExerciseId);
            newExercise.ExerciseId = 0;
            newExercise.PlanId = null;
            newExercise.CreatedBy = user;
            context.InsertExercise(newExercise);
            context.Save();
            return newExercise;
        }

        public List<Exercise> AddPlanId(List<Exercise> exercises, int planId)
        {
            foreach(Exercise e in exercises)
            {
                e.PlanId = planId;
                context.UpdateExercise(e);
                context.Save();
            }
            return exercises;
        }

        public Exercise UpdateExercise(int exerciseId, int planId)
        {
            var exercise = context.GetExercise(exerciseId);
            exercise.PlanId = planId;
            context.UpdateExercise(exercise);
            context.Save();
            return exercise;
        }

        public void UpdateExercises(List<Exercise> exercises, int planId)
        {
            foreach(Exercise exercise in exercises)
            {
                exercise.PlanId = planId;
                context.UpdateExercise(exercise);
                context.Save();
            }
        }
    }
}
