using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BetterBuiltWorkouts.Controllers
{
    public class WorkoutController : Controller
    {
        private WorkoutUnitOfWork data { get; set; }

        public WorkoutController(IRepository<Exercise> exerciseRepository, IRepository<Plan> planRepository, IRepository<ExerciseType> exerciseTypeRepository)
        {
            data = new WorkoutUnitOfWork(exerciseRepository, planRepository, exerciseTypeRepository);
        }

        // Plan Section
        [Route("CreatePlan-Workout")]
        public IActionResult CreatePlan()
        {
            PlanListViewModel model = new PlanListViewModel{ Plans = data.ListOfPlans().ToList() };
            return View(model);
        }

        public IActionResult PlanDetails(int id)
        {
            var model = data.GetPlan(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult PlanDelete(Plan plan)
        {
            data.DeletePlan(plan);
            data.Save();
            return RedirectToAction("CreatePlan", "Workout");
        }

        [HttpGet]
        public IActionResult PlanEdit(int id)
        {
            ViewBag.Verb = "Edit";
            ViewBag.Action = "Save";
            ViewBag.Exercises = data.ListOfExercises("all");
            Plan plan = data.GetPlan(id);
            return View(plan);
        }

        [HttpPost]
        public IActionResult PlanEdit(Plan plan)
        {
            if (ModelState.IsValid)
            {
                if (plan.PlanId == 0)
                {
                    //plan.CreatedBy = User.Identity.Name;
                    data.Plans.Insert(plan);
                }
                else
                {
                    data.Plans.Update(plan);
                }
                data.Save();
                return RedirectToAction("CreatePlan", "Workout");
            }
            else
            {
                ViewBag.Verb = "Edit";
                ViewBag.Action = "Save";
                ViewBag.Exercises = data.ListOfExercises("all");
                return View(plan);

            }
        }


        // Exercise section
        [Route("Exercises-Workout")]
        public IActionResult Exercises(ExerciseListViewModel model)
        {
            var exerciseTypes = data.ListOfExercises(model.ActiveExerciseType);
            model.ExerciseTypes = data.ListAllExerciseTypes().ToList();
            model.Exercises = exerciseTypes.ToList();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var exercise = data.GetExercise(id);
            ViewBag.ExerciseType = data.GetExerciseType(exercise.ExerciseTypeID);
            ViewBag.Types = data.ListAllExerciseTypes().ToList();
            return View(exercise);
        }

        [HttpGet]
        public ViewResult CreateExercise()
        {
            ViewBag.Action = "Create";
            ViewBag.Types = data.ListAllExerciseTypes().ToList();
            return View("Edit", new Exercise());
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


        // Preform Section
        [Route("Perform-Workout")]
        public IActionResult Perform()
        {
            return View();
        }

    }
}
