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
            hitButtonPlayer1.Invoke(new Action(delegate () { hitButtonPlayer1.Enabled = false; }));
            hitButtonPlayer2.Invoke(new Action(delegate () { hitButtonPlayer2.Enabled = false; }));
            standButtonPlayer1.Invoke(new Action(delegate () { standButtonPlayer1.Enabled = false; }));
            standButtonPlayer2.Invoke(new Action(delegate () { standButtonPlayer2.Enabled = false; }));
            resetButton.Invoke(new Action(delegate () { resetButton.Enabled = false; }));
            resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "Click Deal when ready"; }));
        }

        // Handles deal button click
        private void DealButton_Click(object sender, EventArgs e)
        {
            Engine.State = Enums.GameStates.StartGame;
        }

        // handles hit button click for player 1
        private void HitButton_Click(object sender, EventArgs e)
        {
            //Hit method
        }

        // handles hitbutton click for player 2
        private void HitButtonPlayer2_Click(object sender, EventArgs e)
        {
            //Hit method
        }

        // Handles stand button click for player 1
        private void StandButton_Click(object sender, EventArgs e)
        {
            //Stand method
        }

        // handles stand button for player 2
        private void StandButtonPlayer2_Click(object sender, EventArgs e)
        {
            //Stand method
        }

        internal void Result()
        {
            resultLabel.Invoke(new Action(delegate () { resultLabel.Text = "Game is over, reset to restart!"; }));
        }

        // handles reset button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //engine.State = Enums.GameStates.ResetGame;
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
    }
}
