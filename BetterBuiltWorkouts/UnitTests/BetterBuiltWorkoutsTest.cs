using BetterBuiltWorkouts.Controllers;
using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace BetterBuiltWorkoutsTest
{
    public class BetterBuiltWorkoutsTest
    {
        [Fact]
        public void CreatePlanActionMethod_ReturnsAViewResult()
        {
            var exerciseRepository = new FakeExerciseRepository();
            var planRepository = new FakePlanRepository();
            var exerciseTypeReposiotry = new FakeExerciseTypeReposiotry();
           // var controller = new WorkoutController(exerciseRepository, planRepository, exerciseTypeReposiotry);
           // var result = controller.CreatePlan();
           // Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlanDetailsActionMethod_ReturnsAViewResult()
        {
            var exerciseRepository = new FakeExerciseRepository();
            var planRepository = new FakePlanRepository();
            var exerciseTypeReposiotry = new FakeExerciseTypeReposiotry();
            //var controller = new WorkoutController(exerciseRepository, planRepository, exerciseTypeReposiotry);
            //var result = controller.PlanDetails(4);
            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlanDeleteActionMethod_ReturnsAViewResult()
        {
            var exerciseRepository = new FakeExerciseRepository();
            var planRepository = new FakePlanRepository();
            var exerciseTypeReposiotry = new FakeExerciseTypeReposiotry();
            //var controller = new WorkoutController(exerciseRepository, planRepository, exerciseTypeReposiotry);
            //var result = controller.PlanDelete(new Plan());
            //Assert.IsType<RedirectToActionResult>(result);
        }
    }
}