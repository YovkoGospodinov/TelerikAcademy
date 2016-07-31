using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            string result = String.Empty;

            for (int i = 0; i < this.Cards.Count; i++)
            {
                if (i != this.Cards.Count - 1)
                {
                    result += this.Cards[i].ToString() + " ";
                }
                else
                {
                    result += this.Cards[i].ToString();
                }
            }

            return result;
        }
    }
}
