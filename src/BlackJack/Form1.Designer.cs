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
            this.label6 = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.textboxPlayerCards = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.Label();
            this.labelHasA = new System.Windows.Forms.Label();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.Cards_left = new System.Windows.Forms.Label();
            this.label_Cards_left = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(150, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дилер ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(298, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Очки:";
            this.label2.Visible = false;
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.BackColor = System.Drawing.Color.Transparent;
            this.dealerScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dealerScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dealerScore.Location = new System.Drawing.Point(352, 128);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(20, 23);
            this.dealerScore.TabIndex = 2;
            this.dealerScore.Text = "0";
            this.dealerScore.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(150, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Игрок";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(298, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Очки:";
            this.label6.Visible = false;
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playerScore.Location = new System.Drawing.Point(349, 314);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(20, 23);
            this.playerScore.TabIndex = 5;
            this.playerScore.Text = "0";
            this.playerScore.Visible = false;
            // 
            // HitButton
            // 
            this.HitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HitButton.BackgroundImage")));
            this.HitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HitButton.Location = new System.Drawing.Point(230, 350);
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
            this.StandButton.Location = new System.Drawing.Point(353, 350);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(91, 40);
            this.StandButton.TabIndex = 7;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Visible = false;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubtitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.DarkRed;
            this.labelSubtitle.Location = new System.Drawing.Point(266, 221);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(128, 38);
            this.labelSubtitle.TabIndex = 29;
            this.labelSubtitle.Text = "C# game";
            // 
            // newGame
            // 
            this.newGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newGame.BackgroundImage")));
            this.newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newGame.Location = new System.Drawing.Point(477, 12);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(170, 40);
            this.newGame.TabIndex = 12;
            this.newGame.Text = "Новая игра";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // textboxPlayerCards
            // 
            this.textboxPlayerCards.AutoSize = true;
            this.textboxPlayerCards.BackColor = System.Drawing.Color.White;
            this.textboxPlayerCards.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxPlayerCards.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textboxPlayerCards.Location = new System.Drawing.Point(38, 322);
            this.textboxPlayerCards.Name = "textboxPlayerCards";
            this.textboxPlayerCards.Size = new System.Drawing.Size(20, 23);
            this.textboxPlayerCards.TabIndex = 21;
            this.textboxPlayerCards.Text = "0";
            this.textboxPlayerCards.Visible = false;
            // 
            // D1
            // 
            this.D1.AutoSize = true;
            this.D1.BackColor = System.Drawing.Color.White;
            this.D1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D1.Location = new System.Drawing.Point(12, 322);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(20, 23);
            this.D1.TabIndex = 23;
            this.D1.Text = "0";
            this.D1.Visible = false;
            // 
            // labelHasA
            // 
            this.labelHasA.AutoSize = true;
            this.labelHasA.BackColor = System.Drawing.Color.Transparent;
            this.labelHasA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHasA.ForeColor = System.Drawing.Color.Navy;
            this.labelHasA.Location = new System.Drawing.Point(174, 269);
            this.labelHasA.Name = "labelHasA";
            this.labelHasA.Size = new System.Drawing.Size(0, 18);
            this.labelHasA.TabIndex = 25;
            this.labelHasA.Visible = false;
            // 
            // buttonSplit
            // 
            this.buttonSplit.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSplit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSplit.Location = new System.Drawing.Point(534, 305);
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
            this.buttonStatistics.Location = new System.Drawing.Point(16, 12);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(98, 40);
            this.buttonStatistics.TabIndex = 27;
            this.buttonStatistics.Text = "Статистика";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Visible = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info.Location = new System.Drawing.Point(226, 167);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 23);
            this.info.TabIndex = 8;
            this.info.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.info.Visible = false;
            // 
            // Cards_left
            // 
            this.Cards_left.AutoSize = true;
            this.Cards_left.BackColor = System.Drawing.Color.White;
            this.Cards_left.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cards_left.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cards_left.Location = new System.Drawing.Point(59, 189);
            this.Cards_left.Name = "Cards_left";
            this.Cards_left.Size = new System.Drawing.Size(30, 23);
            this.Cards_left.TabIndex = 30;
            this.Cards_left.Text = "52";
            this.Cards_left.Visible = false;
            // 
            // label_Cards_left
            // 
            this.label_Cards_left.AutoSize = true;
            this.label_Cards_left.BackColor = System.Drawing.Color.Transparent;
            this.label_Cards_left.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Cards_left.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Cards_left.Location = new System.Drawing.Point(12, 156);
            this.label_Cards_left.Name = "label_Cards_left";
            this.label_Cards_left.Size = new System.Drawing.Size(128, 23);
            this.label_Cards_left.TabIndex = 31;
            this.label_Cards_left.Text = "Отсталось карт";
            this.label_Cards_left.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(95, 119);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(485, 108);
            this.labelTitle.TabIndex = 32;
            this.labelTitle.Text = "BlackJack";
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(659, 402);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label_Cards_left);
            this.Controls.Add(this.Cards_left);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonSplit);
            this.Controls.Add(this.labelHasA);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.textboxPlayerCards);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlackJack";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label playerScore;
        public System.Windows.Forms.Button HitButton;
        public System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label textboxPlayerCards;
        private System.Windows.Forms.Label D1;
        private System.Windows.Forms.Label labelHasA;
        public System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.Label info;
        public System.Windows.Forms.Button newGame;
        public System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Label Cards_left;
        private System.Windows.Forms.Label label_Cards_left;
        private System.Windows.Forms.Label labelTitle;
    }
}

