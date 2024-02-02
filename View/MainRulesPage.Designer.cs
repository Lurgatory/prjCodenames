namespace CodenamesGroupProjectWinForms
{
    partial class MainRulesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRulesPage));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRule1 = new System.Windows.Forms.Label();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.lblRule3 = new System.Windows.Forms.Label();
            this.lblRule4 = new System.Windows.Forms.Label();
            this.lblRule5 = new System.Windows.Forms.Label();
            this.lblRule6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 38F);
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(151, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(524, 66);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CODENAMES RULES";
            // 
            // lblRule1
            // 
            this.lblRule1.AutoSize = true;
            this.lblRule1.BackColor = System.Drawing.Color.Transparent;
            this.lblRule1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.lblRule1.ForeColor = System.Drawing.Color.White;
            this.lblRule1.Location = new System.Drawing.Point(19, 71);
            this.lblRule1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRule1.Name = "lblRule1";
            this.lblRule1.Size = new System.Drawing.Size(793, 27);
            this.lblRule1.TabIndex = 1;
            this.lblRule1.Text = "1. Divide players into two teams. Each team will have a spymaster and field agent" +
    "s";
            this.lblRule1.Click += new System.EventHandler(this.lblRule1_Click);
            // 
            // lblRule2
            // 
            this.lblRule2.AutoSize = true;
            this.lblRule2.BackColor = System.Drawing.Color.Transparent;
            this.lblRule2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.lblRule2.ForeColor = System.Drawing.Color.White;
            this.lblRule2.Location = new System.Drawing.Point(19, 109);
            this.lblRule2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRule2.Name = "lblRule2";
            this.lblRule2.Size = new System.Drawing.Size(774, 54);
            this.lblRule2.TabIndex = 2;
            this.lblRule2.Text = "2. There is a 5x5 grid of cards, including 1 assassin,  7 bystanders, 8 field age" +
    "nts \r\non team blue and 9 on team red\r\n";
            this.lblRule2.Click += new System.EventHandler(this.lblRule2_Click);
            // 
            // lblRule3
            // 
            this.lblRule3.BackColor = System.Drawing.Color.Transparent;
            this.lblRule3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.lblRule3.ForeColor = System.Drawing.Color.White;
            this.lblRule3.Location = new System.Drawing.Point(16, 174);
            this.lblRule3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRule3.Name = "lblRule3";
            this.lblRule3.Size = new System.Drawing.Size(762, 89);
            this.lblRule3.TabIndex = 3;
            this.lblRule3.Text = "3.  Each team\'s spymaster can see cards which reveal which codenames correspond t" +
    "o their team\'s agents, it also reveals the location of the assassin card, which " +
    "instantly ends the game if it is chosen";
            // 
            // lblRule4
            // 
            this.lblRule4.BackColor = System.Drawing.Color.Transparent;
            this.lblRule4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.lblRule4.ForeColor = System.Drawing.Color.White;
            this.lblRule4.Location = new System.Drawing.Point(19, 263);
            this.lblRule4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRule4.Name = "lblRule4";
            this.lblRule4.Size = new System.Drawing.Size(762, 73);
            this.lblRule4.TabIndex = 4;
            this.lblRule4.Text = "4. The spymasters can give clues that relate to one or more of their team\'s coden" +
    "ames\r\n";
            // 
            // lblRule5
            // 
            this.lblRule5.AutoSize = true;
            this.lblRule5.BackColor = System.Drawing.Color.Transparent;
            this.lblRule5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.lblRule5.ForeColor = System.Drawing.Color.White;
            this.lblRule5.Location = new System.Drawing.Point(16, 323);
            this.lblRule5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRule5.Name = "lblRule5";
            this.lblRule5.Size = new System.Drawing.Size(820, 81);
            this.lblRule5.TabIndex = 5;
            this.lblRule5.Text = resources.GetString("lblRule5.Text");
            // 
            // lblRule6
            // 
            this.lblRule6.BackColor = System.Drawing.Color.Transparent;
            this.lblRule6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.lblRule6.ForeColor = System.Drawing.Color.White;
            this.lblRule6.Location = new System.Drawing.Point(16, 415);
            this.lblRule6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRule6.Name = "lblRule6";
            this.lblRule6.Size = new System.Drawing.Size(807, 65);
            this.lblRule6.TabIndex = 6;
            this.lblRule6.Text = "6. The game continues until one team has correctly guessed all of their codenames" +
    ", or until one team chooses the assassin card.";
            // 
            // MainRulesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::CodenamesGroupProjectWinForms.Properties.Resources.dgmxybg4kb7eab7x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 491);
            this.Controls.Add(this.lblRule6);
            this.Controls.Add(this.lblRule5);
            this.Controls.Add(this.lblRule4);
            this.Controls.Add(this.lblRule3);
            this.Controls.Add(this.lblRule2);
            this.Controls.Add(this.lblRule1);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainRulesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainRulesPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.Label lblRule3;
        private System.Windows.Forms.Label lblRule4;
        private System.Windows.Forms.Label lblRule5;
        private System.Windows.Forms.Label lblRule6;
    }
}