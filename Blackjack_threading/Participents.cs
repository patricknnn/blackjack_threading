using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_threading
{
    public abstract class Participents
    {
        public int CardX { get; set; }
        public int CardY { get; set; }
 
        // Card holding by participent
        public List<Card> cardList = new List<Card>();

        public Participents(int X, int Y)
        {
            CardX = X;
            CardY = Y;
        }

        // method for returning sum of cards in cardlist
        public int SumCards()
        {
            int cardSum = 0;
            for (int i = 0; i < cardList.Count; i++)
            {
                cardSum += cardList[i].Value;
            }
            return cardSum;
        }
    }
}
