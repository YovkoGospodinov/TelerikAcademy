namespace Poker.Test
{
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class PokerHandsCheckerTest
    {
        [Test]
        [TestCase(1)]
        [TestCase(10)]
        public void IsValidHandShouldReturnFalseIfHandContainsLessOrMoreThanFiveCards(int numberOfCards)
        {
            // Arrange
            var cards = new List<ICard>();

            for (int i = 0; i < numberOfCards; i++)
            {
                cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            }
            var hand = new Hand(cards);
            var handChecker = new PokerHandsChecker();

            // Act and
            var result = handChecker.IsValidHand(hand);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidHandShouldReturnTrueIfHandContainsExactlyFiveCards()
        {
            // Arrange
            var firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var secondCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            var thirdCard = new Card(CardFace.Ace, CardSuit.Hearts);
            var fourthCard = new Card(CardFace.Ace, CardSuit.Spades);
            var fifthCard = new Card(CardFace.Eight, CardSuit.Diamonds);

            var cards = new List<ICard>()
            {
                firstCard,
                secondCard,
                thirdCard,
                fourthCard,
                fifthCard
            };

            var hand = new Hand(cards);
            var handChecker = new PokerHandsChecker();

            // Act
            var result = handChecker.IsValidHand(hand);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsValidHandShouldReturnFalseIfHandContainsSameCards()
        {
            // Arrange
            var firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var secondCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var thirdCard = new Card(CardFace.Ace, CardSuit.Hearts);
            var fourthCard = new Card(CardFace.Ace, CardSuit.Spades);
            var fifthCard = new Card(CardFace.Eight, CardSuit.Diamonds);

            var cards = new List<ICard>()
            {
                firstCard,
                secondCard,
                thirdCard,
                fourthCard,
                fifthCard
            };

            var hand = new Hand(cards);
            var handChecker = new PokerHandsChecker();

            // Act
            var result = handChecker.IsValidHand(hand);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidHandShouldReturnTrueIfHandContainsDifferentCards()
        {
            // Arrange
            var firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var secondCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            var thirdCard = new Card(CardFace.Ace, CardSuit.Hearts);
            var fourthCard = new Card(CardFace.Ace, CardSuit.Spades);
            var fifthCard = new Card(CardFace.Eight, CardSuit.Diamonds);

            var cards = new List<ICard>()
            {
                firstCard,
                secondCard,
                thirdCard,
                fourthCard,
                fifthCard
            };

            var hand = new Hand(cards);
            var handChecker = new PokerHandsChecker();

            // Act
            var result = handChecker.IsValidHand(hand);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsFlushShouldReturnTrueIfAllCardsHaveSameSuit()
        {
            // Arrange
            var firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var secondCard = new Card(CardFace.Jack, CardSuit.Clubs);
            var thirdCard = new Card(CardFace.Seven, CardSuit.Clubs);
            var fourthCard = new Card(CardFace.Nine, CardSuit.Clubs);
            var fifthCard = new Card(CardFace.Eight, CardSuit.Clubs);

            var cards = new List<ICard>()
            {
                firstCard,
                secondCard,
                thirdCard,
                fourthCard,
                fifthCard
            };

            var hand = new Hand(cards);
            var handChecker = new PokerHandsChecker();

            // Act
            var result = handChecker.IsFlush(hand);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsFlushShouldReturnFalseIfOneCardHasDifferentSuitThanTheOthers()
        {
            // Arrange
            var firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var secondCard = new Card(CardFace.Jack, CardSuit.Hearts);
            var thirdCard = new Card(CardFace.Seven, CardSuit.Clubs);
            var fourthCard = new Card(CardFace.Nine, CardSuit.Clubs);
            var fifthCard = new Card(CardFace.Eight, CardSuit.Clubs);

            var cards = new List<ICard>()
            {
                firstCard,
                secondCard,
                thirdCard,
                fourthCard,
                fifthCard
            };

            var hand = new Hand(cards);
            var handChecker = new PokerHandsChecker();

            // Act
            var result = handChecker.IsFlush(hand);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsFourOfAKindShouldReturnTrueIfFourOfTheCardsHasSameFace()
        {
            // Arrange
            var firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var secondCard = new Card(CardFace.Jack, CardSuit.Hearts);
            var thirdCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var fourthCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var fifthCard = new Card(CardFace.Ace, CardSuit.Clubs);

            var cards = new List<ICard>()
            {
                firstCard,
                secondCard,
                thirdCard,
                fourthCard,
                fifthCard
            };

            var hand = new Hand(cards);
            var handChecker = new PokerHandsChecker();

            // Act
            var result = handChecker.IsFourOfAKind(hand);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsFourOfAKindShouldReturnFalseIfLessThanFourOfTheCardsHasSameFace()
        {
            // Arrange
            var firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var secondCard = new Card(CardFace.Jack, CardSuit.Hearts);
            var thirdCard = new Card(CardFace.King, CardSuit.Clubs);
            var fourthCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var fifthCard = new Card(CardFace.Ace, CardSuit.Clubs);

            var cards = new List<ICard>()
            {
                firstCard,
                secondCard,
                thirdCard,
                fourthCard,
                fifthCard
            };

            var hand = new Hand(cards);
            var handChecker = new PokerHandsChecker();

            // Act
            var result = handChecker.IsFourOfAKind(hand);

            // Assert
            Assert.IsFalse(result);
        }
    }
}

