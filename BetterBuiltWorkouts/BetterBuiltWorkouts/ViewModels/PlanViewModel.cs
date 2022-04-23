using System;
using System.Collections.Generic;

namespace BetterBuiltWorkouts.Models
{
    public class PlanViewModel : Plan
    {
        public string PlanName { get; set; }

        public List<Exercise> Exercises { get; set; }
        public string Exercise1 { get; set; }
        public int Exercise1Id { get; set; }
        public string Exercise2 { get; set; }
        public int Exercise2Id { get; set; }
        public string Exercise3 { get; set; }
        public int Exercise3Id { get; set; }
    }
}
