using System.Collections.Generic;

namespace BetterBuiltWorkouts.Models
{
    public class Exercise
    {
        public string ExerciseID { get; set; }
        public string Name { get; set; }
        public List<ExerciseType> ExerciseTypes { get; set; }
        public string Image { get; set; }
    }
}
