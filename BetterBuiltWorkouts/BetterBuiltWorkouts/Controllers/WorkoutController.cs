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
            IQueryable<Exercise> query = context.Exercises;
            if(model.ActiveExerciseType != "all")
                query = query.Where(x => x.ExerciseType.ExerciseTypeID == model.ActiveExerciseType);
            model.Exercises = query.ToList();
            return View(model);
        }
    }
}
