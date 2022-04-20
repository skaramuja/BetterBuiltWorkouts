using BetterBuiltWorkouts.Controllers;
using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;
using Moq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace BetterBuiltWorkoutsTest
{
    public class WorkoutControllerTests
    {

        public IWorkoutUnitOfWork GetUnitOfWork()
        {
            // Setup unit of work
            var unit = new Mock<IWorkoutUnitOfWork>();
            unit.Setup(e => e.GetPlan(It.IsAny<int>())).Returns(new Plan());
            unit.Setup(e => e.GetExercise(It.IsAny<int>())).Returns(new Exercise());
            return unit.Object;
        }


        [Fact]
        public void CreatePlanActionMethod_ModelIsAPlanListViewModel_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            //ACT
            var result = controller.PlanList();
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result);
            PlanListViewModel model = Assert.IsType<PlanListViewModel>(vr.Model);
        }

        [Fact]
        public void PlanDetailsActionMethod_ModelIsAPlanModel_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            //ACT
            var result = controller.PlanDetails(1);
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result);
            Plan model = Assert.IsType<Plan>(vr.Model);
        }

        [Fact]
        public void PlanDeleteActionMethod_ReturnsRedirectToAction_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            //ACT
            var result = controller.PlanDelete(new Plan());
            //ASSERT
            RedirectToActionResult vr = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal(nameof(controller.PlanList), vr.ActionName);
        }

        [Fact]
        public void PlanEditActionMethod_ModelIsAPlanModel_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            //ACT
            var result = controller.PlanEdit(1);
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result);
            Plan model = Assert.IsType<Plan>(vr.Model);
        }

        //[Fact]
        //public void PlanEditActionMethodPostInvalid_ModelIsAPlanModel_Moq()
        //{
        //    //ARRANGE
        //    var controller = new WorkoutController(GetUnitOfWork());
        //    controller.ModelState.AddModelError("", "Test error message.");
        //    //ACT
        //    var result = controller.PlanEdit(new Plan());
        //    //ASSERT
        //    ViewResult vr = Assert.IsType<ViewResult>(result);
        //    Plan model = Assert.IsType<Plan>(vr.Model);
        //}

        // I am unable to properly mock a user in the User.Identity.Name for this
        //[Fact]
        //public void PlanEditActionMethodPostValid_ReturnsRedirectToAction_Moq()
        //{
        //    //ARRANGE
        //    var controller = new WorkoutController(GetUnitOfWork());
        //    //ACT
        //    var result = controller.PlanEdit(new Plan());
        //    //ASSERT
        //    RedirectToActionResult vr = Assert.IsType<RedirectToActionResult>(result);
        //    Assert.Equal(nameof(controller.CreatePlan), vr.ActionName);
        //}

        //[Fact]
        //public void ExercisesActionMethod_ModelIsAExerciseListViewModel_Moq()
        //{
        //    //ARRANGE
        //    var controller = new WorkoutController(GetUnitOfWork());
        //    //ACT
        //    var result = controller.Exercises(new ExerciseListViewModel());
        //    //ASSERT
        //    ViewResult vr = Assert.IsType<ViewResult>(result);
        //    ExerciseListViewModel model = Assert.IsType<ExerciseListViewModel>(vr.Model);
        //}

        [Fact]
        public void CreateExercisesActionMethod_ModelIsAExerciseModel_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            //ACT
            var result = controller.CreateExercise();
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result);
            Exercise model = Assert.IsType<Exercise>(vr.Model);
        }

        [Fact]
        public void DetailsActionMethod_ModelIsAnExerciseObject_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            //ACT
            var result = controller.Details(1);
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result); 
            Exercise model = Assert.IsType<Exercise>(vr.Model);
        }

        //[Fact]
        //public void DeleteActionMethod_ReturnsRedirectToAction_Moq()
        //{
        //    //ARRANGE
        //    var controller = new WorkoutController(GetUnitOfWork());
        //    //ACT
        //    var result = controller.Delete(new Exercise());
        //    //ASSERT
        //    RedirectToActionResult vr = Assert.IsType<RedirectToActionResult>(result);
        //    Assert.Equal(nameof(controller.Exercises), vr.ActionName);
        //}

        [Fact]
        public void EditActionMethod_ModelIsAnExerciseObject_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            //ACT
            var result = controller.Edit(1);
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result);
            Exercise model = Assert.IsType<Exercise>(vr.Model);
        }

        [Fact]
        public void EditActionMethodPostInvalid_ModelIsAnExerciseModel_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            controller.ModelState.AddModelError("", "Test error message.");
            //ACT
            var result = controller.Edit(new Exercise());
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result);
            Exercise model = Assert.IsType<Exercise>(vr.Model);
        }

        // I am unable to properly mock a user in the User.Identity.Name for this
        //[Fact]
        //public void EditActionMethodPostValid_ReturnsRedirectToAction_Moq()
        //{
        //    //ARRANGE
        //    var controller = new WorkoutController(GetUnitOfWork());
        //    //ACT
        //    var result = controller.Edit(new Plan());
        //    //ASSERT
        //    RedirectToActionResult vr = Assert.IsType<RedirectToActionResult>(result);
        //    Assert.Equal(nameof(controller.Exercises), vr.ActionName);
        //}

    [Fact]
    public void PerformMethod_ReturnsAViewResult_Moq()
    {
        //ARRANGE
        var controller = new WorkoutController(GetUnitOfWork());
        //ACT
        var result = controller.Perform();
        //ASSERT
        ViewResult vr = Assert.IsType<ViewResult>(result);
    }

    }
}
