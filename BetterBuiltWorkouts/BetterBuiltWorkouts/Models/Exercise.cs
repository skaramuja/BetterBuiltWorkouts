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

        [Required(ErrorMessage = "Please select an Exercise type.")]
        public string ExerciseTypeID { get; set; }

        [RegularExpression(@"^.*\.(jpg|JPG|gif|GIF|webp|WEBP)$", ErrorMessage = "JPG, GIF and Webp images only.")]
        public string Image { get; set; }


        // If the user wants to share the exercise publicly 
        public bool IsPublic { get; set; }


        public string CreatedBy { get; set; }


        // For exercises that have a specific distance
        //[DistanceAttribute(10)]
        [StringLength(25, ErrorMessage = "Distance must be less than 25 characters longs.")]
        public string Distance { get; set; }


        // For exercises that have a specific length of time
        [StringLength(25, ErrorMessage = "Time must be less than 25 characters.")]
        public string Time { get; set; }


        //[WeightAttribute(50)]
        [StringLength(50, ErrorMessage = "Weight must be less that 50 characters long.")]
        public string Weight { get; set; }


        [StringLength(25, ErrorMessage = "Reps must be less than 25 characters.")]
        public string Reps { get; set; }


        // For optional video link
        public string Link { get; set; }


        [StringLength(500, ErrorMessage = "Note must be less than 500 characters long.")]
        public string  Note { get; set; }

    }
}
