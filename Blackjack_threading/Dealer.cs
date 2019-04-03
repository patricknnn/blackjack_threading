using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Blackjack_threading
{
    class Dealer
    {
        // Dealer class holds information of dealer.
        private int cardSum;

        // Create cardlist for dealer
        public List<Card> cardList = new List<Card>()
        {
            new Card() { Value  = 0, Name = "null", Image = null }
        };

        // method for returning sum of cards in cardlist
        public int sumCards()
        {
            cardSum = 0;
            for (int i = 0; i < cardList.Count; i++)
            {
                cardSum += cardList[i].Value;
            }
            return cardSum;
        }
    }
}