using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using BetterBuiltWorkouts.Evan;
using BetterBuiltWorkouts.Models;
using BetterBuiltWorkouts.Data;

namespace BetterBuiltWorkoutsTest.Evan
{
    public class UOWTester
    {
        public UOWTester() { }

        [Fact]
        public void TestRepository_Fake()
        {
            Mock<IDataStore> store = new Mock<IDataStore>();
            store.Setup(s => s.Exercises).Returns(new FakeExerciseRepository());
            store.Setup(s => s.Plans).Returns(new FakePlanRepository());
            store.Setup(s => s.ExerciseTypes).Returns(new FakeExerciseTypeReposiotry());
            // FYI: You need to make sure all these fakes actually return the right type of data

            var uow = new UOW(store.Object);
            // Now you can do all your tests
        }
        [Fact]
        public void TestRepository_Mock()
        {
            Mock<IRepository<Exercise>> repo_exercise = new Mock<IRepository<Exercise>>();
            Mock<IRepository<Plan>> repo_plan = new Mock<IRepository<Plan>>();
            Mock<IRepository<ExerciseType>> repo_type = new Mock<IRepository<ExerciseType>>();
            Mock<IDataStore> store = new Mock<IDataStore>();
            store.Setup(s => s.Exercises).Returns(repo_exercise.Object);
            store.Setup(s => s.Plans).Returns(repo_plan.Object);
            store.Setup(s => s.ExerciseTypes).Returns(repo_type.Object);
            // FYI: You need to make sure all these fakes actually return the right type of data

            var uow = new UOW(store.Object);
            // Now you can do all your tests

        }
    }
}
