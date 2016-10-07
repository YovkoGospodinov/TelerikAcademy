namespace IntergalacticTravel.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ResourcesFactoryTest
    {
        [Test]
        [TestCase("create resources gold(20) silver(30) bronze(40)", 20U, 30U, 40U)]
        [TestCase("create resources gold(20) bronze(40) silver(30)", 20U, 30U, 40U)]
        [TestCase("create resources silver(30) bronze(40) gold(20)", 20U, 30U, 40U)]
        [TestCase("create resources silver(30) gold(20) bronze(40)", 20U, 30U, 40U)]
        [TestCase("create resources bronze(40) gold(20) silver(30)", 20U, 30U, 40U)]
        [TestCase("create resources bronze(40) silver(30) gold(20)", 20U, 30U, 40U)]
        public void
            GetResources_ShouldReturnANewlyCreatedResourcesObjectWithCorrectlySetUpPropertiesNoMatterTheOrder_WhenInputStringIsInCorrectFormat
            (string command, uint gold, uint silver, uint bronze)
        {
            // Arrange
            string enteredCommand = command;
            uint expectedGoldCoins = gold;
            uint expectedSilverCoins = silver;
            uint expectedBronzeCoins = bronze;
            var resourcesFactory = new ResourcesFactory();

            // Act
            var resource = resourcesFactory.GetResources(enteredCommand);
            var actualGoldCoins = resource.GoldCoins;
            var actualSilverCoins = resource.SilverCoins;
            var actualBronzeCoins = resource.BronzeCoins;

            // Assert
            Assert.AreEqual(expectedGoldCoins, actualGoldCoins);
            Assert.AreEqual(expectedSilverCoins, actualSilverCoins);
            Assert.AreEqual(expectedBronzeCoins, actualBronzeCoins);
        }

        [Test]
        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand")]
        public void
            GetResources_ShouldThrowInvalidOperationExceptionWhickContainsStringCommand_WhenTheInputStringRepresentInvalidCommand
            (string command)
        {
            // Arrange
            string enteredCommand = command;
            var resourcesFactory = new ResourcesFactory();
            string expectedStringInException = "command";
            
            // Act and Assert
            var exception = Assert.Throws<InvalidOperationException>(() => resourcesFactory.GetResources(enteredCommand));

            StringAssert.Contains(expectedStringInException, exception.Message);
        }

        [Test]
        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void
            GetResources_ShouldThrowOverflowException_WhenTheInputStringCommandIsInTheCorrectFormatButAnyOfTheValuesAmountIsLargerThanUintMaxValue
            (string command)
        {
            // Arrange
            string enteredCommand = command;
            var resourcesFactory = new ResourcesFactory();

            // Act and Assert
            var exception = Assert.Throws<OverflowException>(() => resourcesFactory.GetResources(enteredCommand));
        }
    }
}