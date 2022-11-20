namespace FamilyGameNight
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
            this.btnResetGame = new System.Windows.Forms.Button();
            this.lblSecretWord = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtGuessLetter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitLetter = new System.Windows.Forms.Button();
            this.txtLetter1 = new System.Windows.Forms.TextBox();
            this.txtLetter2 = new System.Windows.Forms.TextBox();
            this.txtLetter3 = new System.Windows.Forms.TextBox();
            this.txtLetter4 = new System.Windows.Forms.TextBox();
            this.txtLetter5 = new System.Windows.Forms.TextBox();
            this.txtLetter6 = new System.Windows.Forms.TextBox();
            this.txtLetter7 = new System.Windows.Forms.TextBox();
            this.txtLetter8 = new System.Windows.Forms.TextBox();
            this.txtLetter9 = new System.Windows.Forms.TextBox();
            this.txtLetter10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemainingGuess1 = new System.Windows.Forms.TextBox();
            this.txtRemainingGuess2 = new System.Windows.Forms.TextBox();
            this.txtRemainingGuess3 = new System.Windows.Forms.TextBox();
            this.txtRemainingGuess4 = new System.Windows.Forms.TextBox();
            this.txtRemainingGuess5 = new System.Windows.Forms.TextBox();
            this.txtRemainingGuess6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResetGame
            // 
            this.btnResetGame.Location = new System.Drawing.Point(26, 27);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(127, 23);
            this.btnResetGame.TabIndex = 0;
            this.btnResetGame.Text = "Reset Game!";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // lblSecretWord
            // 
            this.lblSecretWord.AutoSize = true;
            this.lblSecretWord.Location = new System.Drawing.Point(740, 27);
            this.lblSecretWord.Name = "lblSecretWord";
            this.lblSecretWord.Size = new System.Drawing.Size(26, 15);
            this.lblSecretWord.TabIndex = 1;
            this.lblSecretWord.Text = "lbl1";
            this.lblSecretWord.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(410, 64);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 15);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Hangman";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(26, 56);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(127, 23);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Need help?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnHelp_KeyDown_1);
            // 
            // txtGuessLetter
            // 
            this.txtGuessLetter.Location = new System.Drawing.Point(106, 315);
            this.txtGuessLetter.Name = "txtGuessLetter";
            this.txtGuessLetter.Size = new System.Drawing.Size(47, 23);
            this.txtGuessLetter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Guess a letter:";
            // 
            // btnSubmitLetter
            // 
            this.btnSubmitLetter.Location = new System.Drawing.Point(26, 344);
            this.btnSubmitLetter.Name = "btnSubmitLetter";
            this.btnSubmitLetter.Size = new System.Drawing.Size(127, 23);
            this.btnSubmitLetter.TabIndex = 6;
            this.btnSubmitLetter.Text = "Submit";
            this.btnSubmitLetter.UseVisualStyleBackColor = true;
            this.btnSubmitLetter.Click += new System.EventHandler(this.btnSubmitLetter_Click);
            // 
            // txtLetter1
            // 
            this.txtLetter1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter1.Location = new System.Drawing.Point(278, 121);
            this.txtLetter1.Name = "txtLetter1";
            this.txtLetter1.ReadOnly = true;
            this.txtLetter1.Size = new System.Drawing.Size(27, 43);
            this.txtLetter1.TabIndex = 7;
            this.txtLetter1.Text = "A";
            this.txtLetter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetter2
            // 
            this.txtLetter2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter2.Location = new System.Drawing.Point(311, 121);
            this.txtLetter2.Name = "txtLetter2";
            this.txtLetter2.ReadOnly = true;
            this.txtLetter2.Size = new System.Drawing.Size(27, 43);
            this.txtLetter2.TabIndex = 8;
            this.txtLetter2.Text = "A";
            this.txtLetter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetter3
            // 
            this.txtLetter3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter3.Location = new System.Drawing.Point(344, 121);
            this.txtLetter3.Name = "txtLetter3";
            this.txtLetter3.ReadOnly = true;
            this.txtLetter3.Size = new System.Drawing.Size(27, 43);
            this.txtLetter3.TabIndex = 9;
            this.txtLetter3.Text = "A";
            this.txtLetter3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetter4
            // 
            this.txtLetter4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter4.Location = new System.Drawing.Point(377, 121);
            this.txtLetter4.Name = "txtLetter4";
            this.txtLetter4.ReadOnly = true;
            this.txtLetter4.Size = new System.Drawing.Size(27, 43);
            this.txtLetter4.TabIndex = 10;
            this.txtLetter4.Text = "A";
            this.txtLetter4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetter5
            // 
            this.txtLetter5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter5.Location = new System.Drawing.Point(410, 121);
            this.txtLetter5.Name = "txtLetter5";
            this.txtLetter5.ReadOnly = true;
            this.txtLetter5.Size = new System.Drawing.Size(27, 43);
            this.txtLetter5.TabIndex = 11;
            this.txtLetter5.Text = "A";
            this.txtLetter5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetter6
            // 
            this.txtLetter6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter6.Location = new System.Drawing.Point(443, 121);
            this.txtLetter6.Name = "txtLetter6";
            this.txtLetter6.ReadOnly = true;
            this.txtLetter6.Size = new System.Drawing.Size(27, 43);
            this.txtLetter6.TabIndex = 12;
            this.txtLetter6.Text = "A";
            this.txtLetter6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetter7
            // 
            this.txtLetter7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter7.Location = new System.Drawing.Point(476, 121);
            this.txtLetter7.Name = "txtLetter7";
            this.txtLetter7.ReadOnly = true;
            this.txtLetter7.Size = new System.Drawing.Size(27, 43);
            this.txtLetter7.TabIndex = 13;
            this.txtLetter7.Text = "A";
            this.txtLetter7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetter8
            // 
            this.txtLetter8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter8.Location = new System.Drawing.Point(509, 121);
            this.txtLetter8.Name = "txtLetter8";
            this.txtLetter8.ReadOnly = true;
            this.txtLetter8.Size = new System.Drawing.Size(27, 43);
            this.txtLetter8.TabIndex = 14;
            this.txtLetter8.Text = "A";
            this.txtLetter8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetter9
            // 
            this.txtLetter9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter9.Location = new System.Drawing.Point(542, 121);
            this.txtLetter9.Name = "txtLetter9";
            this.txtLetter9.ReadOnly = true;
            this.txtLetter9.Size = new System.Drawing.Size(27, 43);
            this.txtLetter9.TabIndex = 15;
            this.txtLetter9.Text = "A";
            this.txtLetter9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetter10
            // 
            this.txtLetter10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLetter10.Location = new System.Drawing.Point(575, 121);
            this.txtLetter10.Name = "txtLetter10";
            this.txtLetter10.ReadOnly = true;
            this.txtLetter10.Size = new System.Drawing.Size(27, 43);
            this.txtLetter10.TabIndex = 16;
            this.txtLetter10.Text = "A";
            this.txtLetter10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Remaining Guesses:";
            // 
            // txtRemainingGuess1
            // 
            this.txtRemainingGuess1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtRemainingGuess1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemainingGuess1.ForeColor = System.Drawing.Color.White;
            this.txtRemainingGuess1.Location = new System.Drawing.Point(410, 395);
            this.txtRemainingGuess1.Name = "txtRemainingGuess1";
            this.txtRemainingGuess1.ReadOnly = true;
            this.txtRemainingGuess1.Size = new System.Drawing.Size(27, 43);
            this.txtRemainingGuess1.TabIndex = 18;
            this.txtRemainingGuess1.Text = "X";
            this.txtRemainingGuess1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemainingGuess2
            // 
            this.txtRemainingGuess2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtRemainingGuess2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemainingGuess2.ForeColor = System.Drawing.Color.White;
            this.txtRemainingGuess2.Location = new System.Drawing.Point(443, 395);
            this.txtRemainingGuess2.Name = "txtRemainingGuess2";
            this.txtRemainingGuess2.ReadOnly = true;
            this.txtRemainingGuess2.Size = new System.Drawing.Size(27, 43);
            this.txtRemainingGuess2.TabIndex = 19;
            this.txtRemainingGuess2.Text = "X";
            this.txtRemainingGuess2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemainingGuess3
            // 
            this.txtRemainingGuess3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtRemainingGuess3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemainingGuess3.ForeColor = System.Drawing.Color.White;
            this.txtRemainingGuess3.Location = new System.Drawing.Point(476, 395);
            this.txtRemainingGuess3.Name = "txtRemainingGuess3";
            this.txtRemainingGuess3.ReadOnly = true;
            this.txtRemainingGuess3.Size = new System.Drawing.Size(27, 43);
            this.txtRemainingGuess3.TabIndex = 20;
            this.txtRemainingGuess3.Text = "X";
            this.txtRemainingGuess3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemainingGuess4
            // 
            this.txtRemainingGuess4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtRemainingGuess4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemainingGuess4.ForeColor = System.Drawing.Color.White;
            this.txtRemainingGuess4.Location = new System.Drawing.Point(509, 395);
            this.txtRemainingGuess4.Name = "txtRemainingGuess4";
            this.txtRemainingGuess4.ReadOnly = true;
            this.txtRemainingGuess4.Size = new System.Drawing.Size(27, 43);
            this.txtRemainingGuess4.TabIndex = 21;
            this.txtRemainingGuess4.Text = "X";
            this.txtRemainingGuess4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemainingGuess5
            // 
            this.txtRemainingGuess5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtRemainingGuess5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemainingGuess5.ForeColor = System.Drawing.Color.White;
            this.txtRemainingGuess5.Location = new System.Drawing.Point(542, 395);
            this.txtRemainingGuess5.Name = "txtRemainingGuess5";
            this.txtRemainingGuess5.ReadOnly = true;
            this.txtRemainingGuess5.Size = new System.Drawing.Size(27, 43);
            this.txtRemainingGuess5.TabIndex = 22;
            this.txtRemainingGuess5.Text = "X";
            this.txtRemainingGuess5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemainingGuess6
            // 
            this.txtRemainingGuess6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtRemainingGuess6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemainingGuess6.ForeColor = System.Drawing.Color.White;
            this.txtRemainingGuess6.Location = new System.Drawing.Point(575, 395);
            this.txtRemainingGuess6.Name = "txtRemainingGuess6";
            this.txtRemainingGuess6.ReadOnly = true;
            this.txtRemainingGuess6.Size = new System.Drawing.Size(27, 43);
            this.txtRemainingGuess6.TabIndex = 23;
            this.txtRemainingGuess6.Text = "X";
            this.txtRemainingGuess6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRemainingGuess6);
            this.Controls.Add(this.txtRemainingGuess5);
            this.Controls.Add(this.txtRemainingGuess4);
            this.Controls.Add(this.txtRemainingGuess3);
            this.Controls.Add(this.txtRemainingGuess2);
            this.Controls.Add(this.txtRemainingGuess1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLetter10);
            this.Controls.Add(this.txtLetter9);
            this.Controls.Add(this.txtLetter8);
            this.Controls.Add(this.txtLetter7);
            this.Controls.Add(this.txtLetter6);
            this.Controls.Add(this.txtLetter5);
            this.Controls.Add(this.txtLetter4);
            this.Controls.Add(this.txtLetter3);
            this.Controls.Add(this.txtLetter2);
            this.Controls.Add(this.txtLetter1);
            this.Controls.Add(this.btnSubmitLetter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuessLetter);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSecretWord);
            this.Controls.Add(this.btnResetGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnResetGame;
        private Label lblSecretWord;
        private Label lblTitle;
        private Button btnHelp;
        private TextBox txtGuessLetter;
        private Label label1;
        private Button btnSubmitLetter;
        private TextBox txtLetter1;
        private TextBox txtLetter2;
        private TextBox txtLetter3;
        private TextBox txtLetter4;
        private TextBox txtLetter5;
        private TextBox txtLetter6;
        private TextBox txtLetter7;
        private TextBox txtLetter8;
        private TextBox txtLetter9;
        private TextBox txtLetter10;
        private Label label2;
        private TextBox txtRemainingGuess1;
        private TextBox txtRemainingGuess2;
        private TextBox txtRemainingGuess3;
        private TextBox txtRemainingGuess4;
        private TextBox txtRemainingGuess5;
        private TextBox txtRemainingGuess6;
    }
}