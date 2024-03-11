namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblGamesWon = new System.Windows.Forms.Label();
            this.lblGamesLost = new System.Windows.Forms.Label();
            this.gameInfo = new System.Windows.Forms.GroupBox();
            this.lblCountLoss = new System.Windows.Forms.Label();
            this.lblCountWins = new System.Windows.Forms.Label();
            this.lblCountPlayed = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtGuessBox = new System.Windows.Forms.TextBox();
            this.dicePicture = new System.Windows.Forms.PictureBox();
            this.cmdRollDice = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.gameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(6, 43);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(140, 15);
            this.lblGamesPlayed.TabIndex = 1;
            this.lblGamesPlayed.Text = "Number of Times Played:\r\n";
            // 
            // lblGamesWon
            // 
            this.lblGamesWon.AutoSize = true;
            this.lblGamesWon.Location = new System.Drawing.Point(6, 90);
            this.lblGamesWon.Name = "lblGamesWon";
            this.lblGamesWon.Size = new System.Drawing.Size(130, 15);
            this.lblGamesWon.TabIndex = 2;
            this.lblGamesWon.Text = "Number of Times Won:";
            // 
            // lblGamesLost
            // 
            this.lblGamesLost.AutoSize = true;
            this.lblGamesLost.Location = new System.Drawing.Point(6, 134);
            this.lblGamesLost.Name = "lblGamesLost";
            this.lblGamesLost.Size = new System.Drawing.Size(130, 15);
            this.lblGamesLost.TabIndex = 3;
            this.lblGamesLost.Text = "Number of Times Lost: ";
            // 
            // gameInfo
            // 
            this.gameInfo.Controls.Add(this.lblCountLoss);
            this.gameInfo.Controls.Add(this.lblCountWins);
            this.gameInfo.Controls.Add(this.lblCountPlayed);
            this.gameInfo.Controls.Add(this.lblGamesPlayed);
            this.gameInfo.Controls.Add(this.lblGamesLost);
            this.gameInfo.Controls.Add(this.lblGamesWon);
            this.gameInfo.Location = new System.Drawing.Point(26, 23);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(198, 168);
            this.gameInfo.TabIndex = 4;
            this.gameInfo.TabStop = false;
            this.gameInfo.Text = "Game Info";
            // 
            // lblCountLoss
            // 
            this.lblCountLoss.AutoSize = true;
            this.lblCountLoss.Location = new System.Drawing.Point(160, 134);
            this.lblCountLoss.Name = "lblCountLoss";
            this.lblCountLoss.Size = new System.Drawing.Size(13, 15);
            this.lblCountLoss.TabIndex = 6;
            this.lblCountLoss.Text = "0";
            // 
            // lblCountWins
            // 
            this.lblCountWins.AutoSize = true;
            this.lblCountWins.Location = new System.Drawing.Point(160, 90);
            this.lblCountWins.Name = "lblCountWins";
            this.lblCountWins.Size = new System.Drawing.Size(13, 15);
            this.lblCountWins.TabIndex = 5;
            this.lblCountWins.Text = "0";
            // 
            // lblCountPlayed
            // 
            this.lblCountPlayed.AutoSize = true;
            this.lblCountPlayed.Location = new System.Drawing.Point(160, 43);
            this.lblCountPlayed.Name = "lblCountPlayed";
            this.lblCountPlayed.Size = new System.Drawing.Size(13, 15);
            this.lblCountPlayed.TabIndex = 4;
            this.lblCountPlayed.Text = "0";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuess.Location = new System.Drawing.Point(26, 221);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(167, 21);
            this.lblGuess.TabIndex = 5;
            this.lblGuess.Text = "Enter your guess (1-6):";
            this.lblGuess.Click += new System.EventHandler(this.lblGuess_Click);
            // 
            // txtGuessBox
            // 
            this.txtGuessBox.Location = new System.Drawing.Point(199, 223);
            this.txtGuessBox.MaxLength = 1;
            this.txtGuessBox.Name = "txtGuessBox";
            this.txtGuessBox.Size = new System.Drawing.Size(63, 23);
            this.txtGuessBox.TabIndex = 6;
            // 
            // dicePicture
            // 
            this.dicePicture.Location = new System.Drawing.Point(416, 22);
            this.dicePicture.Name = "dicePicture";
            this.dicePicture.Size = new System.Drawing.Size(126, 106);
            this.dicePicture.TabIndex = 7;
            this.dicePicture.TabStop = false;
            // 
            // cmdRollDice
            // 
            this.cmdRollDice.Location = new System.Drawing.Point(439, 157);
            this.cmdRollDice.Name = "cmdRollDice";
            this.cmdRollDice.Size = new System.Drawing.Size(75, 23);
            this.cmdRollDice.TabIndex = 8;
            this.cmdRollDice.Text = "Roll";
            this.cmdRollDice.UseVisualStyleBackColor = true;
            this.cmdRollDice.Click += new System.EventHandler(this.cmdRollDice_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(439, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataTextBox.Location = new System.Drawing.Point(48, 279);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(558, 210);
            this.dataTextBox.TabIndex = 10;
            this.dataTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 501);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmdRollDice);
            this.Controls.Add(this.dicePicture);
            this.Controls.Add(this.txtGuessBox);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.gameInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gameInfo.ResumeLayout(false);
            this.gameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGamesPlayed;
        private Label lblGamesWon;
        private Label lblGamesLost;
        private GroupBox gameInfo;
        private Label lblGuess;
        private TextBox txtGuessBox;
        private PictureBox dicePicture;
        private Button cmdRollDice;
        private Button btnReset;
        private RichTextBox dataTextBox;
        private Label lblCountLoss;
        private Label lblCountWins;
        private Label lblCountPlayed;
    }
}