using BetterBuiltWorkouts.Models;
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
        private string user;

        public CloneModel(IWorkoutUnitOfWork data, PlanViewModel viewModel, string thisUser)
        {
            context = data;
            model = viewModel;
            user = thisUser;
        }

        public PlanViewModel CloneExercises()
        {
            foreach(Exercise exercise in model.Exercises)
            {
                var newExercise = context.GetExercise(exercise.ExerciseId);
                newExercise.ExerciseId = 0;
                newExercise.CreatedBy = user;
                context.InsertExercise(newExercise);
                context.Save();
                ClonedExercises.Add(newExercise);
            }

            model.Exercises = ClonedExercises;

            return model;
        }

        public void UpdateExercises(List<Exercise> exercises, int planId)
        {
            foreach(Exercise exercise in exercises)
            {
                exercise.ExerciseId = planId;
                context.UpdateExercise(exercise);
                context.Save();
            }
        }
    }
}
