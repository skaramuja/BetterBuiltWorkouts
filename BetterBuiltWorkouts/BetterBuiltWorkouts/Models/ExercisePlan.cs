using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Models
{
    public class ExercisePlan
    {
        public int ExerciseId { get; set; }
        public int PlanId { get; set; }

        // Navagation properties
        public Exercise Exercise { get; set; }
        public Plan Plan { get; set; }
    }
}
