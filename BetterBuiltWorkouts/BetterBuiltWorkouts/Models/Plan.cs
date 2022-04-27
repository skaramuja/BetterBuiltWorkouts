using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Models
{
    public class Plan
    {

        public int PlanId { get; set; }

        [RegularExpression(@"^.*\.(jpg|JPG|gif|GIF|webp|WEBP|png|PNG)$", ErrorMessage = "JPG, GIF, PNG and Webp images only.")]
        public string Image { get; set; }
        public string Name { get; set; }

        public string CreatedBy { get; set; }

        [ValidateNever] 
        public List<Exercise> Exercises { get; set; }

    }
}
