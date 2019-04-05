using Blackjack;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Blackjack_threading
{
    public partial class Form1 : Form
    {
        private Enums.GameStates state = Enums.GameStates.ResetGame;
        private Enums.Turn turn = Enums.Turn.Player1;

        // Create a player and a dealer instance
        private Dealer dealer = new Dealer();
        private Player player1 = new Player() { Name = "Player 1" };
        private Player player2 = new Player() { Name = "Player 2" };

        // Create new random
        private Random random = new Random();

        // generated list for used cards to they are not used twice
        private List<int> usedCards = new List<int>();

        // generate deck
        private List<Card> deck = new List<Card>();

        // Initialize form1
        public Form1()
        {
            InitializeComponent();

        }


        private void GameLoop()
        {
            while (true)
            {
                // NEW GAME
                if (state == Enums.GameStates.ResetGame)
                {
                    // reset game
                    ResetGame();

                    // generate deck
                    deck = Deck.GenerateDeck();
                    dealer.Shuffle(deck);

                    dealer.Deal(deck, dealer);
                    dealer.Deal(deck, dealer);
                    dealer.Deal(deck, player1);
                    dealer.Deal(deck, player1);
                    dealer.Deal(deck, player2);
                    dealer.Deal(deck, player2);

                    
                    // when done, chage state to start
                    state = Enums.GameStates.StartGame;
                }

                // START GAME
                if (turn == Enums.Turn.Dealer)
                {
                    //// Deal dealer
                    //DealDealer();
                    //// Deal player
                    //DealPlayers();
                    state = Enums.GameStates.Wait;
                }
            }
        }


        private void RenderLoop()
        {
            while (true)
            {
                if (state == Enums.GameStates.ResetGame)
                {
                    DrawResetGame();
                }

                if (state == Enums.GameStates.RestartGame)
                {
                    resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "Game is over, reset to restart!"; }));
                }

                if(state == Enums.GameStates.StartGame)
                {
                    RenderCard(null, pictureBoxDealerHand1);
                    RenderCard(dealer.cardList[dealer.cardList.Count - 1], pictureBoxDealerHand2);
                    RenderCard(player1.cardList[player1.cardList.Count - 2], pictureBoxPlayer1Hand1);
                    RenderCard(player1.cardList[player1.cardList.Count - 1], pictureBoxPlayer1Hand2);
                    RenderCard(player2.cardList[player2.cardList.Count - 2], pictureBoxPlayer2Hand1);
                    RenderCard(player2.cardList[player2.cardList.Count - 1], pictureBoxPlayer2Hand2);

                    state = Enums.GameStates.Wait;
                }

                //if(state == Enums.GameStates.Start)
                //{
                //    // check dealer cards for dead or Blackjack
                //    if (dealer.sumCards() > 21)
                //    {
                //        resultLabel.Text = String.Format("The sum of the dealers cards is: {0}, Dealer dead! You win! Click Reset", dealer.sumCards());
                //    }
                //    else if (dealer.sumCards() == 21)
                //    {
                //        resultLabel.Text = String.Format("Blackjack!, Dealer wins!");
                //    }
                //    else
                //    {
                //        // dealer no blackjack or dead so continue
                //        // check player cards for dead or blackjack
                //        if (player1.sumCards() > 21)
                //        {
                //            resultLabel.Text = String.Format("The sum of {0} cards is: {1}, you lose! Click Reset", player1.Name, player1.sumCards());
                //        }
                //        else if (player1.sumCards() == 21)
                //        {
                //            resultLabel.Text = String.Format("Blackjack!, {0} wins!", player1.Name);
                //        }
                //        else
                //        {
                //            resultLabel.Text = String.Format("The sum of {0} cards is: {1}", player1.Name, player1.sumCards());
                //        }
                //    }
                //}
            }
        }

        // resets the game

        private void ResetGame()
        {
            player1.cardList.Clear();
            player2.cardList.Clear();
            dealer.cardList.Clear();
        }

        private void DrawResetGame()
        {
            hitButtonPlayer1.Invoke(new Action(delegate () { hitButtonPlayer1.Enabled = false; }));
            hitButtonPlayer2.Invoke(new Action(delegate () { hitButtonPlayer2.Enabled = false; }));
            standButtonPlayer1.Invoke(new Action(delegate () { standButtonPlayer1.Enabled = false; }));
            standButtonPlayer2.Invoke(new Action(delegate () { standButtonPlayer2.Enabled = false; }));
            dealButton.Invoke(new Action(delegate () { dealButton.Enabled = false; }));
            resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "Click Deal when ready"; }));
        }

        // onLoad change state to newGame
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a thread object, passing in the GameLoop method
            var gameThread = new Thread(GameLoop);

            // Start the game thread
            gameThread.Start();

            // Create a thread object, passing in the GameLoop method
            var renderThread = new Thread(RenderLoop);

            // Start the render thread
            renderThread.Start();
        }

        // Handles deal button click
        private void dealButton_Click(object sender, EventArgs e)
        {
            dealButton.Enabled = false;
            hitButtonPlayer1.Enabled = true;
            hitButtonPlayer2.Enabled = false;
            standButtonPlayer1.Enabled = true;
            standButtonPlayer2.Enabled = false;
            if (player1.SumCards() > 0)
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
                if (dealer.SumCards() > 21)
                {
                    resultLabel.Text = String.Format("The sum of the dealers cards is: {0}, Dealer dead! You win! Click Reset", dealer.SumCards());
                }
                else if (dealer.SumCards() == 21)
                {
                    resultLabel.Text = String.Format("Blackjack!, Dealer wins!");
                }
                else
                {
                    // dealer no blackjack or dead so continue
                    // check player cards for dead or blackjack
                    if (player1.SumCards() > 21)
                    {
                        resultLabel.Text = String.Format("The sum of {0} cards is: {1}, you lose! Click Reset", player1.Name, player1.SumCards());
                    }
                    else if (player1.SumCards() == 21)
                    {
                        resultLabel.Text = String.Format("Blackjack!, {0} wins!", player1.Name);
                    }
                    else
                    {
                        resultLabel.Text = String.Format("The sum of {0} cards is: {1}", player1.Name, player1.SumCards());
                    }
                }
            }
        }

        // handles hit button click for player 1
        private void hitButton_Click(object sender, EventArgs e)
        {
            if (player1.SumCards() == 0)
            {
                resultLabel.Text = "You need to deal first!";
                RenderCard(null, pictureBoxPlayer1Hit);
            }
            // player sumcards is not 0, so continue
            else
            {
                if (player1.SumCards() >= 21 || dealer.SumCards() >= 21)
                {
                    state = Enums.GameStates.RestartGame;
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
                    if (player1.SumCards() > 21)
                    {
                        resultLabel.Text = String.Format("The sum of {0} cards is: {1}, you lose! Click Reset", player1.Name, player1.SumCards());
                    }
                    else if (player1.SumCards() == 21)
                    {
                        resultLabel.Text = String.Format("BlackJack!, you win!");
                    }
                    else
                    {
                        resultLabel.Text = String.Format("The sum of {0} cards is: {1}", player1.Name, player1.SumCards());
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
            if (player1.SumCards() == 0)
            {
                resultLabel.Text = "Click the Deal button...";
                RenderCard(null, pictureBoxPlayer1Hit);
            }
            else
            {
                if (player1.SumCards() > 21)
                {
                    resultLabel.Text = "You lost.";
                }
                else
                {
                    // player stands with cards so dealers turn to beat his hand
                    Card dealercard1 = dealer.cardList[0];
                    pictureBoxDealerHand1.ImageLocation = dealercard1.Image;
                    while (dealer.SumCards() < player1.SumCards())
                    {
                        // dealer draws card
                        int randomDealerCard = selectRandomCard();
                        Card dealerCard = deck[randomDealerCard];
                        usedCards.Add(randomDealerCard);
                        dealer.cardList.Add(dealerCard);
                        // dealer card is shown
                        pictureBoxDealerHit.ImageLocation = dealerCard.Image;
                    }
                    if (dealer.SumCards() == player1.SumCards())
                    {
                        resultLabel.Text = String.Format("The sum of dealer cards is: {0}, it's a tie!", dealer.SumCards());
                    }
                    else if (dealer.SumCards() > 21)
                    {
                        resultLabel.Text = String.Format("The sum of dealer cards is: {0}, dealer lost! You win! Click Reset", dealer.SumCards());
                    }
                    else if (dealer.SumCards() == 21)
                    {
                        resultLabel.Text = String.Format("BlackJack!, dealer wins!");
                    }
                    else if (dealer.SumCards() > player1.SumCards() && dealer.SumCards() < 21)
                    {
                        resultLabel.Text = String.Format("The sum of dealer cards is: {0}, dealer wins!", dealer.SumCards());
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
            state = Enums.GameStates.ResetGame;
        }

        private void DealCard()
        {

        }

        // Deals a hand to the dealer
        private void DealDealer()
        {
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
            RenderCard(null, pictureBoxDealerHand1);
            // render cards
            //RenderCard(dealerCard1, pictureBoxDealerHand1);
            RenderCard(dealerCard2, pictureBoxDealerHand2);
            // second dealer card is shown
            RenderCard(null, pictureBoxDealerHit);
        }

        private void RenderCard(Card card, PictureBox box)
        {
            if (card != null)
            {
                box.Invoke(new MethodInvoker(delegate () {box.ImageLocation = card.Image;}));
            }
            else
            {
                box.Invoke(new MethodInvoker(delegate () { box.ImageLocation = @"CardImages/red_back.png"; }));
            }

        }

        // Deals a hand to the player
        private void DealPlayers()
        {
            // hit cards face down
            RenderCard(null, pictureBoxPlayer1Hit);
            RenderCard(null, pictureBoxPlayer2Hit);

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
    }
}
