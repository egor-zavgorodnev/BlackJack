namespace BlackJack
{
    partial class StatsForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelDW = new System.Windows.Forms.Label();
            this.labelPW = new System.Windows.Forms.Label();
            this.labelDraws = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.MenuText;
            label1.Location = new System.Drawing.Point(9, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(226, 23);
            label1.TabIndex = 0;
            label1.Text = "Количество побед у дилера:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.MenuText;
            label2.Location = new System.Drawing.Point(12, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(224, 23);
            label2.TabIndex = 1;
            label2.Text = "Количество побед у игрока:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.SystemColors.MenuText;
            label3.Location = new System.Drawing.Point(71, 151);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(164, 23);
            label3.TabIndex = 2;
            label3.Text = "Количество ничьих:";
            // 
            // buttonOK
            // 
            this.buttonOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOK.BackgroundImage")));
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOK.Location = new System.Drawing.Point(12, 227);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(149, 40);
            this.buttonOK.TabIndex = 50;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReset.BackgroundImage")));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReset.Location = new System.Drawing.Point(217, 227);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(217, 40);
            this.buttonReset.TabIndex = 51;
            this.buttonReset.Text = "Сбросить статистику";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelDW
            //  
            this.labelDW.AutoSize = true;
            this.labelDW.BackColor = System.Drawing.Color.Transparent;
            this.labelDW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDW.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDW.Location = new System.Drawing.Point(241, 36);
            this.labelDW.Name = "labelDW";
            this.labelDW.Size = new System.Drawing.Size(20, 23);
            this.labelDW.TabIndex = 52;
            this.labelDW.Text = "0";
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.BackColor = System.Drawing.Color.Transparent;
            this.labelPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPW.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPW.Location = new System.Drawing.Point(241, 93);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(20, 23);
            this.labelPW.TabIndex = 53;
            this.labelPW.Text = "0";
            // 
            // labelDraws
            // 
            this.labelDraws.AutoSize = true;
            this.labelDraws.BackColor = System.Drawing.Color.Transparent;
            this.labelDraws.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDraws.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDraws.Location = new System.Drawing.Point(241, 151);
            this.labelDraws.Name = "labelDraws";
            this.labelDraws.Size = new System.Drawing.Size(20, 23);
            this.labelDraws.TabIndex = 54;
            this.labelDraws.Text = "0";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(446, 279);
            this.Controls.Add(this.labelDraws);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelDW);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelDW;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Label labelDraws;
    }
}