using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetterBuiltWorkouts.Models;

namespace BetterBuiltWorkouts.Controllers
{
    public class WorkoutController : Controller
    {
        private ExerciseContext context;

        public WorkoutController(ExerciseContext ctx)
        {
            context = ctx;
        }

        [Route("Create-Workout")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("Perform-Workout")]
        public IActionResult Perform()
        {
            return View();
        }
        [Route("Exercises-Workout")]
        public IActionResult Exercises(ExerciseListViewModel model)
        {
            model.ExerciseTypes = context.ExerciseTypes.ToList();
            // get Exercises - filter by Exersise Type
            IQueryable<Exercise> exerciseQuery = context.Exercises;
            if(model.ActiveExerciseType.ExerciseTypeID != "all")
                exerciseQuery = exerciseQuery.Where(
                    e => e.ExerciseTypes.Contains(model.ActiveExerciseType));
            model.Exercises = exerciseQuery.ToList();
            return View(model);
        }
    }
}
