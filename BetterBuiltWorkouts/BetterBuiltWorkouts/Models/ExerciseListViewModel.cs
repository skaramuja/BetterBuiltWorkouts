using System;
using System.Collections.Generic;

namespace BetterBuiltWorkouts.Models
{
    public class ExerciseListViewModel : ExerciseViewModel
    {
        public List<Exercise> Exercises { get; set; }

        private List<ExerciseType> exerciseTypes;
        public List<ExerciseType> ExerciseTypes
        {
            get => exerciseTypes;
            set
            {
                exerciseTypes = value;
                exerciseTypes.Insert(0,
                    new ExerciseType { ExerciseTypeID = "all", Name = "All" });
            }
        }
        public string CheckActiveExerciseType(string g) =>
            g.ToLower() == ActiveExerciseType.ToLower() ? "active" : "";
    }
}
