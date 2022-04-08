using System;
using System.Collections.Generic;

namespace BetterBuiltWorkouts.Models
{
    public class PlanViewModel : Plan
    {
        public Plan Plan { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}
