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
            this.pictureBoxPlayer1Hand1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1Hand2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1Hit = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.standButtonPlayer1 = new System.Windows.Forms.Button();
            this.pictureBoxDealerHand1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDealerHand2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDealerHit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxPlayer2Hit = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer2Hand2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer2Hand1 = new System.Windows.Forms.PictureBox();
            this.standButtonPlayer2 = new System.Windows.Forms.Button();
            this.hitButtonPlayer2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1Hand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1Hand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1Hit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2Hit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2Hand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2Hand1)).BeginInit();
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(1380, 177);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(163, 53);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // hitButtonPlayer1
            // 
            this.hitButtonPlayer1.Location = new System.Drawing.Point(498, 561);
            this.hitButtonPlayer1.Name = "hitButtonPlayer1";
            this.hitButtonPlayer1.Size = new System.Drawing.Size(163, 53);
            this.hitButtonPlayer1.TabIndex = 1;
            this.hitButtonPlayer1.Text = "Hit";
            this.hitButtonPlayer1.UseVisualStyleBackColor = true;
            this.hitButtonPlayer1.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1380, 95);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(163, 53);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // pictureBoxPlayer1Hand1
            // 
            this.pictureBoxPlayer1Hand1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer1Hand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer1Hand1.Location = new System.Drawing.Point(194, 561);
            this.pictureBoxPlayer1Hand1.Name = "pictureBoxPlayer1Hand1";
            this.pictureBoxPlayer1Hand1.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxPlayer1Hand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer1Hand1.TabIndex = 3;
            this.pictureBoxPlayer1Hand1.TabStop = false;
            // 
            // pictureBoxPlayer1Hand2
            // 
            this.pictureBoxPlayer1Hand2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer1Hand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer1Hand2.Location = new System.Drawing.Point(248, 561);
            this.pictureBoxPlayer1Hand2.Name = "pictureBoxPlayer1Hand2";
            this.pictureBoxPlayer1Hand2.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxPlayer1Hand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer1Hand2.TabIndex = 4;
            this.pictureBoxPlayer1Hand2.TabStop = false;
            // 
            // pictureBoxPlayer1Hit
            // 
            this.pictureBoxPlayer1Hit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer1Hit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer1Hit.Location = new System.Drawing.Point(361, 561);
            this.pictureBoxPlayer1Hit.Name = "pictureBoxPlayer1Hit";
            this.pictureBoxPlayer1Hit.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxPlayer1Hit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer1Hit.TabIndex = 5;
            this.pictureBoxPlayer1Hit.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(301, 371);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(125, 29);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Blackjack";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // standButtonPlayer1
            // 
            this.standButtonPlayer1.Location = new System.Drawing.Point(498, 620);
            this.standButtonPlayer1.Name = "standButtonPlayer1";
            this.standButtonPlayer1.Size = new System.Drawing.Size(163, 53);
            this.standButtonPlayer1.TabIndex = 7;
            this.standButtonPlayer1.Text = "Stand";
            this.standButtonPlayer1.UseVisualStyleBackColor = true;
            this.standButtonPlayer1.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // pictureBoxDealerHand1
            // 
            this.pictureBoxDealerHand1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDealerHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDealerHand1.Location = new System.Drawing.Point(708, 95);
            this.pictureBoxDealerHand1.Name = "pictureBoxDealerHand1";
            this.pictureBoxDealerHand1.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxDealerHand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDealerHand1.TabIndex = 8;
            this.pictureBoxDealerHand1.TabStop = false;
            // 
            // pictureBoxDealerHand2
            // 
            this.pictureBoxDealerHand2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDealerHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDealerHand2.Location = new System.Drawing.Point(762, 95);
            this.pictureBoxDealerHand2.Name = "pictureBoxDealerHand2";
            this.pictureBoxDealerHand2.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxDealerHand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDealerHand2.TabIndex = 9;
            this.pictureBoxDealerHand2.TabStop = false;
            // 
            // pictureBoxDealerHit
            // 
            this.pictureBoxDealerHit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDealerHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDealerHit.Location = new System.Drawing.Point(875, 95);
            this.pictureBoxDealerHit.Name = "pictureBoxDealerHit";
            this.pictureBoxDealerHit.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxDealerHit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDealerHit.TabIndex = 10;
            this.pictureBoxDealerHit.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(796, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(282, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(1118, 718);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Player 2";
            // 
            // pictureBoxPlayer2Hit
            // 
            this.pictureBoxPlayer2Hit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer2Hit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer2Hit.Location = new System.Drawing.Point(1197, 561);
            this.pictureBoxPlayer2Hit.Name = "pictureBoxPlayer2Hit";
            this.pictureBoxPlayer2Hit.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxPlayer2Hit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer2Hit.TabIndex = 16;
            this.pictureBoxPlayer2Hit.TabStop = false;
            // 
            // pictureBoxPlayer2Hand2
            // 
            this.pictureBoxPlayer2Hand2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer2Hand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer2Hand2.Location = new System.Drawing.Point(1084, 561);
            this.pictureBoxPlayer2Hand2.Name = "pictureBoxPlayer2Hand2";
            this.pictureBoxPlayer2Hand2.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxPlayer2Hand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer2Hand2.TabIndex = 15;
            this.pictureBoxPlayer2Hand2.TabStop = false;
            // 
            // pictureBoxPlayer2Hand1
            // 
            this.pictureBoxPlayer2Hand1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer2Hand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer2Hand1.Location = new System.Drawing.Point(1030, 561);
            this.pictureBoxPlayer2Hand1.Name = "pictureBoxPlayer2Hand1";
            this.pictureBoxPlayer2Hand1.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxPlayer2Hand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer2Hand1.TabIndex = 14;
            this.pictureBoxPlayer2Hand1.TabStop = false;
            // 
            // standButtonPlayer2
            // 
            this.standButtonPlayer2.Location = new System.Drawing.Point(1339, 620);
            this.standButtonPlayer2.Name = "standButtonPlayer2";
            this.standButtonPlayer2.Size = new System.Drawing.Size(163, 53);
            this.standButtonPlayer2.TabIndex = 19;
            this.standButtonPlayer2.Text = "Stand";
            this.standButtonPlayer2.UseVisualStyleBackColor = true;
            this.standButtonPlayer2.Click += new System.EventHandler(this.StandButtonPlayer2_Click);
            // 
            // hitButtonPlayer2
            // 
            this.hitButtonPlayer2.Location = new System.Drawing.Point(1339, 561);
            this.hitButtonPlayer2.Name = "hitButtonPlayer2";
            this.hitButtonPlayer2.Size = new System.Drawing.Size(163, 53);
            this.hitButtonPlayer2.TabIndex = 18;
            this.hitButtonPlayer2.Text = "Hit";
            this.hitButtonPlayer2.UseVisualStyleBackColor = true;
            this.hitButtonPlayer2.Click += new System.EventHandler(this.HitButtonPlayer2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.standButtonPlayer2);
            this.Controls.Add(this.hitButtonPlayer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxPlayer2Hit);
            this.Controls.Add(this.pictureBoxPlayer2Hand2);
            this.Controls.Add(this.pictureBoxPlayer2Hand1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDealerHit);
            this.Controls.Add(this.pictureBoxDealerHand2);
            this.Controls.Add(this.pictureBoxDealerHand1);
            this.Controls.Add(this.standButtonPlayer1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.pictureBoxPlayer1Hit);
            this.Controls.Add(this.pictureBoxPlayer1Hand2);
            this.Controls.Add(this.pictureBoxPlayer1Hand1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.hitButtonPlayer1);
            this.Controls.Add(this.dealButton);
            this.Name = "Form1";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1Hand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1Hand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1Hit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2Hit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2Hand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2Hand1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButtonPlayer1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1Hand1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1Hand2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1Hit;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button standButtonPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxDealerHand1;
        private System.Windows.Forms.PictureBox pictureBoxDealerHand2;
        private System.Windows.Forms.PictureBox pictureBoxDealerHit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2Hit;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2Hand2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2Hand1;
        private System.Windows.Forms.Button standButtonPlayer2;
        private System.Windows.Forms.Button hitButtonPlayer2;
    }
}

