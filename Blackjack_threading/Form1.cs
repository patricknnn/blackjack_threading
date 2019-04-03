using Blackjack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Blackjack_threading
{
    public partial class Form1 : Form
    {
        // Create a player and a dealer instance
        Dealer dealer = new Dealer();
        Player player1 = new Player() { Name = "Player 1" };
        Player player2 = new Player() { Name = "Player 2" };
        
        // Create new random
        Random random = new Random();
        
        // generated list for used cards to they are not used twice
        List<int> usedCards = new List<int>();
        
        // generate deck
        List<Card> deck = Deck.GenerateDeck();

        // Initialize form1
        public Form1()
        {
            InitializeComponent();
        }

        // resetGame() on load
        private void Form1_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        // Handles deal button click
        private void dealButton_Click(object sender, EventArgs e)
        {
            dealButton.Enabled = false;
            hitButtonPlayer1.Enabled = true;
            standButtonPlayer1.Enabled = true;
            if (player1.sumCards() > 0)
            {
                resultLabel.Text = String.Format("Click Reset if you want to restart.");
            }

            else
            {
                // Deal dealer
                DealDealer();
                // Deal player
                DealPlayers();
                // check dealer cards for dead or Blackjack
                if (dealer.sumCards() > 21)
                {
                    resultLabel.Text = String.Format("The sum of the dealers cards is: {0}, Dealer dead! You win! Click Reset", dealer.sumCards());
                }
                else if (dealer.sumCards() == 21)
                {
                    resultLabel.Text = String.Format("Blackjack!, Dealer wins!");
                }
                else
                {
                    // dealer no blackjack or dead so continue
                    // check player cards for dead or blackjack
                    if (player1.sumCards() > 21)
                    {
                        resultLabel.Text = String.Format("The sum of {0} cards is: {1}, you lose! Click Reset", player1.Name, player1.sumCards());
                    }
                    else if (player1.sumCards() == 21)
                    {
                        resultLabel.Text = String.Format("Blackjack!, {0} wins!", player1.Name);
                    }
                    else
                    {
                        resultLabel.Text = String.Format("The sum of {0} cards is: {1}", player1.Name, player1.sumCards());
                    }
                }
            }
        }

        // handles hit button click for player 1
        private void hitButton_Click(object sender, EventArgs e)
        {
            if (player1.sumCards() == 0)
            {
                resultLabel.Text = "You need to deal first!";
                displayCardBack(pictureBoxPlayer1Hit);
            }
            // player sumcards is not 0, so continue
            else
            {
                if (player1.sumCards() > 21)
                {
                    resultLabel.Text = "Game is over, reset to restart!";
                }
                else if (player1.sumCards() == 21 || dealer.sumCards() == 21)
                {
                    resultLabel.Text = "Game is over, reset to restart!";
                }
                else
                {
                    int randomCard = selectRandomCard();
                    Card card = deck[randomCard];
                    usedCards.Add(randomCard);

                    if (usedCards.Contains(randomCard)) randomCard = selectRandomCard();
                    else randomCard = 1 * randomCard;

                    pictureBoxPlayer1Hit.ImageLocation = card.Image;
                    player1.cardList.Add(card);
                    if (player1.sumCards() > 21)
                    {
                        resultLabel.Text = String.Format("The sum of {0} cards is: {1}, you lose! Click Reset", player1.Name, player1.sumCards());
                    }
                    else if (player1.sumCards() == 21)
                    {
                        resultLabel.Text = String.Format("BlackJack!, you win!");
                    }
                    else
                    {
                        resultLabel.Text = String.Format("The sum of {0} cards is: {1}", player1.Name, player1.sumCards());
                    }
                }
            }
        }

        // handles hitbutton click for player 2
        private void hitButtonPlayer2_Click(object sender, EventArgs e)
        {
            //
        }

        // Handles stand button click
        private void standButton_Click(object sender, EventArgs e)
        {
            hitButtonPlayer1.Enabled = false;
            standButtonPlayer1.Enabled = false;
            dealButton.Enabled = false;
            if (player1.sumCards() == 0)
            {
                resultLabel.Text = "Click the Deal button...";
                displayCardBack(pictureBoxPlayer1Hit);
            }
            else
            {
                if (player1.sumCards() > 21)
                {
                    resultLabel.Text = "You lost.";
                }
                else
                {
                    // player stands with cards so dealers turn to beat his hand
                    Card dealercard1 = dealer.cardList[0];
                    pictureBoxDealerHand1.ImageLocation = dealercard1.Image;
                    while (dealer.sumCards() < player1.sumCards())
                    {
                        // dealer draws card
                        int randomDealerCard = selectRandomCard();
                        Card dealerCard = deck[randomDealerCard];
                        usedCards.Add(randomDealerCard);
                        dealer.cardList.Add(dealerCard);
                        // dealer card is shown
                        pictureBoxDealerHit.ImageLocation = dealerCard.Image;
                    }
                    if (dealer.sumCards() == player1.sumCards())
                    {
                        resultLabel.Text = String.Format("The sum of dealer cards is: {0}, it's a tie!", dealer.sumCards());
                    }
                    else if (dealer.sumCards() > 21)
                    {
                        resultLabel.Text = String.Format("The sum of dealer cards is: {0}, dealer lost! You win! Click Reset", dealer.sumCards());
                    }
                    else if (dealer.sumCards() == 21)
                    {
                        resultLabel.Text = String.Format("BlackJack!, dealer wins!");
                    }
                    else if (dealer.sumCards() > player1.sumCards() && dealer.sumCards() < 21)
                    {
                        resultLabel.Text = String.Format("The sum of dealer cards is: {0}, dealer wins!", dealer.sumCards());
                    }
                }
            }
        }

        // handles stand button for player 2
        private void standButtonPlayer2_Click(object sender, EventArgs e)
        {

        }

        // handles reset button
        private void resetButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        // resets the game
        private void resetGame()
        {
            resultLabel.Text = null;
            displayCardBack(pictureBoxPlayer1Hand1);
            displayCardBack(pictureBoxPlayer1Hand2);
            displayCardBack(pictureBoxPlayer2Hand1);
            displayCardBack(pictureBoxPlayer2Hand2);
            displayCardBack(pictureBoxPlayer1Hit);
            displayCardBack(pictureBoxPlayer2Hit);
            displayCardBack(pictureBoxDealerHand1);
            displayCardBack(pictureBoxDealerHand2);
            displayCardBack(pictureBoxDealerHit);
            player1.cardList.Clear();
            dealer.cardList.Clear();
            usedCards.Clear();
            hitButtonPlayer1.Enabled = false;
            standButtonPlayer1.Enabled = false;
            dealButton.Enabled = true;
            resultLabel.Text = "Click Deal when ready";
        }

        // Deals a hand to the dealer
        private void DealDealer()
        {
            //DEALER DRAWS 2 CARD, 1 FACED DOWN AND 1 FACED UP
            displayCardBack(pictureBoxDealerHit);
            // draw dealer card 1
            int randomDealerCard1 = selectRandomCard();
            Card dealerCard1 = deck[randomDealerCard1];
            usedCards.Add(randomDealerCard1);
            // draw dealer card 2
            int randomDealerCard2 = selectRandomCard();
            if (randomDealerCard1 == randomDealerCard2) selectRandomCard();
            else randomDealerCard2 = 1 * randomDealerCard2;
            Card dealerCard2 = deck[randomDealerCard2];
            usedCards.Add(randomDealerCard2);
            // add cards to cardlist of dealer
            dealer.cardList.Add(dealerCard1);
            dealer.cardList.Add(dealerCard2);
            // first dealer card is not shown
            displayCardBack(pictureBoxDealerHand1);
            // second dealer card is shown
            pictureBoxDealerHand2.ImageLocation = dealerCard2.Image;
        }

        // Deals a hand to the player
        private void DealPlayers()
        {
            // hit cards face down
            displayCardBack(pictureBoxPlayer1Hit);
            displayCardBack(pictureBoxPlayer2Hit);
            
            // draw player 1 random card 1
            int randomCard1 = selectRandomCard();
            Card card1 = deck[randomCard1];
            // save random card 1 in used cards
            usedCards.Add(randomCard1);
            
            // draw player 1 random card 2
            int randomCard2 = selectRandomCard();
            if (randomCard1 == randomCard2) selectRandomCard();
            else randomCard2 = 1 * randomCard2;
            // save random card 2 in used cards
            Card card2 = deck[randomCard2];
            usedCards.Add(randomCard2);

            // draw player 2 random card 1
            int randomCard3 = selectRandomCard();
            Card card3 = deck[randomCard3];
            // save random card 1 in used cards
            usedCards.Add(randomCard3);

            // draw player 2 random card 2
            int randomCard4 = selectRandomCard();
            if (randomCard3 == randomCard4) selectRandomCard();
            else randomCard4 = 1 * randomCard4;
            // save random card 2 in used cards
            Card card4 = deck[randomCard4];
            usedCards.Add(randomCard4);

            // add cards to cardlist
            player1.cardList.Add(card1);
            player1.cardList.Add(card2);
            player2.cardList.Add(card3);
            player2.cardList.Add(card4);

            // show cards
            pictureBoxPlayer1Hand1.ImageLocation = card1.Image;
            pictureBoxPlayer1Hand2.ImageLocation = card2.Image;
            pictureBoxPlayer2Hand1.ImageLocation = card3.Image;
            pictureBoxPlayer2Hand2.ImageLocation = card4.Image;
        }

        // function for selecting random card
        private int selectRandomCard()
        {
            int randomCard;
            randomCard = random.Next(0, deck.Count);
            return randomCard;
        }

        // function to display back of card
        private void displayCardBack(PictureBox picturebox)
        {
            picturebox.ImageLocation = @"CardImages/red_back.png";
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
    }
}
