﻿using BetterBuiltWorkouts.Data;
using System;
using System.Collections.Generic;

namespace BetterBuiltWorkouts.Models
{
    public class ExerciseListViewModel : ExerciseViewModel
    {
        public IEnumerable<Exercise> Exercises { get; set; }

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
        public RouteDictonary CurrentRoute { get; set; }
        public int TotalPages { get; set; }
        public string CheckActiveExerciseType(string g) =>
            g.ToLower() == ActiveExerciseType.ToLower() ? "active" : "";
    }
}
