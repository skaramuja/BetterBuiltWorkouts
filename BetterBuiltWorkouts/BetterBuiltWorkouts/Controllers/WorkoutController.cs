using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Extensions;
using BetterBuiltWorkouts.Models;
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
            ViewBag.Exercises = data.ListOfExercises("all").ToList();
            Plan plan = data.GetPlan(id);
            PlanViewModel model = new PlanViewModel { PlanName = "New Plan" };
            //model.Plan.PlanId = 0;
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
                PlanName = "New Plan", 
                Exercises = data.ListOfExercises("all").ToList(),
            };
            model.Exercise1 = plan.Exercises[0].ExerciseTypeID;
            model.Exercise2 = plan.Exercises[1].ExerciseTypeID;
            model.Exercise3 = plan.Exercises[2].ExerciseTypeID;
            return View(model);
        }

        [HttpPost]
        public IActionResult PlanEdit(PlanViewModel plan)
        {
            if (ModelState.IsValid)
            {
                if (plan.PlanId == 0)
                {
                    List<Exercise> newExercises = new List<Exercise>();
                    var newExercise1 = clone.CloneExercise(data.GetExercise(int.Parse(plan.Exercise1)), plan.CreatedBy);
                    newExercises.Add(newExercise1);
                    var newExercise2 = clone.CloneExercise(data.GetExercise(int.Parse(plan.Exercise2)), plan.CreatedBy);
                    newExercises.Add(newExercise2);
                    var newExercise3 = clone.CloneExercise(data.GetExercise(int.Parse(plan.Exercise3)), plan.CreatedBy);
                    newExercises.Add(newExercise3);

                    Plan newPlan = new Plan()
                    {
                        Exercises = newExercises,
                        CreatedBy = plan.CreatedBy,
                        Name = plan.PlanName
                    };
                    data.Plans.Insert(newPlan);
                    data.Save();
                    clone.UpdateExercises(newPlan.Exercises, newPlan.PlanId);
                    TempData["message"] = $"{newPlan.Name} was successfully added.";
                }
                else
                {
                    plan.CreatedBy = User.Identity.Name;
                    data.Plans.Update(plan);
                    data.Save();
                    TempData["message"] = $"{plan.Name} was successfully updated.";
                }
                    //data.Save();
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
            return View();
        }

    }
}
