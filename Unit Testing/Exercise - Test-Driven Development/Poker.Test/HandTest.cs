using System;

namespace Poker.Test
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void HandToStringShouldReturnValidPresentationOfHandOfCards()
        {
            // Arrange
            var firstCard = new Card(CardFace.Ace, CardSuit.Clubs);
            var secondCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            var thirdCard = new Card(CardFace.Ace, CardSuit.Hearts);
            var fourthCard = new Card(CardFace.Ace, CardSuit.Spades);
            var fifthCard = new Card(CardFace.Eight, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>()
            {
                firstCard,
                secondCard,
                thirdCard,
                fourthCard,
                fifthCard
            };
            var hand = new Hand(cards);
            var expectedResult = $"{firstCard.Face}{firstCard.Suit} {secondCard.Face}{secondCard.Suit} {thirdCard.Face}{thirdCard.Suit} {fourthCard.Face}{fourthCard.Suit} {fifthCard.Face}{fifthCard.Suit}";

            // Act
            var actualResult = hand.ToString();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void HandToStringShouldReturnEmptyStringWhenThereIsNoCardsInHand()
        {
            // Arrange
            IList<ICard> cards = new List<ICard>(){};
            var hand = new Hand(cards);
            var expectedResult = String.Empty;

            // Act
            var actualResult = hand.ToString();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}