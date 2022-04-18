using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Views.Workout.Components
{
    public class UserExercisesViewComponent : ViewComponent
    {
        private IRepository<Exercise> data { get; set; }
        public UserExercisesViewComponent(IRepository<Exercise> repo) => data = repo;

        public IViewComponentResult Invoke(string userName, string exerciseTypeID)
        {
            QueryOptions<Exercise> options;
            if (exerciseTypeID == "all")
            {
                options = new QueryOptions<Exercise> { Where = e => e.CreatedBy == userName };
            }
            else
            {
                options = new QueryOptions<Exercise> { Where = e => e.CreatedBy == userName && e.ExerciseTypeID == exerciseTypeID };
            }
            var userExercises = data.List(options);
            var model = new ExerciseListViewModel() { Exercises = userExercises };
            return View("Default.cshtml", model);
        }
    }
}
