namespace StudentAndCourses.TestNunit
{
    using _01.StudentsAndCourses;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void StudentConstructor_ShouldInitializeValidObjectDifferentThanNull()
        {
            // Arrange
            var name = "John";
            var id = "13231";

            //  Act 
            var student = new Student(name, id);

            // Assert
            Assert.IsNotNull(student);
        }

        [Test]
        public void StudentConstructor_ShouldInitializeValidObjectInstanceOfSchoolClass()
        {
            // Arrange
            var name = "John";
            var id = "13231";

            //  Act 
            var student = new Student(name, id);

            // Assert
            Assert.IsInstanceOf(typeof(Student), student);
            Assert.IsInstanceOf<Student>(student);
        }

        [Test]
        public void PropertyName_ShouldInitializeNameCorectly_WhenPassingValidParameter()
        {
            // Arrange
            var expectedName = "John";
            var id = "13231";

            //  Act 
            var student = new Student(expectedName, id);
            var actualName = student.Name;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        [TestCase(null, "12345")]
        [TestCase("", "13231")]
        public void PropertyName_ShouldThrowArgumentOutOfRangeException_WhenPassingNull(string name, string id)
        {
            // Arrange
            string studentName = null;
            var studentId = id;
            
            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Student(studentName, studentId));
        }

        [Test]
        public void PropertyId_ShouldInitializeIdCorectly_WhenPassingValidParameter()
        {
            // Arrange
            var mame = "John";
            var expectedId = "13231";

            //  Act 
            var student = new Student(mame, expectedId);
            var actualId = student.Id;

            // Assert
            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
        [TestCase("Ivan", "123")]
        [TestCase("Gosho", "1234565678")]
        public void PropertyID_ShouldThrowArgumentOutOfRangeException_WhenPassingInvalidParameter(string name, string id)
        {
            // Arrange
            string studentName = name;
            string studentId = id;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Student(studentName, studentId));
        }
    }
}
