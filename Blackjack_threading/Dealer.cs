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

        public void Deal(List<Card> deck, Participents participant)
        {
            Card card = deck[0];
            participant.cardList.Add(card);
            deck.RemoveAt(0);
        }
    }
}