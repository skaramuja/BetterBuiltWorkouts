using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Models
{
    public class Plan
    {
        //public Plan()
        //{
        //    Exercises = new List<Exercise>();
        //}

        public int PlanId { get; set; }

        public string Name { get; set; }

        public string  CreatedBy { get; set; }

        public int? TimesCompleted { get; set; }

        public int? ExerciseId { get; set; }

        List<Exercise> Exercises { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        // Navagation property
        public ICollection<ExercisePlan> ExercisePlans { get; set; }

    }
}
