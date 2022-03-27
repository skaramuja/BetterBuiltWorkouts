using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BetterBuiltWorkouts.Models
{
    public class Exercise
    {
        [Required]
        public string ExerciseID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ExerciseType ExerciseType { get; set; }
        public string Image { get; set; }
    }
}
