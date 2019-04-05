namespace Blackjack_threading
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButtonPlayer1 = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.standButtonPlayer1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.standButtonPlayer2 = new System.Windows.Forms.Button();
            this.hitButtonPlayer2 = new System.Windows.Forms.Button();
            this.cardCountPlayer1 = new System.Windows.Forms.Label();
            this.cardCountPlayer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(920, 115);
            this.dealButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(109, 34);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // hitButtonPlayer1
            // 
            this.hitButtonPlayer1.Location = new System.Drawing.Point(127, 484);
            this.hitButtonPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hitButtonPlayer1.Name = "hitButtonPlayer1";
            this.hitButtonPlayer1.Size = new System.Drawing.Size(109, 34);
            this.hitButtonPlayer1.TabIndex = 1;
            this.hitButtonPlayer1.Text = "Hit";
            this.hitButtonPlayer1.UseVisualStyleBackColor = true;
            this.hitButtonPlayer1.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(920, 62);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(109, 34);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(124, 242);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(84, 18);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Blackjack";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // standButtonPlayer1
            // 
            this.standButtonPlayer1.Location = new System.Drawing.Point(246, 484);
            this.standButtonPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.standButtonPlayer1.Name = "standButtonPlayer1";
            this.standButtonPlayer1.Size = new System.Drawing.Size(109, 34);
            this.standButtonPlayer1.TabIndex = 7;
            this.standButtonPlayer1.Text = "Stand";
            this.standButtonPlayer1.UseVisualStyleBackColor = true;
            this.standButtonPlayer1.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(531, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(218, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(776, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Player 2";
            // 
            // standButtonPlayer2
            // 
            this.standButtonPlayer2.Location = new System.Drawing.Point(804, 484);
            this.standButtonPlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.standButtonPlayer2.Name = "standButtonPlayer2";
            this.standButtonPlayer2.Size = new System.Drawing.Size(109, 34);
            this.standButtonPlayer2.TabIndex = 19;
            this.standButtonPlayer2.Text = "Stand";
            this.standButtonPlayer2.UseVisualStyleBackColor = true;
            this.standButtonPlayer2.Click += new System.EventHandler(this.StandButtonPlayer2_Click);
            // 
            // hitButtonPlayer2
            // 
            this.hitButtonPlayer2.Location = new System.Drawing.Point(686, 484);
            this.hitButtonPlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hitButtonPlayer2.Name = "hitButtonPlayer2";
            this.hitButtonPlayer2.Size = new System.Drawing.Size(109, 34);
            this.hitButtonPlayer2.TabIndex = 18;
            this.hitButtonPlayer2.Text = "Hit";
            this.hitButtonPlayer2.UseVisualStyleBackColor = true;
            this.hitButtonPlayer2.Click += new System.EventHandler(this.HitButtonPlayer2_Click);
            // 
            // cardCountPlayer1
            // 
            this.cardCountPlayer1.AutoSize = true;
            this.cardCountPlayer1.Location = new System.Drawing.Point(127, 330);
            this.cardCountPlayer1.Name = "cardCountPlayer1";
            this.cardCountPlayer1.Size = new System.Drawing.Size(63, 13);
            this.cardCountPlayer1.TabIndex = 20;
            this.cardCountPlayer1.Text = "Card Count:";
            // 
            // cardCountPlayer2
            // 
            this.cardCountPlayer2.AutoSize = true;
            this.cardCountPlayer2.Location = new System.Drawing.Point(683, 330);
            this.cardCountPlayer2.Name = "cardCountPlayer2";
            this.cardCountPlayer2.Size = new System.Drawing.Size(63, 13);
            this.cardCountPlayer2.TabIndex = 21;
            this.cardCountPlayer2.Text = "Card Count:";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 549);
            this.Controls.Add(this.cardCountPlayer2);
            this.Controls.Add(this.cardCountPlayer1);
            this.Controls.Add(this.standButtonPlayer2);
            this.Controls.Add(this.hitButtonPlayer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.standButtonPlayer1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.hitButtonPlayer1);
            this.Controls.Add(this.dealButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButtonPlayer1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button standButtonPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button standButtonPlayer2;
        private System.Windows.Forms.Button hitButtonPlayer2;
        private System.Windows.Forms.Label cardCountPlayer1;
        private System.Windows.Forms.Label cardCountPlayer2;
    }
}

