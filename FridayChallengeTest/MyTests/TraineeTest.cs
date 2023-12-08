using Friday_Challenge.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FridayChallengeTest.MyTests
{
    [TestFixture]
    public class TraineeTest
    {
        [Test]
        public void AddStudent_ShouldAddStudentSuccessfully_WhenCorrectNameIsPassed()
        {
            Trainee trainee = new Trainee();

            // Arrange
            
            // Act
            trainee.addStudent("John Wachira");

            // Assert
            Assert.That(trainee._studentList.Contains("John Wachira"), Is.EqualTo(true));
           
        }

        [Test]
        public void AddingDuplicateName_ShouldThrowAnError()
        {
            // Arrange
            Trainee trainee = new Trainee();
            trainee.addStudent("John Wachira");

            // Act and Assert
            Assert.That(() => trainee.addStudent("John Wachira"), Throws.InstanceOf<Exception>());
        }

        [Test]
        public void AddStudent_WithNullOrWhiteSpaceName_ShouldThrowAnError()
        {
            // Arrange
            Trainee trainee = new Trainee();

            // Act and Assert
            Assert.That(() => trainee.addStudent(null), Throws.InstanceOf<Exception>());
            Assert.That(() => trainee.addStudent(""), Throws.InstanceOf<Exception>());
            Assert.That(() => trainee.addStudent("   "), Throws.InstanceOf<Exception>());
                    }

        [Test]
        public void RemoveStudent_WithExistingName_ShouldRemoveStudent()
        {
            // Arrange
            Trainee trainee = new Trainee();
            trainee.addStudent("John Wachira");

            // Act
            trainee.removeStudent("John Wachira");

            // Assert
            Assert.That(trainee._studentList.Contains("John Wachira"), Is.EqualTo(false));
        }

        [Test]
        public void RemoveStudent_WithNonExistingName_ShouldThrowAnError()
        {
            // Arrange
            Trainee trainee = new Trainee();

            // Act and Assert
            Assert.That(() => trainee.removeStudent("Jo Wac"), Throws.InstanceOf<Exception>());
            
        }

        [Test]
        public void RemoveStudent_NullOrWhiteSpaceName_ShouldThrowAnError()
        {
            // Arrange
            Trainee trainee = new Trainee();

            // Act and Assert
            Assert.That(() => trainee.removeStudent(null), Throws.InstanceOf<Exception>());
            Assert.That(() => trainee.removeStudent(""), Throws.InstanceOf<Exception>());
            Assert.That(() => trainee.removeStudent("   "), Throws.InstanceOf<Exception>());
        }

        [Test]
        public void SearchStudent_ExistingName_ShouldReturnAName()
        {
            // Arrange
            Trainee trainee = new Trainee();
            trainee.addStudent("John Wachira");

            // Act
            string result = trainee.SearchStudent("John Wachira");

            // Assert
            Assert.That(result, Is.EqualTo("John Wachira"));
        }

        [Test]
        public void SearchStudent_NonExistingName_ShouldReturnEmptyString()
        {
            // Arrange
            Trainee trainee = new Trainee();

            // Act
            string result = trainee.SearchStudent("j  w");

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void SearchStudent_WithNullOrWhiteSpaceName_ShouldThrowAnError()
        {
            // Arrange
            Trainee trainee = new Trainee();

            // Act and Assert
  
            Assert.That(() => trainee.SearchStudent(null), Throws.InstanceOf<Exception>());
            Assert.That(() => trainee.SearchStudent(""), Throws.InstanceOf<Exception>());
            Assert.That(() => trainee.SearchStudent("   "), Throws.InstanceOf<Exception>());
        }
    }

}

