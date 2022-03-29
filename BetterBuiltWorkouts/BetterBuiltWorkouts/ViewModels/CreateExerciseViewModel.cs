using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Models
{
    public class CreateExerciseViewModel
    {
        public CreateExerciseViewModel()
        {

        }
        public string ExerciseTypeID { get; set; }

        private Exercise exercise;
        public Exercise Exercise
        {
            get => Exercise;
            set
            {

            }
        }
    }
}



//private List<ExerciseType> exerciseTypes;
//public List<ExerciseType> ExerciseTypes
//{
//    get => exerciseTypes;
//    set
//    {
//        exerciseTypes = value;
//        exerciseTypes.Insert(0,
//            new ExerciseType { ExerciseTypeID = "all", Name = "All" });
//    }
//}
