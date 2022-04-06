using System.Collections.Generic;

namespace BetterBuiltWorkouts.Models
{
    public class ExerciseType
    {
        public string Name { get; set; }
        public string ExerciseTypeID { get; set; }

        public ICollection<Exercise> Exercises { get; set; }
    }
}
