using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Extensions;
using BetterBuiltWorkouts.Models;
using BetterBuiltWorkouts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BetterBuiltWorkouts.Controllers
{
    public class WorkoutController : Controller
    {
        private IWorkoutUnitOfWork data { get; set; }
        private CloneModel clone;
        public WorkoutController(IWorkoutUnitOfWork unit)
        { 
            data = unit;
            clone = new CloneModel(data);
            
        }


        // Plan Section
        public IActionResult PlanList()
        {
            PlanListViewModel model = new PlanListViewModel { Plans = data.ListOfPlans().ToList() };
            return View(model);
        }

        [HttpGet]
        public IActionResult CreatePlan()
        {
            ViewBag.Action = "Create";
            return View("PlanEdit", new PlanViewModel() { PlanName = "New Plan", Exercises = data.ListOfExercises("all").ToList() });
        }

        [HttpGet]
        public ViewResult CopyPlan(int id)
        {
            ViewBag.Action = "Copy";

            Plan plan = data.GetPlan(id);
            PlanViewModel model = new PlanViewModel { 
                PlanName = "New Plan",
                PlanId = 0,
                Exercises = data.ListOfExercises("all").ToList(),
                Exercise1 = plan.Exercises[0].Name,
                Exercise1Id = plan.Exercises[0].ExerciseId,
                Exercise2 = plan.Exercises[1].Name,
                Exercise2Id = plan.Exercises[1].ExerciseId,
                Exercise3 = plan.Exercises[2].Name,
                Exercise3Id = plan.Exercises[2].ExerciseId
            };
            return View("PlanEdit", model);
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
            //TempData["message"] = "Plan was successfully deleted."; // This throws a nullreferenceexception in the test only. ???
            return RedirectToAction("PlanList", "Workout");
        }

        [HttpGet]
        public IActionResult PlanEdit(int id)
        {
            ViewBag.Verb = "Edit";
            ViewBag.Action = "Save";
            Plan plan = data.GetPlan(id);
            PlanViewModel model = new PlanViewModel {
                PlanName = plan.Name,
                PlanId = plan.PlanId,
                Exercises = data.ListOfExercises("all").ToList(),
                Exercise1 = plan.Exercises[0].Name,
                Exercise1Id = plan.Exercises[0].ExerciseId,
                Exercise2 = plan.Exercises[1].Name,
                Exercise2Id = plan.Exercises[1].ExerciseId,
                Exercise3 = plan.Exercises[2].Name,
                Exercise3Id = plan.Exercises[2].ExerciseId
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult PlanEdit(PlanViewModel plan)
        {
            if (ModelState.IsValid)
            {
                List<Exercise> newExercises = new List<Exercise>();
                var newExercise1 = clone.CloneExercise(data.GetExercise(plan.Exercise1Id), plan.CreatedBy);
                newExercises.Add(newExercise1);
                newExercises[0].PlanId = null;
                var newExercise2 = clone.CloneExercise(data.GetExercise(plan.Exercise2Id), plan.CreatedBy);
                newExercises.Add(newExercise2);
                newExercises[1].PlanId = null;
                var newExercise3 = clone.CloneExercise(data.GetExercise(plan.Exercise3Id), plan.CreatedBy);
                newExercises.Add(newExercise3);
                newExercises[2].PlanId = null;
                if (plan.PlanId != 0) //Edit existing
                {
                    TempData["message"] = $"{plan.Name} was successfully Updated.";


                    var oldPlan = data.GetPlan(plan.PlanId);
                    data.DeletePlan(oldPlan);
                    data.Save();
                }
                else // Add new
                {
                    TempData["message"] = $"{plan.PlanName} was successfully added.";
                }

                Plan newPlan = new Plan()
                {
                    Exercises = newExercises,
                    CreatedBy = plan.CreatedBy,
                    Name = plan.PlanName
                };

                data.Plans.Insert(newPlan);
                data.Save();
                clone.UpdateExercises(newPlan.Exercises, newPlan.PlanId);
                data.Save();
                return RedirectToAction("PlanList", "Workout");
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
        public IActionResult ExerciseList(GridDTO vals)
        {
            string defaultSort = nameof(Exercise.Name);
            var builder = new GridBuilder(HttpContext.Session, vals, defaultSort); 
            var options = new QueryOptions<Exercise>
            {
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize
              };
            options.Where = e => e.CreatedBy != User.Identity.Name;

            if (vals.FilterBy != "all")
            {
                options.Where = et => et.ExerciseTypeID == vals.FilterBy;
                
            }
            var vm = new ExerciseListViewModel
            {
                Exercises = data.Exercises.List(options),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Exercises.Count)
            };
            vm.ExerciseTypes = data.ListAllExerciseTypes().ToList();
            return View(vm);
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

        [HttpGet]
        public ViewResult CopyExercise(int id)
        {
            ViewBag.Action = "Copy";
            ViewBag.Types = data.ListAllExerciseTypes().ToList();
            Exercise exercise = data.GetExercise(id);
            exercise.ExerciseId = 0;
            return View("Edit", exercise);
        }

        [HttpPost]
        public IActionResult Delete(Exercise exercise)
        {
            data.DeleteExercise(exercise);
            data.Save();
            //TempData["message"] = "Exercise was successfully deleted"; // This throws a nullreferenceexception in the test only. ???
            return RedirectToAction("ExerciseList", "Workout");
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
                    TempData["message"] = $"{exercise.Name} was successfully added.";
                }
                else
                {
                    exercise.CreatedBy = User.Identity.Name;
                    data.Exercises.Update(exercise);
                    TempData["message"] = $"{exercise.Name} was successfully Updated.";
                } 
                data.Save();
                return RedirectToAction("ExerciseList", "Workout");
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
            PlanListViewModel model = new PlanListViewModel { Plans = data.ListOfPlans().ToList() };
            return View(model);
        }

        public IActionResult Workout(int id)
        {
            Plan plan = data.GetPlan(id);
            WorkoutViewModel model = new WorkoutViewModel() { Plan = plan, Workout = new Workout() };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Finish(WorkoutViewModel model)
        {
            Workout completed = model.Workout;
            completed.End = System.DateTime.Now;
            completed.PlanId = model.Plan.PlanId;
            data.InsertWorkout(completed);
            data.Save();
            TempData["Time"] = (completed.End - completed.Start).ToString("hh':'mm':'ss");
            TempData["Plan"] = model.Plan.Name;
            TempData["User"] = model.Workout.CompletedBy;
            return RedirectToAction("Gratz");
        }

        public IActionResult Gratz()
        {
            return View();
        }

    }
}
