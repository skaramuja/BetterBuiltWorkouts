using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public DateTime Start { get; set; }

        public DateTime End { get; set; }
        public string CompletedBy { get; set; }

        public int PlanId { get; set; }

        public Plan Plan { get; set; }
    }
}
