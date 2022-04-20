using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Models
{
    public class Plan
    {

        public int PlanId { get; set; }

        public string Name { get; set; }

        public string CreatedBy { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        [ValidateNever] 
        public List<Exercise> Exercises { get; set; }

    }
}
