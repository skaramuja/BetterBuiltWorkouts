using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.Controllers
{
    public class WorkoutController : Controller
    {
        [Route("Create-Workout")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("Perform-Workout")]
        public IActionResult Perform()
        {
            return View();
        }
    }
}
