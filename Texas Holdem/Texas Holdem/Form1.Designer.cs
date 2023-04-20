namespace Texas_Holdem
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
            this.ROLB_Player1 = new System.Windows.Forms.Label();
            this.ROLB_Player2 = new System.Windows.Forms.Label();
            this.commCard1 = new System.Windows.Forms.Label();
            this.commcard2 = new System.Windows.Forms.Label();
            this.commCard3 = new System.Windows.Forms.Label();
            this.commcard4 = new System.Windows.Forms.Label();
            this.commCard5 = new System.Windows.Forms.Label();
            this.P2HoleCard1 = new System.Windows.Forms.Label();
            this.P2HoleCard2 = new System.Windows.Forms.Label();
            this.P1HoleCard1 = new System.Windows.Forms.Label();
            this.P1HoleCard2 = new System.Windows.Forms.Label();
            this.P1Amount_To_Bet_textBox = new System.Windows.Forms.TextBox();
            this.P1amountToBet_textbox = new System.Windows.Forms.Button();
            this.P2amountToBet_textbox = new System.Windows.Forms.TextBox();
            this.P2_placebet_button = new System.Windows.Forms.Button();
            this.P2TotalMoneyLabel = new System.Windows.Forms.Label();
            this.P1TotalMoneyLabel = new System.Windows.Forms.Label();
            this.TotalPot = new System.Windows.Forms.Label();
            this.P1_Fold_Button = new System.Windows.Forms.Button();
            this.P2_Fold_Button = new System.Windows.Forms.Button();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.P1_CheckButton = new System.Windows.Forms.Button();
            this.P2_Check_Button = new System.Windows.Forms.Button();
            this.GameDecisionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ROLB_Player1
            // 
            this.ROLB_Player1.AutoSize = true;
            this.ROLB_Player1.Location = new System.Drawing.Point(30, 34);
            this.ROLB_Player1.Name = "ROLB_Player1";
            this.ROLB_Player1.Size = new System.Drawing.Size(48, 15);
            this.ROLB_Player1.TabIndex = 0;
            this.ROLB_Player1.Text = "Player 1";
            // 
            // ROLB_Player2
            // 
            this.ROLB_Player2.AutoSize = true;
            this.ROLB_Player2.Location = new System.Drawing.Point(30, 358);
            this.ROLB_Player2.Name = "ROLB_Player2";
            this.ROLB_Player2.Size = new System.Drawing.Size(48, 15);
            this.ROLB_Player2.TabIndex = 1;
            this.ROLB_Player2.Text = "Player 2";
            // 
            // commCard1
            // 
            this.commCard1.AutoSize = true;
            this.commCard1.Location = new System.Drawing.Point(66, 197);
            this.commCard1.Name = "commCard1";
            this.commCard1.Size = new System.Drawing.Size(0, 15);
            this.commCard1.TabIndex = 2;
            // 
            // commcard2
            // 
            this.commcard2.AutoSize = true;
            this.commcard2.Location = new System.Drawing.Point(188, 197);
            this.commcard2.Name = "commcard2";
            this.commcard2.Size = new System.Drawing.Size(0, 15);
            this.commcard2.TabIndex = 3;
            // 
            // commCard3
            // 
            this.commCard3.AutoSize = true;
            this.commCard3.Location = new System.Drawing.Point(338, 197);
            this.commCard3.Name = "commCard3";
            this.commCard3.Size = new System.Drawing.Size(0, 15);
            this.commCard3.TabIndex = 4;
            // 
            // commcard4
            // 
            this.commcard4.AutoSize = true;
            this.commcard4.Location = new System.Drawing.Point(130, 230);
            this.commcard4.Name = "commcard4";
            this.commcard4.Size = new System.Drawing.Size(0, 15);
            this.commcard4.TabIndex = 5;
            this.commcard4.Click += new System.EventHandler(this.commcard4_Click);
            // 
            // commCard5
            // 
            this.commCard5.AutoSize = true;
            this.commCard5.Location = new System.Drawing.Point(260, 230);
            this.commCard5.Name = "commCard5";
            this.commCard5.Size = new System.Drawing.Size(0, 15);
            this.commCard5.TabIndex = 6;
            // 
            // P2HoleCard1
            // 
            this.P2HoleCard1.AutoSize = true;
            this.P2HoleCard1.Location = new System.Drawing.Point(119, 358);
            this.P2HoleCard1.Name = "P2HoleCard1";
            this.P2HoleCard1.Size = new System.Drawing.Size(38, 15);
            this.P2HoleCard1.TabIndex = 7;
            this.P2HoleCard1.Text = "label1";
            // 
            // P2HoleCard2
            // 
            this.P2HoleCard2.AutoSize = true;
            this.P2HoleCard2.Location = new System.Drawing.Point(119, 383);
            this.P2HoleCard2.Name = "P2HoleCard2";
            this.P2HoleCard2.Size = new System.Drawing.Size(38, 15);
            this.P2HoleCard2.TabIndex = 8;
            this.P2HoleCard2.Text = "label2";
            // 
            // P1HoleCard1
            // 
            this.P1HoleCard1.AutoSize = true;
            this.P1HoleCard1.Location = new System.Drawing.Point(119, 34);
            this.P1HoleCard1.Name = "P1HoleCard1";
            this.P1HoleCard1.Size = new System.Drawing.Size(38, 15);
            this.P1HoleCard1.TabIndex = 9;
            this.P1HoleCard1.Text = "label1";
            // 
            // P1HoleCard2
            // 
            this.P1HoleCard2.AutoSize = true;
            this.P1HoleCard2.Location = new System.Drawing.Point(119, 61);
            this.P1HoleCard2.Name = "P1HoleCard2";
            this.P1HoleCard2.Size = new System.Drawing.Size(38, 15);
            this.P1HoleCard2.TabIndex = 10;
            this.P1HoleCard2.Text = "label2";
            // 
            // P1Amount_To_Bet_textBox
            // 
            this.P1Amount_To_Bet_textBox.Location = new System.Drawing.Point(260, 73);
            this.P1Amount_To_Bet_textBox.Name = "P1Amount_To_Bet_textBox";
            this.P1Amount_To_Bet_textBox.Size = new System.Drawing.Size(100, 23);
            this.P1Amount_To_Bet_textBox.TabIndex = 11;
            // 
            // P1amountToBet_textbox
            // 
            this.P1amountToBet_textbox.Location = new System.Drawing.Point(374, 73);
            this.P1amountToBet_textbox.Name = "P1amountToBet_textbox";
            this.P1amountToBet_textbox.Size = new System.Drawing.Size(75, 23);
            this.P1amountToBet_textbox.TabIndex = 12;
            this.P1amountToBet_textbox.Text = "Place Bet.";
            this.P1amountToBet_textbox.UseVisualStyleBackColor = true;
            this.P1amountToBet_textbox.Click += new System.EventHandler(this.P1PlaceBet_button_Click);
            // 
            // P2amountToBet_textbox
            // 
            this.P2amountToBet_textbox.Location = new System.Drawing.Point(260, 355);
            this.P2amountToBet_textbox.Name = "P2amountToBet_textbox";
            this.P2amountToBet_textbox.Size = new System.Drawing.Size(100, 23);
            this.P2amountToBet_textbox.TabIndex = 13;
            this.P2amountToBet_textbox.TextChanged += new System.EventHandler(this.P2amountToBet_textbox_TextChanged);
            // 
            // P2_placebet_button
            // 
            this.P2_placebet_button.Location = new System.Drawing.Point(374, 352);
            this.P2_placebet_button.Name = "P2_placebet_button";
            this.P2_placebet_button.Size = new System.Drawing.Size(75, 23);
            this.P2_placebet_button.TabIndex = 14;
            this.P2_placebet_button.Text = "Place Bet.";
            this.P2_placebet_button.UseVisualStyleBackColor = true;
            this.P2_placebet_button.Click += new System.EventHandler(this.P2_placebet_button_Click);
            // 
            // P2TotalMoneyLabel
            // 
            this.P2TotalMoneyLabel.AutoSize = true;
            this.P2TotalMoneyLabel.Location = new System.Drawing.Point(30, 373);
            this.P2TotalMoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P2TotalMoneyLabel.Name = "P2TotalMoneyLabel";
            this.P2TotalMoneyLabel.Size = new System.Drawing.Size(38, 15);
            this.P2TotalMoneyLabel.TabIndex = 15;
            this.P2TotalMoneyLabel.Text = "label1";
            // 
            // P1TotalMoneyLabel
            // 
            this.P1TotalMoneyLabel.AutoSize = true;
            this.P1TotalMoneyLabel.Location = new System.Drawing.Point(30, 56);
            this.P1TotalMoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P1TotalMoneyLabel.Name = "P1TotalMoneyLabel";
            this.P1TotalMoneyLabel.Size = new System.Drawing.Size(38, 15);
            this.P1TotalMoneyLabel.TabIndex = 16;
            this.P1TotalMoneyLabel.Text = "label1";
            // 
            // TotalPot
            // 
            this.TotalPot.AutoSize = true;
            this.TotalPot.Location = new System.Drawing.Point(601, 202);
            this.TotalPot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalPot.Name = "TotalPot";
            this.TotalPot.Size = new System.Drawing.Size(0, 15);
            this.TotalPot.TabIndex = 17;
            // 
            // P1_Fold_Button
            // 
            this.P1_Fold_Button.Location = new System.Drawing.Point(372, 34);
            this.P1_Fold_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.P1_Fold_Button.Name = "P1_Fold_Button";
            this.P1_Fold_Button.Size = new System.Drawing.Size(78, 20);
            this.P1_Fold_Button.TabIndex = 18;
            this.P1_Fold_Button.Text = "Fold";
            this.P1_Fold_Button.UseVisualStyleBackColor = true;
            this.P1_Fold_Button.Click += new System.EventHandler(this.P1_Fold_Button_Click);
            // 
            // P2_Fold_Button
            // 
            this.P2_Fold_Button.Location = new System.Drawing.Point(372, 391);
            this.P2_Fold_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.P2_Fold_Button.Name = "P2_Fold_Button";
            this.P2_Fold_Button.Size = new System.Drawing.Size(78, 20);
            this.P2_Fold_Button.TabIndex = 19;
            this.P2_Fold_Button.Text = "Fold";
            this.P2_Fold_Button.UseVisualStyleBackColor = true;
            this.P2_Fold_Button.Click += new System.EventHandler(this.P2_Fold_Button_Click);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Location = new System.Drawing.Point(200, 154);
            this.GameOverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(0, 15);
            this.GameOverLabel.TabIndex = 20;
            // 
            // P1_CheckButton
            // 
            this.P1_CheckButton.Location = new System.Drawing.Point(491, 34);
            this.P1_CheckButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.P1_CheckButton.Name = "P1_CheckButton";
            this.P1_CheckButton.Size = new System.Drawing.Size(78, 20);
            this.P1_CheckButton.TabIndex = 21;
            this.P1_CheckButton.Text = "Check.";
            this.P1_CheckButton.UseVisualStyleBackColor = true;
            this.P1_CheckButton.Click += new System.EventHandler(this.P1Check_button);
            // 
            // P2_Check_Button
            // 
            this.P2_Check_Button.Location = new System.Drawing.Point(491, 391);
            this.P2_Check_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.P2_Check_Button.Name = "P2_Check_Button";
            this.P2_Check_Button.Size = new System.Drawing.Size(78, 20);
            this.P2_Check_Button.TabIndex = 22;
            this.P2_Check_Button.Text = "Check.";
            this.P2_Check_Button.UseVisualStyleBackColor = true;
            this.P2_Check_Button.Click += new System.EventHandler(this.P2_Check_Button_Click);
            // 
            // GameDecisionLabel
            // 
            this.GameDecisionLabel.AutoSize = true;
            this.GameDecisionLabel.Location = new System.Drawing.Point(188, 154);
            this.GameDecisionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameDecisionLabel.Name = "GameDecisionLabel";
            this.GameDecisionLabel.Size = new System.Drawing.Size(0, 15);
            this.GameDecisionLabel.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameDecisionLabel);
            this.Controls.Add(this.P2_Check_Button);
            this.Controls.Add(this.P1_CheckButton);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.P2_Fold_Button);
            this.Controls.Add(this.P1_Fold_Button);
            this.Controls.Add(this.TotalPot);
            this.Controls.Add(this.P1TotalMoneyLabel);
            this.Controls.Add(this.P2TotalMoneyLabel);
            this.Controls.Add(this.P2_placebet_button);
            this.Controls.Add(this.P2amountToBet_textbox);
            this.Controls.Add(this.P1amountToBet_textbox);
            this.Controls.Add(this.P1Amount_To_Bet_textBox);
            this.Controls.Add(this.P1HoleCard2);
            this.Controls.Add(this.P1HoleCard1);
            this.Controls.Add(this.P2HoleCard2);
            this.Controls.Add(this.P2HoleCard1);
            this.Controls.Add(this.commCard5);
            this.Controls.Add(this.commcard4);
            this.Controls.Add(this.commCard3);
            this.Controls.Add(this.commcard2);
            this.Controls.Add(this.commCard1);
            this.Controls.Add(this.ROLB_Player2);
            this.Controls.Add(this.ROLB_Player1);
            this.Name = "Form1";
            this.Text = " Texas Holdem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ROLB_Player1;
        private Label ROLB_Player2;
        private Label commCard1;
        private Label commcard2;
        private Label commCard3;
        private Label commcard4;
        private Label commCard5;
        private Label P2HoleCard1;
        private Label P2HoleCard2;
        private Label P1HoleCard1;
        private Label P1HoleCard2;
        private TextBox P1Amount_To_Bet_textBox;
        private Button P1amountToBet_textbox;
        private TextBox P2amountToBet_textbox;
        private Button P2_placebet_button;
        private Label P2TotalMoneyLabel;
        private Label P1TotalMoneyLabel;
        private Label TotalPot;
        private Button P1_Fold_Button;
        private Button P2_Fold_Button;
        private Label GameOverLabel;
        private Button P1_CheckButton;
        private Button P2_Check_Button;
        private Label GameDecisionLabel;
    }
}