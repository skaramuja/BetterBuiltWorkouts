using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetterBuiltWorkouts.Models;
using BetterBuiltWorkouts.Data;

namespace BetterBuiltWorkouts.Controllers
{
    public class WorkoutController : Controller
    {
        private ApplicationDbContext context;

        public WorkoutController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Details(string id)
        {
            Exercise model = context.Exercises.Find(id);
            return View(model);
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

        [HttpGet]
        public IActionResult CreateExercise()
        {
            ViewBag.Types = context.ExerciseTypes.ToList();
            Exercise model = new Exercise();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateExercise(Exercise model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedBy = User.Identity.Name;
                context.Exercises.Add(model);
                context.SaveChanges();
                return RedirectToAction("CreateExercise");
            }
            else
            {
                ViewBag.Types = context.ExerciseTypes.ToList();
                return View(model);
            }
        }
    }
}
