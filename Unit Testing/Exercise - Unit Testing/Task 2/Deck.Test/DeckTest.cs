namespace Deck.Test
{
    using System;
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTest
    {
        [Test]
        public void TestStaticConstrictorIf24CardsToCollectionOfCards()
        {
            //Arrange
            var deck = new Deck();

            //Act

            //Assert
            Assert.AreEqual(24, deck.CardsLeft);
        }

        [Test]
        public void TestDeckConstructorIfShuffleCorrectlyDeckAndChooseTrump()
        {
            //Arrange
            var deck = new Deck();
            for (int i = 0; i < 23; i++)
            {
                deck.GetNextCard();
            }

            var firstCard = deck.GetNextCard();

            //Act
            var trumpCard = deck.TrumpCard;

            //Assert
            Assert.AreEqual(firstCard, trumpCard);
        }

        [Test]
        public void TestDeckIfIsNotNull()
        {
            //Arramge
            var deck = new Deck();

            //Act

            //Assert
            Assert.IsNotNull(deck);
        }

        [Test]
        public void TestIfTrumpCardIsNotNull()
        {
            //Arrange
            var deck = new Deck();

            //Act
            var trumpCard = deck.TrumpCard;

            //Assert
            Assert.IsNotNull(trumpCard);
        }

        [Test]
        public void TestPropertyCardsLeftShouldReturnValidNumberOfCards()
        {
            //Arrange
            var deck = new Deck();
            var cardsNumberAfterOneCardGet = 23;
            
            //Act
            deck.GetNextCard();

            //Assert
            Assert.AreEqual(cardsNumberAfterOneCardGet, deck.CardsLeft);
        }

        [Test]
        public void TestGetNextCardShouldThrowExceptionWhenNoCardsLeft()
        {
            //Arrange
            var deck = new Deck();
            var numberOfCardsToGet = 24;

            //Act
            for (int i = 0; i < numberOfCardsToGet; i++)
            {
                deck.GetNextCard();
            }

            //Assert
            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(20)]
        public void TestGetNextCardShouldNotReturnNull(int getNextCard)
        {
            //Arrange
            var deck = new Deck();

            //Act
            for (int i = 0; i < getNextCard; i++)
            {
                deck.GetNextCard();
            }
            var nextCard = deck.GetNextCard();

            //Assert
            Assert.IsNotNull(nextCard);
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(20)]
        public void TestDeckCardsLeftShouldReturnValidNumberOfCardsInDeckWhenGetNextCardIsCalled(int getNextCard)
        {
            //Arrange
            var deck = new Deck();

            //Act
            for (int i = 0; i < getNextCard; i++)
            {
                deck.GetNextCard();
            }
            var actualCardsInDeck = deck.CardsLeft;
            var expectedCardsInDeck = 24 - getNextCard;

            //Assert
            Assert.AreEqual(expectedCardsInDeck, actualCardsInDeck);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(10)]
        [TestCase(20)]
        public void TestChangeTrumpCardShouldNotReturnNull(int getNewTrumpCard)
        {
            //Arrange
            var deck = new Deck();
            Card card = new Card(CardSuit.Club, CardType.Ace);

            //Act
            for (int i = 0; i < getNewTrumpCard; i++)
            {
                deck.ChangeTrumpCard(card);
            }

            //Assert
            Assert.AreEqual(deck.TrumpCard, card);
        }
    }
}
