using BetterBuiltWorkouts.Controllers;
using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using Xunit;

namespace BetterBuiltWorkoutsTest
{
    public class HomeControllerTests
    {
        private HomeController _controller;
        public HomeControllerTests()
        {
            _controller = new HomeController();
        }
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {

            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        public void Dispose()
        {
            _controller = null;
        }
    }
}
