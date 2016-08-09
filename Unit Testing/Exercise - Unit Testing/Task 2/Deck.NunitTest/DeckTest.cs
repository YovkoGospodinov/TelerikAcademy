namespace Deck.NunitTest
{
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTest
    {
        [Test]
        public void DeckConstructor_ShouldInitializeValidObjectOfTypeDeck()
        {
            // Arrange and Act
            var deckOfCards = new Deck();

            // Assert
            Assert.IsInstanceOf<Deck>(deckOfCards);
        }

        [Test]
        public void DeckConstructor_ShouldInitializeNotNullObject()
        {
            // Arrange and Act
            var deckOfCards = new Deck();

            // Assert
            Assert.IsNotNull(deckOfCards);
        }

        [Test]
        public void DeckConstructor_ShouldInitializeValidListOf24Cards()
        {
            // Arrange
            int expectedNumberOfCards = 24;

            // Act
            var deckofCard = new Deck();
            int actualNumberOfCards = deckofCard.CardsLeft;

            // Assert
            Assert.AreEqual(expectedNumberOfCards, actualNumberOfCards);
        }

        [Test]
        public void DeckConstructor_ShouldInitializeNotNullTrumpCard()
        {
            // Arrange
            var deckOfCards = new Deck();

            // Act
            var trumpCard = deckOfCards.TrumpCard;

            // Assert
            Assert.IsNotNull(trumpCard);
        }

        [Test]
        public void DeckConstructor_ShouldInitializeValidTrumpCardFromTypeCard()
        {
            // Arrange
            var deckOfCards = new Deck();

            // Act
            var trumpCard = deckOfCards.TrumpCard;

            // Assert
            Assert.IsInstanceOf<Card>(trumpCard);
        }

        [Test]
        [TestCase(3)]
        [TestCase(5)]
        public void PropertyCardsLeft_ShouldTurnValidNumberOfCardsInTheDeck(int cardsToGet)
        {
            // Arrange
            var deckOfCards = new Deck();
            var expectedNumberOfCards = 24 - cardsToGet;

            // Act
            for (int i = 0; i < cardsToGet; i++)
            {
                deckOfCards.GetNextCard();
            }
            var actualCardLeft = deckOfCards.CardsLeft;

            // Assert
            Assert.AreEqual(expectedNumberOfCards, actualCardLeft);
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        public void GetNextCard_ShouldReturnNotNullObject(int cardsToGet)
        {
            // Arrange
            var deckOfCards = new Deck();

            // Act and Assert
            for (int i = 0; i < cardsToGet; i++)
            {
                var currentCard = deckOfCards.GetNextCard();
                Assert.IsNotNull(currentCard);
            }
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        public void GetNextCard_ShouldReturnObjectFromTypeCard(int cardsToGet)
        {
            // Arrange
            var deckOfCards = new Deck();

            // Act and Assert
            for (int i = 0; i < cardsToGet; i++)
            {
                var currentCard = deckOfCards.GetNextCard();
                Assert.IsInstanceOf<Card>(currentCard);
            }
        }

        [Test]
        public void GetNextCard_ShouldTakeAndAvoidOnlyOneCardFromTheDeck_WhenMethodIsCalled()
        {
            // Arrange 
            var deckOfCards = new Deck();
            var expectedNumberOfCards = 23;

            // Act
            deckOfCards.GetNextCard();
            var actualNumberOfCards = deckOfCards.CardsLeft;

            // Assert
            Assert.AreEqual(expectedNumberOfCards, actualNumberOfCards);
        }

        [Test]
        public void GetNextCard_ShouldThrowInternalGameException_WhenThereIsNoCardLeftInTheDeck()
        {
            // Arrange
            var deckOfCards = new Deck();

            // Act
            for (int i = 0; i < 24; i++)
            {
                deckOfCards.GetNextCard();
            }

            // Assert
            Assert.Throws<InternalGameException>(() => deckOfCards.GetNextCard());
        }

        [Test]
        [TestCase(2)]
        [TestCase(10)]
        public void GetNextCard_ShouldReturnDifferentCards_WhenTheMethodIsCalled(int cardsToGet)
        {
            // Arrange
            var deckOfCards = new Deck();

            // Act
            var firstCard = deckOfCards.GetNextCard();
            for (int i = 0; i < cardsToGet; i++)
            {
                deckOfCards.GetNextCard();
            }
            var nthCard = deckOfCards.GetNextCard();

            // Assert
            Assert.AreNotEqual(firstCard, nthCard);
        }

        [Test]
        public void ChangeTrumpCard_ShouldReturnAsTrumpCardThePassedCardAssParameterToTheMethod()
        {
            // Arrange
            var expectedTrumpCard = new Card(CardSuit.Club, CardType.Ace);
            var deckOfCards = new Deck();

            // Act
            deckOfCards.ChangeTrumpCard(expectedTrumpCard);
            var actualTrumpCard = deckOfCards.TrumpCard;

            // Assert
            Assert.AreSame(expectedTrumpCard, actualTrumpCard);
        }
    }
}
