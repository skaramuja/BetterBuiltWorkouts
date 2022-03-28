using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BetterBuiltWorkouts.Models
{
    public class Exercise
    {
        [Required]
        public string ExerciseID { get; set; }


        [Required]
        [StringLength(75, ErrorMessage = "Name must be less than 75 characters.")]
        public string Name { get; set; }


        [Required]
        public ExerciseType ExerciseType { get; set; }


        public string Image { get; set; }


        // If the user wants to share the exercise publicly 
        public bool IsPublic { get; set; }


        public string CreatedBy { get; set; }


        // For exercises that have a specific distance
        [StringLength(50, ErrorMessage = "Distance must be less than 50 characters long.")]
        public string Distance { get; set; }


        // For exercises that have a specific length of time
        public string Time { get; set; }


        [StringLength(50, ErrorMessage = "Weight must be less than 50 characters long.")]
        public string Weight { get; set; }


        public string Reps { get; set; }


        // For optional video link
        public string Link { get; set; }


        [StringLength(500, ErrorMessage = "Note must be less than 500 characters long.")]
        public string  Note { get; set; }

    }
}
