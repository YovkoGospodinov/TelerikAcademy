namespace StudentsAndCourses.Test
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _01.StudentsAndCourses;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestShouldInitializeCourseCorrectly()
        {
            //Arrange
            var students = new List<Student>();

            //Act
            var school = new School();

            //Assert
            CollectionAssert.AreEquivalent(students, school.Students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestShouldThrowExceptionWhenStudentInCourseBecameMoreThanMaxStudentNumberInCourse()
        {
            //Arrange
            var studentsNumber = 31;
            var course = new Course();

            //Act
            for (int i = 0; i < studentsNumber; i++)
            {
                var student = new Student(i.ToString(), i.ToString());
                course.AddStudent(student);
            }

            //Using MSTestExtensions
            //ThrowsAssert.Throws<ArgumentOutOfRangeException>(() => course.AddStudent(student));
        }

        [TestMethod]
        public void TestShouldCheckIfMethodAddStudentToCourse()
        {
            //Arrange
            var course = new Course();
            var expectedNumberOfStudentsInCours = 1; 

            //Act
            course.AddStudent(new Student("Ivan", "12345"));

            //Assert
            Assert.AreEqual(expectedNumberOfStudentsInCours, course.Students.Count);
        }

        [TestMethod]
        public void TestShouldCheckIfMethodRemoveStudentFromCourse()
        {
            //Arrange
            var course = new Course();
            var expectedNumberOfStudentsInCours = 1;
            var firstStudent = new Student("Ivan", "12345");
            var secondStudent = new Student("Gosho", "12346");

            //Act
            course.AddStudent(firstStudent);
            course.AddStudent(secondStudent);
            course.RemoveStudent(firstStudent);


            //Assert
            Assert.AreEqual(expectedNumberOfStudentsInCours, course.Students.Count);
        }
    }
}