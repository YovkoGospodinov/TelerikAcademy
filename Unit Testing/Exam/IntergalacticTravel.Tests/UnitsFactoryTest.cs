namespace IntergalacticTravel.Tests
{
    using IntergalacticTravel.Exceptions;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class UnitsFactoryTest
    {
        [Test]
        [TestCase("create unit Procyon Gosho 1", typeof(Procyon))]
        [TestCase("create unit Luyten Pesho 2", typeof(Luyten))]
        [TestCase("create unit Lacaille Tosho 3", typeof(Lacaille))]
        public void GetUnit_ShouldReturnValidTypeOfUnit_WhenValidCorrespondingCommandIsPassed(string command, Type type)
        {
            // Arrange
            string enteredCommand = command;
            var unitFactory = new UnitsFactory();
            var expectedUnitType = type;

            // Act
            var actualUnitType = unitFactory.GetUnit(enteredCommand);

            // Assert
            Assert.IsInstanceOf(expectedUnitType, actualUnitType);
        }

        //Another way to test which is very similar but just incase and to keep to the problem description I am writing the next three tests.
        [Test]
        public void GetUnit_ShouldReturnValidUnitOfTypeProcyon_WhenValidCorrespondingCommandIsPassed()
        {
            // Arrange
            string command = "create unit Procyon Gosho 1";
            var unitFactory = new UnitsFactory();

            // Act
            var unit = unitFactory.GetUnit(command);

            // Assert
            Assert.IsInstanceOf<Procyon>(unit);
        }

        [Test]
        public void GetUnit_ShouldReturnValidUnitOfTypeLuyten_WhenValidCorrespondingCommandIsPassed()
        {
            // Arrange
            string command = "create unit Luyten Pesho 2";
            var unitFactory = new UnitsFactory();

            // Act
            var unit = unitFactory.GetUnit(command);

            // Assert
            Assert.IsInstanceOf<Luyten>(unit);
        }

        [Test]
        public void GetUnit_ShouldReturnValidUnitOfTypeLacaille_WhenValidCorrespondingCommandIsPassed()
        {
            // Arrange
            string command = "create unit Lacaille Tosho 3";
            var unitFactory = new UnitsFactory();

            // Act
            var unit = unitFactory.GetUnit(command);

            // Assert
            Assert.IsInstanceOf<Lacaille>(unit);
        }

        [Test]
        [TestCase("create unit procyon Gosho 1")] //test the case sensitive type of unit
        [TestCase("create unit luyten Pesho 2")]
        [TestCase("create unit lacaille Tosho 3")]
        [TestCase("create unit Marsianec Gosho 1")] //test with non-existing type of unit
        [TestCase("create unit Procyon Gosho one")] // test with passing invalid Id number
        public void GetUnit_ShouldThrowInvalidUnitCreationCommandException_WhenThePassedCommandIsNotInTheValidFormat(string command)
        {
            // Arrange
            string enteredCommand = command;
            var unitFactory = new UnitsFactory();

            // Act and Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => unitFactory.GetUnit(enteredCommand));
        }
    }
}