using BetterBuiltWorkouts.Controllers;
using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace BetterBuiltWorkoutsTest
{
    public class WorkoutControllerTests
    {
        private WorkoutController _controller;
        private FakePlanRepository _fakePlan;
        public WorkoutControllerTests()
        {
            var exerciseRepository = new FakeExerciseRepository();
            _fakePlan = new FakePlanRepository();
            var exerciseTypeReposiotry = new FakeExerciseTypeReposiotry();
            _controller = new WorkoutController(exerciseRepository, _fakePlan, exerciseTypeReposiotry);
        }
        [Fact]
        public void CreatePlanActionMethod_ReturnsAViewResult()
        {

            var result = _controller.CreatePlan();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlanDetailsActionMethod_ReturnsAViewResult()
        {

            var result = _controller.PlanDetails(4);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlanDeleteActionMethod_ReturnsARedirectToActionResult()
        {
            var result = _controller.PlanDelete(new Plan());
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void PlanEditActionMethod_ReturnAViewResult()
        {
            var result = _controller.PlanEdit(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlanEditPostMethodInvalid_ReturnAViewResult()
        {
            _controller.ModelState.AddModelError("", "Error Message");
            var result = _controller.PlanEdit(new Plan());
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlanEditPostMethodValid_ReturnARedirectToActionResult()
        {
            var result = _controller.PlanEdit(new Plan());
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void ExerciseMethod_ReturnAViewResult()
        {
            var result = _controller.Exercises(new ExerciseListViewModel() );
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void DetailsMethod_ReturnAViewResult()
        {
            var result = _controller.Details(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void CreateExerciseMethod_ReturnAViewResult()
        {
            var result = _controller.CreateExercise();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void DeleteMethodValid_ReturnARedirectToActionResult()
        {
            var result = _controller.Delete(new Exercise());
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void EditMethod_ReturnAViewResult()
        {
            var result = _controller.Edit(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void EditActionMethod_ReturnAViewResult()
        {
            var result = _controller.Edit(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void EditPostMethodInvalid_ReturnAViewResult()
        {
            _controller.ModelState.AddModelError("", "Error Message");
            var result = _controller.Edit(new Exercise());
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PreformMethod_ReturnAViewResult()
        {
            var result = _controller.Perform();
            Assert.IsType<ViewResult>(result);
        }

        public void Dispose()
        {
            _controller = null;
        }
    }
}
