using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Blackjack_threading
{
    class Player
    {
        // Player class holds information of players.
        private int cardSum;
        public string Name { get; set; }
        
        // generate a cardlist for player
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
