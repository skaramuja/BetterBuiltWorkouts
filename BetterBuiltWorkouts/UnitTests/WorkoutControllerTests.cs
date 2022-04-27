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
using System.Security.Principal;

namespace BetterBuiltWorkoutsTest
{
    public class WorkoutControllerTests
    {

        public IWorkoutUnitOfWork GetUnitOfWork()
        {
            Exercise exercise = new Exercise();
            Exercise exercise1 = new Exercise();
            Exercise exercise2 = new Exercise();



            Plan plan = new Plan();
            plan.Exercises = new List<Exercise>();
            plan.Exercises.Add(exercise);
            plan.Exercises.Add(exercise1);
            plan.Exercises.Add(exercise2);


            ApplicationDbContext mockContext = new Mock<ApplicationDbContext>(new DbContextOptions<ApplicationDbContext>()).Object;

            Mock<Repository<Exercise>> mockExerciseRepository = new Mock<Repository<Exercise>>(mockContext);
            mockExerciseRepository.Setup(e => e.Insert(It.IsAny<Exercise>()));
            
         

            Mock<Repository<Plan>> mockPlanRepository = new Mock<Repository<Plan>>(mockContext);
            mockPlanRepository.Setup(e => e.Insert(It.IsAny<Plan>()));

            // Setup unit of work
            var unit = new Mock<IWorkoutUnitOfWork>();
            unit.Setup(e => e.GetPlan(It.IsAny<int>())).Returns(plan);
            unit.Setup(e => e.GetExercise(It.IsAny<int>())).Returns(new Exercise());
            unit.Setup(e => e.Exercises).Returns(mockExerciseRepository.Object);
            unit.Setup(e => e.Plans).Returns(mockPlanRepository.Object);



            return unit.Object;
        }

        public WorkoutController GetController()
        {
            var httpContext = new DefaultHttpContext();
            var tempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());
            var con = new WorkoutController(GetUnitOfWork())
            {
                TempData = tempData

            };
            con.ControllerContext.HttpContext = httpContext;
            con.ControllerContext.HttpContext.Session = new Mock<ISession>().Object;
            return con;
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
            PlanViewModel model = Assert.IsType<PlanViewModel>(vr.Model);
        }

        [Fact]
        public void PlanEditActionMethodPostInvalid_ModelIsAPlanModel_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            controller.ModelState.AddModelError("", "Test error message.");
            //ACT
            var result = controller.PlanEdit(1);
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result);
            PlanViewModel model = Assert.IsType<PlanViewModel>(vr.Model);
        }


        [Fact]
        public void PlanEditActionMethodPostValid_ReturnsRedirectToAction_Moq()
        {
            //ARRANGE
            var controller = GetController();

            PlanViewModel model = new PlanViewModel();
            model.PlanName = "Test";

            //ACT
            var result = controller.PlanEdit(model);
            //ASSERT
            RedirectToActionResult vr = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal(nameof(controller.PlanList), vr.ActionName);
        }

        [Fact] // Giving up on this one. Just can't make it work
        public void ExerciseListActionMethod_ModelIsAExerciseListViewModel_Moq()
        {
            //ARRANGE
            var controller = GetController();

            GridDTO grid = new GridDTO() { PageNumber = 1, PageSize = 2, FilterBy = "all" };
            //ACT
            var result = controller.ExerciseList(grid);
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result);
            ExerciseListViewModel model = Assert.IsType<ExerciseListViewModel>(vr.Model);
        }

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

        [Fact]
        public void DeleteActionMethod_ReturnsRedirectToAction_Moq()
        {
            //ARRANGE
            var controller = new WorkoutController(GetUnitOfWork());
            //ACT
            var result = controller.Delete(new Exercise());
            //ASSERT
            RedirectToActionResult vr = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal(nameof(controller.ExerciseList), vr.ActionName);
        }

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

        // This test is not quite working yet.
        [Fact]
        public void EditActionMethodPostValid_ReturnsRedirectToAction_Moq()
        {
            //ARRANGE
            var controller = GetController();
            Exercise model = new Exercise();
            model.Name = "Test";

            //ACT
            var result = controller.Edit(model);
            //ASSERT
            RedirectToActionResult vr = Assert.IsType<RedirectToActionResult>(result);
        }

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
