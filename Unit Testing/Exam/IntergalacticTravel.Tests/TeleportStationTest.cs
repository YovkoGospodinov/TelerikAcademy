namespace IntergalacticTravel.Tests
{
    using IntergalacticTravel.Contracts;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class TeleportStationTest
    {
        [Test]
        public void Constructor_ShouldSetUpAllFields_WhenNewTeleportStationIsCreatedWhithValidParameters()
        {
            // Arrange
            var expectedMockedOwner = new Mock<IBusinessOwner>();
            var mockedPath = new Mock<IPath>();
            var expectedmockedLocation = new Mock<ILocation>();
            var expectedgalacticMap = new List<IPath>();
            expectedgalacticMap.Add(mockedPath.Object);

            var expectedgalacticMap1 = new Mock<List<IPath>>();

            // Act
            var teleportStation = new TeleportStation(expectedMockedOwner.Object, expectedgalacticMap1.Object,
                expectedmockedLocation.Object);

            var wrapperTeleportStation = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(teleportStation);

            var actualResources = wrapperTeleportStation.GetField("resources");
            var actualOwner = wrapperTeleportStation.GetField("owner");
            var actualLocation = wrapperTeleportStation.GetField("location");
            var actualGalacticMap = wrapperTeleportStation.GetField("galacticMap");

            // Assert
            Assert.AreSame(expectedMockedOwner.Object, actualOwner);
            Assert.AreSame(expectedgalacticMap1.Object, actualGalacticMap);
            Assert.AreSame(expectedmockedLocation.Object, actualLocation);
        }

        [Test]
        public void
            TeleportUnit_ShouldThrowArgumentNullExceptionWhithAMessageThatContainsStringunittoteleport_WhenPassingAsNullUnitToTeleport
            ()
        {
            // Arrange
            var expectedMockedOwner = new Mock<IBusinessOwner>();
            var mockedPath = new Mock<IPath>();
            var expectedmockedLocation = new Mock<ILocation>();
            var expectedgalacticMap = new List<IPath>();
            expectedgalacticMap.Add(mockedPath.Object);

            var teleportStation = new TeleportStation(expectedMockedOwner.Object, expectedgalacticMap,
                expectedmockedLocation.Object);

            // Act and Assert
            var exception = Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(null, expectedmockedLocation.Object));

            StringAssert.Contains("unitToTeleport", exception.Message);
        }

        [Test]
        public void
            TeleportUnit_ShouldThrowArgumentNullExceptionWhithAMessageThatContainsStringdestination_WhenPassingAsNullLocationToTeleport
            ()
        {
            // Arrange
            var expectedMockedOwner = new Mock<IBusinessOwner>();
            var mockedPath = new Mock<IPath>();
            var expectedmockedLocation = new Mock<ILocation>();
            var expectedgalacticMap = new List<IPath>();
            expectedgalacticMap.Add(mockedPath.Object);
            var mockedUnit = new Mock<IUnit>();

            var teleportStation = new TeleportStation(expectedMockedOwner.Object, expectedgalacticMap,
                expectedmockedLocation.Object);

            // Act and Assert
            var exception = Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(mockedUnit.Object, null));

            StringAssert.Contains("destination", exception.Message);
        }
    }
}