namespace Poker.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class CardTest
    {
        [Test]
        [TestCase(CardFace.Ace, CardSuit.Clubs)]
        [TestCase(CardFace.King, CardSuit.Hearts)]
        [TestCase(CardFace.Queen, CardSuit.Spades)]
        [TestCase(CardFace.Jack, CardSuit.Diamonds)]
        public void CardToStringShouldReturnValidCardPresentation(CardFace cardFace, CardSuit cardSuit)
        {
            // Arrange
            var card = new Card(cardFace, cardSuit);

            // Act
            var actualResult = card.ToString();
            var expectedResult = $"{cardFace}{cardSuit}";

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
