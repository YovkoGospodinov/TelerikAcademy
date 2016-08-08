namespace StudentAndCourses.TestNunit
{
    using _01.StudentsAndCourses;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class SchoolTest
    {
        [Test]
        public void SchoolConstructor_ShouldInitializeValidObjectSchoool()
        {
            // Act
            var school = new School();

            // Assert
            Assert.IsInstanceOf<School>(school);
        }

        [Test]
        public void SchoolConstructor_ShouldInitializeValidObjectSchooolNotNull()
        {
            // Act
            var school = new School();

            // Assert
            Assert.IsNotNull(school);
        }

        [Test]
        public void SchoolConstructor_ShouldIntiliazeObjectCorrectly_CheckingWithCoursesProperty()
        {
            // Arrange
            var expectedCourses = new List<Course>();

            // Act
            var school = new School();
            var actualCourses = school.Courses;

            // Assert
            Assert.AreEqual(expectedCourses, actualCourses);
        }

        [Test]
        public void SchoolConstructor_ShouldIntiliazeObjectCorrectly_CheckingWithStudentsProperty()
        {
            // Arrange
            var expectedStudents = new List<Student>();

            // Act
            var school = new School();
            var actualStudents = school.Students;

            // Assert
            Assert.AreEqual(expectedStudents, actualStudents);
        }
    }
}
