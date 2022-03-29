using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BetterBuiltWorkouts.Models
{
    public class Exercise
    {
   
        public int ExerciseId { get; set; }


        [Required]
        [NameAttribute(50)]
        public string Name { get; set; }


        public ExerciseType ExerciseType { get; set; }
        public string ExerciseTypeID { get; set; }


        public string Image { get; set; }


        // If the user wants to share the exercise publicly 
        public bool IsPublic { get; set; }


        public string CreatedBy { get; set; }


        // For exercises that have a specific distance
        //[DistanceAttribute(10)]
        public string Distance { get; set; }


        // For exercises that have a specific length of time
        public string Time { get; set; }


        //[WeightAttribute(50)]
        public string Weight { get; set; }


        public string Reps { get; set; }


        // For optional video link
        public string Link { get; set; }


        [StringLength(500, ErrorMessage = "Note must be less than 500 characters long.")]
        public string  Note { get; set; }

    }
}
