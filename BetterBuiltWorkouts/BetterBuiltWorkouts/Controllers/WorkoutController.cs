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
            ViewBag.Types = data.ListAllExerciseTypes().ToList();
            return View(exercise);
        }

        [Route("CreatePlan-Workout")]
        public IActionResult CreatePlan()
        {
            PlanListViewModel model = new PlanListViewModel{ Plans = data.ListOfPlans().ToList() };
            model.Exercises = data.ListOfExercises("all").ToList();
            return View(model);
        }

        public IActionResult PlanDetails(int id)
        {
            var model = data.GetPlan(id);
            model.ExercisePlans = data.ListOfExercisePlans(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Exercise exercise)
        {
            data.DeleteExercise(exercise);
            data.Save();
            return RedirectToAction("Exercises", "Workout");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Verb = "Edit";
            ViewBag.Action = "Save";
            ViewBag.Types = data.ListAllExerciseTypes().ToList();
            Exercise exercise = data.GetExercise(id);
            return View(exercise);
        }

        [HttpPost]
        public IActionResult Edit(Exercise exercise)
        {
            if (ModelState.IsValid)
            {
                if (exercise.ExerciseId == 0)
                {
                    exercise.CreatedBy = User.Identity.Name;
                    data.Exercises.Insert(exercise);
                }
                else
                {
                    data.Exercises.Update(exercise);
                } 
                data.Save();
                return RedirectToAction("Exercises", "Workout");
            }
            else
            {
                ViewBag.Verb = (exercise.ExerciseId == 0) ? "Create" : "Edit";
                ViewBag.Action = (exercise.ExerciseId == 0) ? "Create" : "Save";
                ViewBag.Types = data.ListAllExerciseTypes().ToList();
                return View(exercise);

            }
        }


        [HttpGet]
        public ViewResult CreateExercise()
        {
            ViewBag.Action = "Create";
            ViewBag.Types = data.ListAllExerciseTypes().ToList();
            return View("Edit", new Exercise());
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

    }
}
