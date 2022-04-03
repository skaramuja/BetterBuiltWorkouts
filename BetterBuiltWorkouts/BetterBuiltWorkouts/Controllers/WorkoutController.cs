using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BetterBuiltWorkouts.Controllers
{
    public class WorkoutController : Controller
    {
        private Repository<Exercise> exerciseData { get; set; }
        private Repository<ExerciseType> exerciseTypeData { get; set; }

        public WorkoutController(ApplicationDbContext ctx)
        {
            exerciseData = new Repository<Exercise>(ctx);
            exerciseTypeData = new Repository<ExerciseType>(ctx);
        }

        public IActionResult Details(int id)
        {
            var exercise = exerciseData.GetIntId(id);
            ViewBag.ExerciseType = exerciseTypeData.GetStringId(exercise.ExerciseTypeID);
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
            var exerciseTypes = exerciseTypeData.List(new QueryOptions<ExerciseType>
                {
                    OrderBy = o => o.ExerciseTypeID
                });

            model.ExerciseTypes = exerciseTypes.ToList();

            // Code duplication here. #TODO
            if (model.ActiveExerciseType != "all")
                {
                    model.Exercises = exerciseData.List(new QueryOptions<Exercise> {
                        Where = x => x.ExerciseTypeID == model.ActiveExerciseType
                    }).ToList();
                }
            else
                {
                    model.Exercises = exerciseData.List(new QueryOptions<Exercise>
                    {
                    }).ToList();
                }
   
            return View(model);
        }

        [HttpGet]
        public ViewResult CreateExercise()
        {
            ViewBag.Types = exerciseTypeData.List(new QueryOptions<ExerciseType> { });
            Exercise model = new Exercise();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateExercise(Exercise model)
        {

            if (ModelState.IsValid)
            {
                model.CreatedBy = User.Identity.Name;
                exerciseData.Insert(model);
                exerciseData.Save();
                return RedirectToAction("Details", new { id = model.ExerciseId });
            }
            else
            {
                ViewBag.Types = exerciseTypeData.List(new QueryOptions<ExerciseType> { });
                ModelState.AddModelError("", "There are errors in the form.");
                return View(model);
            }
        }
    }
}
