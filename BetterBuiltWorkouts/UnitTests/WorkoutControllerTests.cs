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

namespace BetterBuiltWorkoutsTest
{
    public class WorkoutControllerTests
    {

        // Article reference
        //https://mariliisjaago.com/2021/04/19/mocking-with-xunit-and-moq/

        public IWorkoutUnitOfWork GetUnitOfWork()
        {
       

            // Setup unit of work
            var unit = new Mock<IWorkoutUnitOfWork>();
            unit.Setup(e => e.GetExercise(It.IsAny<int>())).Returns(new Exercise());
            return unit.Object;

        }

        [Fact]
        public void DetailsActionMethod_ModelIsANExerciseObject()
        {
            //ARRANGE

            var controller = new WorkoutController(GetUnitOfWork());
            //ACT
            var result = controller.Details(1);
            ViewResult vr = Assert.IsType<ViewResult>(result); // Also confused by this. 
            Exercise model = Assert.IsType<Exercise>(vr.Model);
        }


        [Fact]
        public void CreatePlanActionMethod_ReturnsAViewResult() // This was what Sabina used to test with some fake repos. These work but I'm trying to use the unit of work instead with no luck.
        {
            //var exerciseRepository = new FakeExerciseRepository();
            //var planRepository = new FakePlanRepository();
            //var exerciseTypeReposiotry = new FakeExerciseTypeReposiotry();
            //var controller = new WorkoutController(exerciseRepository, planRepository, exerciseTypeReposiotry);
            //var result = controller.CreatePlan();
            //var exerciseRepo = new Mock<IRepository<Exercise>>();
            //exerciseRepo.Setup(e => e.GetOne(It.IsAny<QueryOptions<Exercise>>()))
            //    .Returns(new Exercise { ExercisePlans = new List<ExercisePlan>() });

            //// Setup unit of work
            //var unit = new Mock<IWorkoutUnitOfWork>();
            //unit.Setup(m => m.Exercises).Returns(exerciseRepo.Object);


            //var controller = new WorkoutController((ApplicationDbContext)unit.Object);

            //var result = controller.CreatePlan();

            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlanDetailsActionMethod_ReturnsAViewResult()
        {
            //var exerciseRepository = new FakeExerciseRepository();
            //var planRepository = new FakePlanRepository();
            //var exerciseTypeReposiotry = new FakeExerciseTypeReposiotry();
            //var controller = new WorkoutController(exerciseRepository, planRepository, exerciseTypeReposiotry);
            //var result = controller.PlanDetails(4);
            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlanDeleteActionMethod_ReturnsAViewResult()
        {
            //var exerciseRepository = new FakeExerciseRepository();
            //var planRepository = new FakePlanRepository();
            //var exerciseTypeReposiotry = new FakeExerciseTypeReposiotry();
            //var controller = new WorkoutController(exerciseRepository, planRepository, exerciseTypeReposiotry);
            //var result = controller.PlanDelete(new Plan());
            //Assert.IsType<RedirectToActionResult>(result);
        }

        
    }
}
