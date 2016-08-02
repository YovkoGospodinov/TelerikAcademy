namespace Cosmetics.Test
{
    using Cosmetics.Engine;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void ParseShouldReturnNewCommandWhenInputStringIsInValidFormat()
        {
            Assert.IsInstanceOf(typeof(Command), Command.Parse("some string"));
        }

        [Test]
        public void ParseShouldSetCorrectValueToThePropertyNameOfTheNewlyCreateObjectWhenInputStringIsValid()
        {
            // Arrange
            var expectedName = "some";

            // Act
            var actualName = Command.Parse("some string").Name;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void ParseShouldSetCorrectValueToThePropertyParametersOfTheNewlyCreateObjectWhenInputStringIsValid()
        {
            // Arrange
            IList<string> expectedParameters = new List<string>()
            {
                "string",
                "value"
            };

            // Act
            var actualParameters = Command.Parse("some string value").Parameters;

            // Assert
            Assert.AreEqual(expectedParameters, actualParameters);
        }

        [Test]
        public void ParseShouldThrowArgumentNullExceptionWhenTheInputStringThatRepresentCommandNameIsEmpty()
        {
            // Arrange
            string expectedName = String.Empty;

            // Act and Assert
            var exception = Assert.Throws<ArgumentNullException>(() => Command.Parse(expectedName));
            StringAssert.Contains("Name", exception.Message);
        }

        [Test]
        public void ParseShouldThrowArgumentNullExceptionWhenTheInputStringThatRepresentCommandNameIsNull()
        {
            // Arrange
            string expectedName = null;

            // Act and Assert
            var exception = Assert.Throws<NullReferenceException>(() => Command.Parse(expectedName));
        }

        [Test]
        public void ParseShouldThrowArgumentNullExceptionWhenTheInputStringThatRepresentCommandParametersIsNull()
        {
            // Arrange
            var input = $"{"name"} {null}";

            // Act
            var exception = Assert.Throws<ArgumentNullException>(() => Command.Parse(input));

            // Assert
            StringAssert.Contains("List", exception.Message);
        }

        [Test]
        public void ParseShouldThrowArgumentNullExceptionWhenTheInputStringThatRepresentCommandParametersIsEmpty()
        {
            // Arrange
            var input = $"{"name"} {String.Empty}";

            // Act
            var exception = Assert.Throws<ArgumentNullException>(() => Command.Parse(input));

            // Assert
            StringAssert.Contains("List", exception.Message);
        }
    }
}