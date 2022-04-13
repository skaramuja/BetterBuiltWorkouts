using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using BetterBuiltWorkouts.Data;
using Microsoft.EntityFrameworkCore;

namespace BetterBuiltWorkoutsTest.Evan
{
    public class WorkoutUoWTest
    {
        public WorkoutUoWTest() { }

        [Fact]
        public void ExerciseRepository_InMemory()
        {
            // Use an In-Memory DbContext. You can also use other types that won't do anything. Google
            //this to see what other options you need;
            DbContextOptions<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>()
                //NuGet: Microsoft.EntityFrameworkCore.InMemory
                .UseInMemoryDatabase("DbName").Options;

            var appDb = new ApplicationDbContext(options);
            var uow = new WorkoutUnitOfWork(appDb);
            //Using the In-Memory database it will create the Repositories as you would expect
            var repo = uow.Exercises;
            Assert.NotNull(repo);
        }
    }
}
