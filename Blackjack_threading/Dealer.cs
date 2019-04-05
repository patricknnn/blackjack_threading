using System;
using System.Collections.Generic;

namespace Blackjack_threading
{
    public class Dealer : Participents
    {
        public string Cardback { get; }


        public Dealer(int X, int Y) : base( X,  Y)
        {
            Cardback = @"CardImages/red_back.png";
        }

        public void Shuffle(List<Card> deck)
        {
            deck.Shuffle();
        }

        public void Deal(List<Card> deck, Participents player)
        {
            Card card = deck[0];
            player.cardList.Add(card);
            deck.RemoveAt(0);
        }
    }
}