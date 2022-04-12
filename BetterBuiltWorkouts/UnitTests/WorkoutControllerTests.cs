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

        // Artical reference
        //https://mariliisjaago.com/2021/04/19/mocking-with-xunit-and-moq/

        public IWorkoutUnitOfWork GetUnitOfWork()
        {
            // setup Exercise Repository
            var exerciseRepo = new Mock<IRepository<Exercise>>();
            exerciseRepo.Setup(e => e.Get(It.IsAny<int>()))
                .Returns(new Exercise { ExerciseId = 1, Name = "Test Exercise" });

            // setup Plan Repository
            var planRepo = new Mock<IRepository<Plan>>();
            planRepo.Setup(e => e.Get(It.IsAny<QueryOptions<Plan>>()))
                .Returns(new Plan { PlanId = 1, Name = "Plan one" });
       

            // Setup unit of work
            var unit = new Mock<IWorkoutUnitOfWork>();
            unit.Setup(m => m.Exercises).Returns(exerciseRepo.Object); // I have no idea why this doesn't work. This looks to be 
            unit.Setup(m => m.Plans).Returns(planRepo.Object);         // exactally what the book is showing. 
            return unit.Object;

        }

        [Fact]
        public void DetailsActionMethod_ModelIsANExerciseObject()
        {
            //ARRANGE
            var exerciseRepo = new Mock<IRepository<Exercise>>();
            exerciseRepo.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(new Exercise());
            var unit = new Mock<IWorkoutUnitOfWork>();
            unit.Setup(m => m.Exercises).Returns(exerciseRepo.Object); // Trying to do the same type of thing as the GetUnitOfWork but having the same issues.
            var controller = new WorkoutController(unit.Object);
            //ACT
            var result = controller.Details(1).ViewData.Model as Exercise; // This was also listed in the book but might not be understanding how this works (or doesn't work)

            Assert.IsType<ActionResult>(result); // Also confused by this. 

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
