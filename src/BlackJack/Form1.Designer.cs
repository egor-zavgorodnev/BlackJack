namespace BlackJack
{
    partial class BlackJack
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dealerScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxPlayerCards = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.Label();
            this.invisLabel = new System.Windows.Forms.Label();
            this.labelHasA = new System.Windows.Forms.Label();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дилер ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(324, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Очки:";
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.BackColor = System.Drawing.Color.Transparent;
            this.dealerScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dealerScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dealerScore.Location = new System.Drawing.Point(375, 71);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(20, 23);
            this.dealerScore.TabIndex = 2;
            this.dealerScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(325, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Игрок";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playerScore.Location = new System.Drawing.Point(375, 268);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(20, 23);
            this.playerScore.TabIndex = 5;
            this.playerScore.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(324, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Очки:";
            // 
            // HitButton
            // 
            this.HitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HitButton.BackgroundImage")));
            this.HitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HitButton.Location = new System.Drawing.Point(240, 305);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(93, 40);
            this.HitButton.TabIndex = 6;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Visible = false;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // StandButton
            // 
            this.StandButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StandButton.BackgroundImage")));
            this.StandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StandButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StandButton.Location = new System.Drawing.Point(363, 305);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(91, 40);
            this.StandButton.TabIndex = 7;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Visible = false;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info.Location = new System.Drawing.Point(308, 138);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(50, 23);
            this.info.TabIndex = 8;
            this.info.Text = "Black";
            this.info.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newGame
            // 
            this.newGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newGame.BackgroundImage")));
            this.newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newGame.Location = new System.Drawing.Point(534, 9);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(170, 40);
            this.newGame.TabIndex = 12;
            this.newGame.Text = "Новая игра";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(236, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Карты:";
            // 
            // textboxPlayerCards
            // 
            this.textboxPlayerCards.AutoSize = true;
            this.textboxPlayerCards.BackColor = System.Drawing.Color.White;
            this.textboxPlayerCards.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxPlayerCards.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textboxPlayerCards.Location = new System.Drawing.Point(294, 235);
            this.textboxPlayerCards.Name = "textboxPlayerCards";
            this.textboxPlayerCards.Size = new System.Drawing.Size(20, 23);
            this.textboxPlayerCards.TabIndex = 21;
            this.textboxPlayerCards.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(236, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Карты:";
            // 
            // D1
            // 
            this.D1.AutoSize = true;
            this.D1.BackColor = System.Drawing.Color.White;
            this.D1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D1.Location = new System.Drawing.Point(297, 36);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(20, 23);
            this.D1.TabIndex = 23;
            this.D1.Text = "0";
            // 
            // invisLabel
            // 
            this.invisLabel.AutoSize = true;
            this.invisLabel.BackColor = System.Drawing.Color.Transparent;
            this.invisLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invisLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.invisLabel.Location = new System.Drawing.Point(359, 138);
            this.invisLabel.Name = "invisLabel";
            this.invisLabel.Size = new System.Drawing.Size(47, 23);
            this.invisLabel.TabIndex = 24;
            this.invisLabel.Text = "Jack";
            this.invisLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelHasA
            // 
            this.labelHasA.AutoSize = true;
            this.labelHasA.BackColor = System.Drawing.Color.Transparent;
            this.labelHasA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHasA.ForeColor = System.Drawing.Color.Navy;
            this.labelHasA.Location = new System.Drawing.Point(376, 213);
            this.labelHasA.Name = "labelHasA";
            this.labelHasA.Size = new System.Drawing.Size(0, 18);
            this.labelHasA.TabIndex = 25;
            // 
            // buttonSplit
            // 
            this.buttonSplit.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSplit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSplit.Location = new System.Drawing.Point(600, 251);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(91, 40);
            this.buttonSplit.TabIndex = 26;
            this.buttonSplit.Text = "Split";
            this.buttonSplit.UseVisualStyleBackColor = false;
            this.buttonSplit.Visible = false;
            this.buttonSplit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStatistics.BackgroundImage")));
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatistics.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStatistics.Location = new System.Drawing.Point(12, 9);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(98, 40);
            this.buttonStatistics.TabIndex = 27;
            this.buttonStatistics.Text = "Статистика";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(716, 357);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonSplit);
            this.Controls.Add(this.labelHasA);
            this.Controls.Add(this.invisLabel);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textboxPlayerCards);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.info);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "BlackJack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dealerScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label textboxPlayerCards;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label D1;
        private System.Windows.Forms.Label invisLabel;
        private System.Windows.Forms.Label labelHasA;
        private System.Windows.Forms.Button buttonStatistics;
        public System.Windows.Forms.Button HitButton;
        public System.Windows.Forms.Button StandButton;
        public System.Windows.Forms.Button buttonSplit;
    }
}

