namespace StudentsAndCourses.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _01.StudentsAndCourses;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestShouldInitializeStudentWithValidParameters()
        {
            //Arrange
            var name = "Ivan";
            var id = "12345";

            //Act
            var student = new Student(name, id);

            //Assert
            Assert.AreEqual(name, student.Name);
            Assert.AreEqual(id, student.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestShouldThrowExceptionWhenInvalidNameIsPassed()
        {
            //Arrange
            var name = "";
            var id = "12345";

            //Act
            var student = new Student(name, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestShouldThrowExceptionWhenInvalidIdIsPassed()
        {
            //Arrange
            var name = "Id";
            var id = "123";

            //Act
            var student = new Student(name, id);
        }
    }
}
