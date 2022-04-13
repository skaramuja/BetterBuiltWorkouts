using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using BetterBuiltWorkouts.Data;
using BetterBuiltWorkouts.Controllers;
using Microsoft.AspNetCore.Mvc;
using BetterBuiltWorkouts.Models;

namespace BetterBuiltWorkoutsTest.Evan
{
    public class WorkoutContrlTest
    {
        public WorkoutContrlTest() { }

        /*
         * NOTE: I am not testing the UnitOfWork here. I am only testing the controller
         * so I am not worried about the Repositories
         */

        [Fact]
        public void Details_ModelIsAnExerciseObject_Moq()
        {
            //Arrange
            Mock<IWorkoutUnitOfWork> uow = new Mock<IWorkoutUnitOfWork>();
            uow.Setup(u => u.GetExercise(It.IsAny<int>())).Returns(new Exercise()); //Mock the GetExercise(int) method to return your data
            uow.Setup(u => u.GetExerciseType(It.IsAny<string>())).Returns(new ExerciseType()); //Mock GetExerciseType
            uow.Setup(u => u.ListAllExerciseTypes()).Returns(new List<ExerciseType>()); //Mock ListAllExerciseTypes
            
            
            var controller = new WorkoutController(uow.Object);


            //Act
            var result = controller.Details(1);

            //Assert
            ViewResult iar = Assert.IsType<ViewResult>(result); //NOTE: Don't use an Interface. Use the actual class
            Exercise model = Assert.IsType<Exercise>(iar.Model);


        }
    }
}
