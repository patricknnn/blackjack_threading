namespace Blackjack_threading
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pictureBoxPlayerHand1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayerHand2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHit = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.standButton = new System.Windows.Forms.Button();
            this.pictureBoxDealerHand1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDealerHand2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDealerHit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerHand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHit)).BeginInit();
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(1380, 561);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(163, 53);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(1380, 620);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(163, 53);
            this.hitButton.TabIndex = 1;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1380, 95);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(163, 53);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pictureBoxPlayerHand1
            // 
            this.pictureBoxPlayerHand1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayerHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayerHand1.Location = new System.Drawing.Point(306, 522);
            this.pictureBoxPlayerHand1.Name = "pictureBoxPlayerHand1";
            this.pictureBoxPlayerHand1.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxPlayerHand1.TabIndex = 3;
            this.pictureBoxPlayerHand1.TabStop = false;
            // 
            // pictureBoxPlayerHand2
            // 
            this.pictureBoxPlayerHand2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayerHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayerHand2.Location = new System.Drawing.Point(360, 522);
            this.pictureBoxPlayerHand2.Name = "pictureBoxPlayerHand2";
            this.pictureBoxPlayerHand2.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxPlayerHand2.TabIndex = 4;
            this.pictureBoxPlayerHand2.TabStop = false;
            // 
            // pictureBoxHit
            // 
            this.pictureBoxHit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHit.Location = new System.Drawing.Point(473, 522);
            this.pictureBoxHit.Name = "pictureBoxHit";
            this.pictureBoxHit.Size = new System.Drawing.Size(90, 135);
            this.pictureBoxHit.TabIndex = 5;
            this.pictureBoxHit.TabStop = false;
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
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(1380, 679);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(163, 53);
            this.standButton.TabIndex = 7;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // pictureBoxDealerHand1
            // 
            this.pictureBoxDealerHand1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDealerHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDealerHand1.Location = new System.Drawing.Point(708, 95);
            this.pictureBoxDealerHand1.Name = "pictureBoxDealerHand1";
            this.pictureBoxDealerHand1.Size = new System.Drawing.Size(90, 135);
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
            this.label2.Location = new System.Drawing.Point(394, 679);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Player 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDealerHit);
            this.Controls.Add(this.pictureBoxDealerHand2);
            this.Controls.Add(this.pictureBoxDealerHand1);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.pictureBoxHit);
            this.Controls.Add(this.pictureBoxPlayerHand2);
            this.Controls.Add(this.pictureBoxPlayerHand1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerHand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerHit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox pictureBoxPlayerHand1;
        private System.Windows.Forms.PictureBox pictureBoxPlayerHand2;
        private System.Windows.Forms.PictureBox pictureBoxHit;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.PictureBox pictureBoxDealerHand1;
        private System.Windows.Forms.PictureBox pictureBoxDealerHand2;
        private System.Windows.Forms.PictureBox pictureBoxDealerHit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

