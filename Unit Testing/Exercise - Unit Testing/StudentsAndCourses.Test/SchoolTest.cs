namespace StudentsAndCourses.Test
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _01.StudentsAndCourses;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void TestShouldInitializeSchoolCorrectly()
        {
            //Arrange
            var courses = new List<Course>();
            var students = new List<Student>();

            //Act
            var school = new School();

            //Assert
            CollectionAssert.AreEquivalent(courses, school.Courses);
            CollectionAssert.AreEquivalent(students, school.Students);
        }
    }
}