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

        public string  CreatedBy { get; set; }

        public int? TimesCompleted { get; set; }

        IEnumerable<Exercise> Exercises { get; set; }

        DateTime Start { get; set; }

        DateTime End { get; set; }

    }
}
