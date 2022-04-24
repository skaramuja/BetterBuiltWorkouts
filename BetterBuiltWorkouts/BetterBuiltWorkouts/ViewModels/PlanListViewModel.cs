
using System;
using System.Collections.Generic;

namespace BetterBuiltWorkouts.Models
{
    public class PlanListViewModel : Plan
    {
        public List<Plan> Plans { get; set; }

      
        public List<Exercise> Exercise { get; set; }

    }
}
