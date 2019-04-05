﻿using Blackjack;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Blackjack_threading
{
    public class Engine
    {
        public static Enums.GameStates State { get; set; }

        // Create dealer
        private Dealer dealer = new Dealer(472, 62);

        // Create array with players
        private Participents[] players = {
            new Player(129, 365) { Name = "player1" },
            new Player(687, 365) { Name = "player2" }
        };

        public void Load()
        {
            State = Enums.GameStates.ResetGame;
            // Create a thread object, passing in the Update method
            var gameThread = new Thread(GameLoop);

            // Start the game thread
            gameThread.Start();
        }

        private GUI gui;

        public Engine(GUI gui)
        {
            this.gui = gui;
            Load();
        }

        // generate deck
        private List<Card> deck = new List<Card>();

        private void GameLoop()
        {
            while (true)
            {
                Update();
                Render();
                Thread.Sleep(16);
            }
        }

        public void Update()
        {
            // NEW GAME
            if (State == Enums.GameStates.ResetGame)
            {
                // reset game
                ResetGame();

                // generate deck
                deck = Deck.GenerateDeck();
                dealer.Shuffle(deck);

                dealer.Deal(deck, dealer);
                dealer.Deal(deck, dealer);
                dealer.Deal(deck, players[0]);
                dealer.Deal(deck, players[0]);
                dealer.Deal(deck, players[1]);
                dealer.Deal(deck, players[1]);
            }

            // UPDATE GAME
            if (State == Enums.GameStates.UpdateGame)
            {
                CheckForBust();
                CheckForBlackjack();
            }

            if (State == Enums.GameStates.StartGame)
            {
                CheckForBust();
                CheckForBlackjack();
            }

        }


        public void Render()
        {
            // NEW GAME
            if (State == Enums.GameStates.ResetGame)
            {
                gui.DrawResetGame();
                State = Enums.GameStates.Wait;
            }

            if (State == Enums.GameStates.RestartGame)
            {
                gui.Result();
            }

            if (State == Enums.GameStates.StartGame)
            {
                gui.DrawStartGame();

                // Draw dealer cards on start game, first card faced down
                gui.InvokeRenderCard(dealer.CardX, dealer.CardY, dealer.Cardback);
                gui.InvokeRenderCard(dealer.CardX + 30, dealer.CardY, dealer.cardList[1].Image);
                // Draw player 1 cards
                gui.InvokeRenderCard(players[0].CardX, players[0].CardY, players[0].cardList[0].Image);
                gui.InvokeRenderCard(players[0].CardX + 30, players[0].CardY, players[0].cardList[1].Image);
                // Draw player 2 cards
                gui.InvokeRenderCard(players[1].CardX, players[1].CardY, players[1].cardList[0].Image);
                gui.InvokeRenderCard(players[1].CardX + 30, players[1].CardY, players[1].cardList[1].Image);

                State = Enums.GameStates.Wait;
            }

            // UPDATE GAME
            if (State == Enums.GameStates.UpdateGame)
            {
                // draw hit cards if any for players
                foreach (Participents player in players)
                {
                    if (player.cardList.Count > 2)
                    {
                        for (int x = 2; x < player.cardList.Count; x++)
                        {
                            gui.InvokeRenderCard(player.CardX + 30 * x, player.CardY, player.cardList[x].Image);
                        }
                    }
                }

                // draw hit cards if any for dealer
                if (dealer.cardList.Count > 2)
                {
                    for (int x = 2; x < dealer.cardList.Count; x++)
                    {
                        gui.InvokeRenderCard(dealer.CardX + 30 * x, dealer.CardY, dealer.cardList[x].Image);
                    }
                }

                // wait
                State = Enums.GameStates.Wait;
            }
        }

        // resets the game
        private void ResetGame()
        {
            players[0].cardList.Clear();
            players[1].cardList.Clear();
            dealer.cardList.Clear();
        }

        private void DetermineWinner()
        {
            int dealerScore = dealer.SumCards();
            int player1score = players[0].SumCards();
            int player2score = players[1].SumCards();

            // if both players dead, dealer wins
            if (player1score > 21 && player2score > 21 && dealerScore < 21)
            {
                gui.IsWinner(dealer);
            }
            // dealer dead
            if (dealerScore > 21 && player2score < 21 && player1score < 21)
            {
                if (player1score > player2score)
                {
                    gui.IsWinner(players[0]);
                }
                else
                {
                    gui.IsWinner(players[1]);
                }
            }
            // all below 21, highest wins
            if (player1score < 21 && player2score < 21 && dealerScore < 21)
            {
                if (player1score > player2score && player1score > dealerScore)
                {
                    gui.IsWinner(players[0]);
                }
                else if (player2score > player1score && player2score > dealerScore)
                {
                    gui.IsWinner(players[1]);
                }
                else
                {
                    gui.IsWinner(dealer);
                }
            }
            // player 1 dead, 2 is not
            if (dealerScore < 21 && player1score > 21 && player2score < 21)
            {
                if (dealerScore > player2score)
                {
                    gui.IsWinner(dealer);
                }
                else
                {
                    gui.IsWinner(players[1]);
                }
            }
            // player 2 dead, 1 is not
            if (dealerScore < 21 && player2score > 21 && player1score < 21)
            {
                if (dealerScore > player1score)
                {
                    gui.IsWinner(dealer);
                }
                else
                {
                    gui.IsWinner(players[0]);
                }
            }
        }

        private void CheckForBust()
        {
            // check values of all hands for bust
            foreach (Participents player in players)
            {
                if (player.SumCards() > 21)
                {
                    gui.BustPlayer(player);
                }
            }
            if (dealer.SumCards() > 21)
            {
                gui.BustPlayer(dealer);
            }
        }

        private void CheckForBlackjack()
        {
            // check values of all hands for blackjack
            foreach (Participents player in players)
            {
                if (player.SumCards() == 21)
                {
                    gui.IsWinner(player);
                }
            }
            if (dealer.SumCards() == 21)
            {
                gui.IsWinner(dealer);
            }
        }

        // Draws card for given player
        public void DrawCard(string player)
        {
            if (player == "dealer")
            {
                dealer.Deal(deck, dealer);
            }
            else if (player == "player1")
            {
                dealer.Deal(deck, players[0]);
            }
            else if (player == "player2")
            {
                dealer.Deal(deck, players[1]);
            }
        }

        public int GetCardCount(string player)
        {
            if (player == "dealer")
            {
                return dealer.SumCards();
            }
            else if (player == "player1")
            {
                return players[0].SumCards();
            }
            else if (player == "player2")
            {
                return players[1].SumCards();
            }
            else
            {
                return 0;
            }
        }

    }
}
