using Blackjack;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Blackjack_threading
{
    public class Engine
    {
        public static Enums.GameStates State { get; set; }

        private Dealer dealer = new Dealer(472, 62);

        // Create array with dealer and players
        private Participents[] players = {
            new Player(129, 365) { Name = "Player 1" },
            new Player(687, 365) { Name = "Player 2" }
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
        }


        public void Render()
        {
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
               gui.InvokeRenderCard(dealer.CardX, dealer.CardY, dealer.cardList[0].Image );

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
    }
}
