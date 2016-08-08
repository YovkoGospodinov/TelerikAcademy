namespace StudentAndCourses.TestNunit
{
    using _01.StudentsAndCourses;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class CourseTest
    {
        [Test]
        public void ConstructorCourse_ShouldInitializeValidObject()
        {
            // Act
            var course = new Course();

            // Assert
            Assert.IsInstanceOf<Course>(course);
        }

        [Test]
        public void ConstructorCourse_ShouldInitializeObjectDifferentThanNull()
        {
            // Act
            var course = new Course();

            // Assert
            Assert.IsNotNull(course);
        }

        [Test]
        public void PropertyStudents_ShouldReturnValidCollectionOfStudents_WhenGetMethodIsCalled()
        {
            // Arrange
            var course = new Course();
            var expectedStudents = new List<Student>();

            // Act
            var actualStudents = course.Students;

            // Assert
            Assert.AreEqual(expectedStudents, actualStudents);
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void AddStudents_ShouldAddStudentCorrectlyAndIncreasingThereCountInCollection(int numberOfStudentToAdd)
        {
            // Arrange
            var course = new Course();
            var expectedStudentsCount = numberOfStudentToAdd;

            
            // Act
            for (int i = 0; i < numberOfStudentToAdd; i++)
            {
                var currentStudent = new Student(i.ToString(), (i.ToString() + "1234"));
                course.AddStudent(currentStudent);
            }
            var actualStudentsCount = course.Students.Count;

            // Assert
            Assert.AreEqual(expectedStudentsCount, actualStudentsCount);
        }

        [Test]
        public void AddStudents_ShouldThrowArgumentOutOfRangeException_WhenAddStudentMethodAddMoreThanMaxCapacityOfTheCourse()
        {
            // Arrange
            var course = new Course();
            var currentStudent = new Student("Ivan", "12345");

            // Act and Assert
            for (int i = 0; i < 30; i++)
            {
                course.AddStudent(currentStudent);
            }

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => course.AddStudent(currentStudent));
        }

        [Test]
        public void RemoveStudents_ShouldRemoveStudentAndWillChangeNumberOfStudentsInCollection()
        {
            // Arrange
            var course = new Course();
            var firstStudent = new Student("Ivan", "12345");
            var secondStudent = new Student("Gosho", "12346");
            var expectedCount = 1;

            course.AddStudent(firstStudent);
            course.AddStudent(secondStudent);

            // Act
            course.RemoveStudent(firstStudent);
            var actualCount = course.Students.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemoveStudent_ShouldThrowInvalidOperationException_WhenRemovingNotExistingInTheCollectionStudent()
        {
            // Arrange
            var course = new Course();
            var firstStudent = new Student("Ivan", "12345");
            var secondStudent = new Student("Gosho", "12346");
            var thirdStudent = new Student("Pesho", "02346");
            course.AddStudent(firstStudent);
            course.AddStudent(secondStudent);

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => course.RemoveStudent(thirdStudent));
        }
    }
}