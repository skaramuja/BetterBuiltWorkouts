using BetterBuiltWorkouts.Controllers;
using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;
using Moq;
using System.Collections.Generic;

namespace BetterBuiltWorkoutsTest
{
    public class WorkoutControllerTests
    {

        // I think I'm on to something here. I am able to call the mocked method ( I think ) Might be able to work this out....WILL BE!!!!!!


        //https://mariliisjaago.com/2021/04/19/mocking-with-xunit-and-moq/

        //public IWorkoutUnitOfWork GetUnitOfWork()
        public Exercise GetUnitOfWork()
        {
            // setup Exercise Repository
            var exerciseRepo = new Mock<IRepository<Exercise>>();
            exerciseRepo.Setup(e => e.GetOne(It.IsAny<QueryOptions<Exercise>>()))
                .Returns(new Exercise { ExercisePlans = new List<ExercisePlan>() });

            // setup Plan Repository
            //var planRepo = new Mock<IRepository<Plan>>();
            //planRepo.Setup(p => p.List).Returns(new List<Plan> { });


            // Setup unit of work
            //var unit = new Mock<IWorkoutUnitOfWork>();
            //unit.Setup(m => m.Exercises).Returns(new Exercise { ExercisePlans = new List<ExercisePlan>() });
            //unit.Setup(m => m.Plans).Returns(planRepo.Object);
            //return unit.Object;
            return exerciseRepo.Object.GetOne(new QueryOptions<Exercise> { });
        }


        [Fact]
        public void CreatePlanActionMethod_ReturnsAViewResult()
        {
            //var exerciseRepository = new FakeExerciseRepository();
            //var planRepository = new FakePlanRepository();
            //var exerciseTypeReposiotry = new FakeExerciseTypeReposiotry();
            //var controller = new WorkoutController(exerciseRepository, planRepository, exerciseTypeReposiotry);
            //var result = controller.CreatePlan();
            var exerciseRepo = new Mock<IRepository<Exercise>>();
            exerciseRepo.Setup(e => e.GetOne(It.IsAny<QueryOptions<Exercise>>()))
                .Returns(new Exercise { ExercisePlans = new List<ExercisePlan>() });

            // Setup unit of work
            var unit = new Mock<IWorkoutUnitOfWork>();
            unit.Setup(m => m.Exercises).Returns(exerciseRepo.Object);


            var controller = new WorkoutController((ApplicationDbContext)unit.Object);

            var result = controller.CreatePlan();

            Assert.IsType<ViewResult>(result);
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

        [Fact]
        public void PlanEditActionMethodGet_ReturnsAViewResult()
        {
            var repo = new Mock<IRepository<Plan>>();
        }
        
    }
}
