using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            var previousCard = hand.Cards[0];

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                var previousCardFace = previousCard.Face;
                var previousCardSuit = previousCard.Suit;
                var currentCardFace = hand.Cards[i].Face;
                var currentCardSuit = hand.Cards[i].Suit;

                if ((previousCardFace == currentCardFace) && (previousCardSuit == currentCardSuit))
                {
                    return false;
                }
                previousCard = hand.Cards[i];
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int numberOfSameFaceCards = 0;

            var previousCard = hand.Cards[0];
            var previousCardFace = previousCard.Face;

            foreach (var currentCard in hand.Cards)
            {
                if (currentCard.Face == previousCardFace)
                {
                    numberOfSameFaceCards++;
                }
            }

            if (numberOfSameFaceCards >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            var previousCard = hand.Cards[0];

            foreach (var currentCard in hand.Cards)
            {
                if (currentCard.Suit != previousCard.Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
