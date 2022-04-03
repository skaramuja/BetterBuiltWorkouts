using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BetterBuiltWorkouts.Controllers
{
    public class WorkoutController : Controller
    {
        private WorkoutUnitOfWork data { get; set; }

        public WorkoutController(ApplicationDbContext ctx)
        {
            data = new WorkoutUnitOfWork(ctx);
        }

        public IActionResult Details(int id)
        {
            var exercise = data.GetExercise(id);
            ViewBag.ExerciseType = data.GetExerciseType(exercise.ExerciseTypeID);
            return View(exercise);
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
            var exerciseTypes = data.ListOfExercises(model.ActiveExerciseType);
            model.ExerciseTypes = data.ListAllExerciseTypes().ToList();
            model.Exercises = exerciseTypes.ToList();

            return View(model);
        }

        [HttpGet]
        public ViewResult CreateExercise()
        {
            ViewBag.Types = data.ListAllExerciseTypes().ToList();
            Exercise model = new Exercise();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateExercise(Exercise model)
        {

            if (ModelState.IsValid)
            {
                model.CreatedBy = User.Identity.Name;
                data.InsertExercise(model);
                data.Save();
                return RedirectToAction("Details", new { id = model.ExerciseId });
            }
            else
            {
                ViewBag.Types = data.ListAllExerciseTypes().ToList();
                ModelState.AddModelError("", "There are errors in the form.");
                return View(model);
            }
        }
    }
}
