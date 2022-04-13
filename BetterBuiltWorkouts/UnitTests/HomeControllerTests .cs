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
using Microsoft.Extensions.Logging;

namespace BetterBuiltWorkoutsTest
{
    public class HomeControllerTests
    {
        private readonly ILogger<HomeController> _logger;
 

        public IWorkoutUnitOfWork GetUnitOfWork()
        {
            // Setup unit of work
            var unit = new Mock<IWorkoutUnitOfWork>();
            unit.Setup(e => e.GetPlan(It.IsAny<int>())).Returns(new Plan());
            unit.Setup(e => e.GetExercise(It.IsAny<int>())).Returns(new Exercise());
            return unit.Object;
        }


        [Fact]
        public void IndexActionMethod_ReturnsAViewResult_Moq()
        {
            //ARRANGE
            var controller = new HomeController(_logger);
            //ACT
            var result = controller.Index();
            //ASSERT
            ViewResult vr = Assert.IsType<ViewResult>(result);
        }


    }
}
