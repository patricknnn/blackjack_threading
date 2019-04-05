using Blackjack;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Blackjack_threading
{
    public partial class GUI : Form
    {
        //Engine
        Engine engine;

        // generate deck
        private List<Card> deck = new List<Card>();

        // Initialize form1
        public GUI()
        {
            InitializeComponent();
            engine = new Engine(this);
        }

        public void DrawResetGame()
        {
            dealButton.Invoke(new Action(delegate () { dealButton.Enabled = true; }));
            hitButtonPlayer1.Invoke(new Action(delegate () { hitButtonPlayer1.Enabled = false; }));
            hitButtonPlayer2.Invoke(new Action(delegate () { hitButtonPlayer2.Enabled = false; }));
            standButtonPlayer1.Invoke(new Action(delegate () { standButtonPlayer1.Enabled = false; }));
            standButtonPlayer2.Invoke(new Action(delegate () { standButtonPlayer2.Enabled = false; }));
            resetButton.Invoke(new Action(delegate () { resetButton.Enabled = false; }));
            resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "Click Deal when ready"; }));
        }

        public void DrawStartGame()
        {
            hitButtonPlayer1.Invoke(new Action(delegate () { hitButtonPlayer1.Enabled = true; }));
            hitButtonPlayer2.Invoke(new Action(delegate () { hitButtonPlayer2.Enabled = false; }));
            standButtonPlayer1.Invoke(new Action(delegate () { standButtonPlayer1.Enabled = true; }));
            standButtonPlayer2.Invoke(new Action(delegate () { standButtonPlayer2.Enabled = false; }));
            resetButton.Invoke(new Action(delegate () { resetButton.Enabled = true; }));
            resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "Player 1 is playing"; }));
        }

        public void DrawPlayer2Turn()
        {
            hitButtonPlayer1.Invoke(new Action(delegate () { hitButtonPlayer1.Enabled = false; }));
            hitButtonPlayer2.Invoke(new Action(delegate () { hitButtonPlayer2.Enabled = true; }));
            standButtonPlayer1.Invoke(new Action(delegate () { standButtonPlayer1.Enabled = false; }));
            standButtonPlayer2.Invoke(new Action(delegate () { standButtonPlayer2.Enabled = true; }));
            resetButton.Invoke(new Action(delegate () { resetButton.Enabled = true; }));
            resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "Player 2 is playing"; }));
        }

        public void DrawEndGame()
        {
            dealButton.Invoke(new Action(delegate () { dealButton.Enabled = false; }));
            resetButton.Invoke(new Action(delegate () { resetButton.Enabled = true; }));
            hitButtonPlayer1.Invoke(new Action(delegate () { hitButtonPlayer1.Enabled = false; }));
            hitButtonPlayer2.Invoke(new Action(delegate () { hitButtonPlayer2.Enabled = false; }));
            standButtonPlayer1.Invoke(new Action(delegate () { standButtonPlayer1.Enabled = false; }));
            standButtonPlayer2.Invoke(new Action(delegate () { standButtonPlayer2.Enabled = false; }));
        }

        // Handles deal button click
        private void DealButton_Click(object sender, EventArgs e)
        {
            // Change Game State
            Engine.State = Enums.GameStates.StartGame;
            // Disable deal button
            dealButton.Invoke(new Action(delegate () { dealButton.Enabled = false; }));
            // Update card count
            cardCountPlayer1.Invoke(new Action(delegate () { cardCountPlayer1.Text = String.Format("Cardcount: {0}", engine.GetCardCount("player1").ToString()); }));
            cardCountPlayer2.Invoke(new Action(delegate () { cardCountPlayer2.Text = String.Format("Cardcount: {0}", engine.GetCardCount("player2").ToString()); }));
        }

        // handles hit button click for player 1
        private void HitButton_Click(object sender, EventArgs e)
        {
            // Draw card
            engine.DrawCard("player1");
            
            // Update card count
            cardCountPlayer1.Invoke(new Action(delegate () { cardCountPlayer1.Text = String.Format("Cardcount: {0}", engine.GetCardCount("player1").ToString()); }));
            
            // Change gamestate
            Engine.State = Enums.GameStates.UpdateGame;
        }

        // handles hitbutton click for player 2
        private void HitButtonPlayer2_Click(object sender, EventArgs e)
        {
            // Draw card
            engine.DrawCard("player2");

            // Update card count
            cardCountPlayer2.Invoke(new Action(delegate () { cardCountPlayer2.Text = String.Format("Cardcount: {0}", engine.GetCardCount("player2").ToString()); }));

            // Change gamestate
            Engine.State = Enums.GameStates.UpdateGame;
        }

        // Handles stand button click for player 1
        private void StandButton_Click(object sender, EventArgs e)
        {
            //Stand method
            DrawPlayer2Turn();
        }

        // handles stand button for player 2
        private void StandButtonPlayer2_Click(object sender, EventArgs e)
        {
            //Stand method
            hitButtonPlayer2.Invoke(new Action(delegate () { hitButtonPlayer2.Enabled = false; }));
            standButtonPlayer2.Invoke(new Action(delegate () { standButtonPlayer2.Enabled = false; }));
            
            //
            // TODO
            //
            // Method for dealer draw
            // Determine winner
            
        }

        internal void Result()
        {
            resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "Game is over, reset to restart!"; }));
        }

        // handles reset button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Set state to ResetGame
            Engine.State = Enums.GameStates.ResetGame;
            // Remove all pictureboxes
            RemoveControls(this, typeof(PictureBox));
            // Set card count to 0
            cardCountPlayer1.Invoke(new Action(delegate () { cardCountPlayer1.Text = "Cardcount: 0"; }));
            cardCountPlayer2.Invoke(new Action(delegate () { cardCountPlayer2.Text = "Cardcount: 0"; }));
        }

        // Function to clear controls from canvas
        private void RemoveControls(Control control, Type type)
        {
            List<Control> controls = new List<Control>();
            Stack<Control> stack = new Stack<Control>();
            stack.Push(control);

            while (stack.Count > 0)
            {
                Control ctrl = stack.Pop();
                foreach (Control child in ctrl.Controls)
                {
                    if (child.GetType() == type)
                    {
                        controls.Add(child);
                    }
                    else if (true == child.HasChildren)
                    {
                        stack.Push(child);
                    }
                }
            }

            foreach (Control ctrl in controls)
            {
                control.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }

        public void RenderCard(int x, int y, string image)
        {
            PictureBox picBox = new PictureBox
            {
                Location = new Point(x, y),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(60, 88),
                ImageLocation = image,


            };
            Controls.Add(picBox);
            picBox.BringToFront();
        }

        public void InvokeRenderCard(int x, int y, string image)
        {
            this.Invoke(new Action(delegate ()
            {
                RenderCard(x, y, image);
            }));
        }

        public void BustPlayer(Participents player)
        {
            // player is dead so exclude from game
            if (player.Name == "player1")
            {
                cardCountPlayer1.Invoke(new Action(delegate () { cardCountPlayer1.Text = "BUSTED!"; }));
                DrawPlayer2Turn();
            }
            else if (player.Name == "player2")
            {
                cardCountPlayer2.Invoke(new Action(delegate () { cardCountPlayer2.Text = "BUSTED!"; }));
                hitButtonPlayer2.Invoke(new Action(delegate () { hitButtonPlayer2.Enabled = false; }));
                standButtonPlayer2.Invoke(new Action(delegate () { standButtonPlayer2.Enabled = false; }));
            }
            else
            {
                // dealer busted
            }
        }

        public void IsWinner(Participents player)
        {
            // player won the game
            if (player.Name == "player1")
            {
                cardCountPlayer1.Invoke(new Action(delegate () { cardCountPlayer1.Text = "THIS HAND WON THE GAME!"; }));
                resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "PLAYER 1 WON THE GAME!"; }));
            }
            else if(player.Name == "player2")
            {
                cardCountPlayer2.Invoke(new Action(delegate () { cardCountPlayer2.Text = "THIS HAND WON THE GAME!"; }));
                resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "PLAYER 2 WON THE GAME!"; }));
            }
            else
            {
                // dealer won
                resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "DEALER WON THE GAME!"; }));
            }
            DrawEndGame();
        }
    }
}
