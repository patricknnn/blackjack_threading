using Blackjack_threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Blackjack
{
    class Deck
    {
        // Deck class generates 52 card deck
        public static List<Card> GenerateDeck()
        {
            List<Card> deck = new List<Card>()
            {
                    // spades
                    new Card() { Value  = 2, Name = "Two Spades", Image = @"CardImages/2S.png"},
                    new Card() { Value = 3, Name = "Three Spades", Image = @"CardImages/3S.png"},
                    new Card() { Value = 4, Name =  "Four Spades", Image = @"CardImages/4S.png"},
                    new Card() { Value = 5, Name = "Five Spades", Image = @"CardImages/5S.png" },
                    new Card() { Value = 6, Name = "Six Spades", Image = @"CardImages/6S.png" },
                    new Card() { Value = 7, Name = "Seven Spades", Image = @"CardImages/7S.png" },
                    new Card() { Value = 8, Name = "Eight Spades", Image = @"CardImages/8S.png" },
                    new Card() { Value = 9, Name = "Nine Spades", Image = @"CardImages/9S.png" },
                    new Card() { Value = 10, Name = "Ten Spades", Image = @"CardImages/10S.png" },
                    new Card() { Value = 10, Name = "Jack Spades", Image = @"CardImages/JS.png" },
                    new Card() { Value = 10, Name = "Queen Spades", Image = @"CardImages/QS.png" },
                    new Card() { Value = 10, Name = "King Spades", Image = @"CardImages/KS.png" },
                    new Card() { Value = 11, Name = "Ace Spades", Image = @"CardImages/AS.png" },

                    // diamonds
                    new Card() { Value  = 2, Name = "Two Diamonds", Image = @"CardImages/2D.png" },
                    new Card() { Value = 3, Name = "Three Diamonds", Image = @"CardImages/3D.png" },
                    new Card() { Value = 4, Name =  "Four Diamonds", Image = @"CardImages/4D.png"},
                    new Card() { Value = 5, Name = "Five Diamonds", Image = @"CardImages/5D.png" },
                    new Card() { Value = 6, Name = "Six Diamonds", Image = @"CardImages/6D.png" },
                    new Card() { Value = 7, Name = "Seven Diamonds", Image = @"CardImages/7D.png" },
                    new Card() { Value = 8, Name = "Eight Diamonds", Image = @"CardImages/8D.png" },
                    new Card() { Value = 9, Name = "Nine Diamonds", Image = @"CardImages/9D.png" },
                    new Card() { Value = 10, Name = "Ten Diamonds", Image = @"CardImages/10D.png" },
                    new Card() { Value = 10, Name = "Jack Diamonds", Image = @"CardImages/JD.png" },
                    new Card() { Value = 10, Name = "Queen Diamonds", Image = @"CardImages/QD.png" },
                    new Card() { Value = 10, Name = "King Diamonds", Image = @"CardImages/KD.png" },
                    new Card() { Value = 11, Name = "Ace Diamonds", Image = @"CardImages/AD.png" },

                    // clubs
                    new Card() { Value  = 2, Name = "Two Clubs", Image = @"CardImages/2C.png" },
                    new Card() { Value = 3, Name = "Three Clubs", Image = @"CardImages/3C.png" },
                    new Card() { Value = 4, Name =  "Four Clubs", Image = @"CardImages/4C.png"},
                    new Card() { Value = 5, Name = "Five Clubs", Image = @"CardImages/5C.png" },
                    new Card() { Value = 6, Name = "Six Clubs", Image = @"CardImages/6C.png" },
                    new Card() { Value = 7, Name = "Seven Clubs", Image = @"CardImages/7C.png" },
                    new Card() { Value = 8, Name = "Eight Clubs", Image = @"CardImages/8C.png" },
                    new Card() { Value = 9, Name = "Nine Clubs", Image= @"CardImages/9C.png" },
                    new Card() { Value = 10, Name = "Ten Clubs", Image = @"CardImages/10C.png" },
                    new Card() { Value = 10, Name = "Jack Clubs", Image = @"CardImages/JC.png" },
                    new Card() { Value = 10, Name = "Queen Clubs", Image = @"CardImages/QC.png" },
                    new Card() { Value = 10, Name = "King Clubs", Image = @"CardImages/KC.png" },
                    new Card() { Value = 11, Name = "Ace Clubs", Image = @"CardImages/AC.png" },

                    // Hearts
                    new Card() { Value  = 2, Name = "Two Hearts", Image = @"CardImages/2H.png" },
                    new Card() { Value = 3, Name = "Three Hearts", Image = @"CardImages/3H.png" },
                    new Card() { Value = 4, Name =  "Four Hearts", Image = @"CardImages/4H.png"},
                    new Card() { Value = 5, Name = "Five Hearts", Image = @"CardImages/5H.png" },
                    new Card() { Value = 6, Name = "Six Hearts", Image = @"CardImages/6H.png" },
                    new Card() { Value = 7, Name = "Seven Hearts", Image = @"CardImages/7H.png" },
                    new Card() { Value = 8, Name = "Eight Hearts", Image = @"CardImages/8H.png" },
                    new Card() { Value = 9, Name = "Nine Hearts", Image = @"CardImages/9H.png" },
                    new Card() { Value = 10, Name = "Ten Hearts", Image = @"CardImages/10H.png" },
                    new Card() { Value = 10, Name = "Jack Hearts", Image = @"CardImages/JH.png" },
                    new Card() { Value = 10, Name = "Queen Hearts", Image = @"CardImages/QH.png" },
                    new Card() { Value = 10, Name = "King Hearts", Image = @"CardImages/KH.png" },
                    new Card() { Value = 11, Name = "Ace Hearts", Image = @"CardImages/AH.png" }
            };
            return deck;
        }
    }
}