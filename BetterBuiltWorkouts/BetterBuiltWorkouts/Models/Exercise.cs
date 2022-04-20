using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BetterBuiltWorkouts.Models
{
    public class Exercise
    {
   
        public int ExerciseId { get; set; }


        [Required]
        //[Name(50, ErrorMessage = "Name must be less that 50 characters.")]
        [StringLength(50, ErrorMessage = "Exercise name must be less than 50 characters.")]
        public string Name { get; set; }


        public ExerciseType ExerciseType { get; set; }

        [Required(ErrorMessage = "Please select an Exercise type.")]
        public string ExerciseTypeID { get; set; }


        [RegularExpression(@"^.*\.(jpg|JPG|gif|GIF|webp|WEBP)$", ErrorMessage = "JPG, GIF and Webp images only.")]
        public string Image { get; set; }


        public string CreatedBy { get; set; }


        // For exercises that have a specific distance
        [StringLength(25, ErrorMessage = "Distance must be less than 25 characters longs.")]
        public string Distance { get; set; }


        // For exercises that have a specific length of time
        [StringLength(25, ErrorMessage = "Time must be less than 25 characters.")]
        public string Time { get; set; }


        [StringLength(50, ErrorMessage = "Weight must be less that 50 characters long.")]
        public string Weight { get; set; }


        [StringLength(25, ErrorMessage = "Reps must be less than 25 characters.")]
        public string Reps { get; set; }



        [StringLength(500, ErrorMessage = "Note must be less than 500 characters long.")]
        public string  Note { get; set; }

        public Plan Plan { get; set; }

        public int? PlanId { get; set; }

    }
}
