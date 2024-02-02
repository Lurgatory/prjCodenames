namespace CodenamesGroupProjectWinForms.View
{
    partial class EndGame
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
            this.lblWinningTeamTitlePlaceholder = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinningTeamTitlePlaceholder
            // 
            this.lblWinningTeamTitlePlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblWinningTeamTitlePlaceholder.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F);
            this.lblWinningTeamTitlePlaceholder.ForeColor = System.Drawing.Color.White;
            this.lblWinningTeamTitlePlaceholder.Location = new System.Drawing.Point(11, 129);
            this.lblWinningTeamTitlePlaceholder.Name = "lblWinningTeamTitlePlaceholder";
            this.lblWinningTeamTitlePlaceholder.Size = new System.Drawing.Size(1095, 242);
            this.lblWinningTeamTitlePlaceholder.TabIndex = 0;
            this.lblWinningTeamTitlePlaceholder.Text = "Placeholder winning team";
            this.lblWinningTeamTitlePlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Coral;
            this.btnPlayAgain.Location = new System.Drawing.Point(301, 398);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(190, 57);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Coral;
            this.btnExit.Location = new System.Drawing.Point(596, 398);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodenamesGroupProjectWinForms.Properties.Resources.dgmxybg4kb7eab7x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 679);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblWinningTeamTitlePlaceholder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.Load += new System.EventHandler(this.EndGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWinningTeamTitlePlaceholder;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
    }
}