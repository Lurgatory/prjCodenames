namespace CodenamesGroupProjectWinForms
{
    partial class BoardGame
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
            this.components = new System.ComponentModel.Container();
            this.lblTeamTurn = new System.Windows.Forms.Label();
            this.btnCard1 = new System.Windows.Forms.Button();
            this.btnCard16 = new System.Windows.Forms.Button();
            this.btnCard11 = new System.Windows.Forms.Button();
            this.btnCard6 = new System.Windows.Forms.Button();
            this.btnCard21 = new System.Windows.Forms.Button();
            this.btnCard5 = new System.Windows.Forms.Button();
            this.btnCard4 = new System.Windows.Forms.Button();
            this.btnCard3 = new System.Windows.Forms.Button();
            this.btnCard2 = new System.Windows.Forms.Button();
            this.btnCard7 = new System.Windows.Forms.Button();
            this.btnCard10 = new System.Windows.Forms.Button();
            this.btnCard15 = new System.Windows.Forms.Button();
            this.btnCard20 = new System.Windows.Forms.Button();
            this.btnCard25 = new System.Windows.Forms.Button();
            this.btnCard24 = new System.Windows.Forms.Button();
            this.btnCard23 = new System.Windows.Forms.Button();
            this.btnCard22 = new System.Windows.Forms.Button();
            this.btnCard13 = new System.Windows.Forms.Button();
            this.btnCard8 = new System.Windows.Forms.Button();
            this.btnCard17 = new System.Windows.Forms.Button();
            this.btnCard12 = new System.Windows.Forms.Button();
            this.btnCard9 = new System.Windows.Forms.Button();
            this.btnCard19 = new System.Windows.Forms.Button();
            this.btnCard18 = new System.Windows.Forms.Button();
            this.btnCard14 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llbRoleTurn = new System.Windows.Forms.Label();
            this.lblClue = new System.Windows.Forms.Label();
            this.txtClue = new System.Windows.Forms.TextBox();
            this.lblGuessAmount = new System.Windows.Forms.Label();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnSubmitClue = new System.Windows.Forms.Button();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRedTeamPoints = new System.Windows.Forms.Label();
            this.lblBlueTeamPoints = new System.Windows.Forms.Label();
            this.cbGuess = new System.Windows.Forms.ComboBox();
            this.gvLog = new System.Windows.Forms.DataGridView();
            this.btnRules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeamTurn
            // 
            this.lblTeamTurn.AutoSize = true;
            this.lblTeamTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamTurn.Font = new System.Drawing.Font("Microsoft YaHei UI", 28F);
            this.lblTeamTurn.ForeColor = System.Drawing.Color.White;
            this.lblTeamTurn.Location = new System.Drawing.Point(18, 5);
            this.lblTeamTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamTurn.Name = "lblTeamTurn";
            this.lblTeamTurn.Size = new System.Drawing.Size(209, 50);
            this.lblTeamTurn.TabIndex = 0;
            this.lblTeamTurn.Text = "Team turn";
            // 
            // btnCard1
            // 
            this.btnCard1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard1.Location = new System.Drawing.Point(26, 86);
            this.btnCard1.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard1.Name = "btnCard1";
            this.btnCard1.Size = new System.Drawing.Size(127, 73);
            this.btnCard1.TabIndex = 1;
            this.btnCard1.Text = "button1";
            this.btnCard1.UseVisualStyleBackColor = false;
            this.btnCard1.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard16
            // 
            this.btnCard16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard16.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard16.Location = new System.Drawing.Point(26, 315);
            this.btnCard16.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard16.Name = "btnCard16";
            this.btnCard16.Size = new System.Drawing.Size(127, 73);
            this.btnCard16.TabIndex = 2;
            this.btnCard16.Text = "button2";
            this.btnCard16.UseVisualStyleBackColor = false;
            this.btnCard16.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard11
            // 
            this.btnCard11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard11.Location = new System.Drawing.Point(26, 238);
            this.btnCard11.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard11.Name = "btnCard11";
            this.btnCard11.Size = new System.Drawing.Size(127, 73);
            this.btnCard11.TabIndex = 3;
            this.btnCard11.Text = "button3";
            this.btnCard11.UseVisualStyleBackColor = false;
            this.btnCard11.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard6
            // 
            this.btnCard6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard6.Location = new System.Drawing.Point(26, 161);
            this.btnCard6.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard6.Name = "btnCard6";
            this.btnCard6.Size = new System.Drawing.Size(127, 73);
            this.btnCard6.TabIndex = 4;
            this.btnCard6.Text = "button4";
            this.btnCard6.UseVisualStyleBackColor = false;
            this.btnCard6.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard21
            // 
            this.btnCard21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard21.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard21.Location = new System.Drawing.Point(26, 392);
            this.btnCard21.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard21.Name = "btnCard21";
            this.btnCard21.Size = new System.Drawing.Size(127, 73);
            this.btnCard21.TabIndex = 5;
            this.btnCard21.Text = "button5";
            this.btnCard21.UseVisualStyleBackColor = false;
            this.btnCard21.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard5
            // 
            this.btnCard5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard5.Location = new System.Drawing.Point(546, 86);
            this.btnCard5.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard5.Name = "btnCard5";
            this.btnCard5.Size = new System.Drawing.Size(127, 73);
            this.btnCard5.TabIndex = 6;
            this.btnCard5.Text = "button6";
            this.btnCard5.UseVisualStyleBackColor = false;
            this.btnCard5.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard4
            // 
            this.btnCard4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard4.Location = new System.Drawing.Point(416, 86);
            this.btnCard4.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard4.Name = "btnCard4";
            this.btnCard4.Size = new System.Drawing.Size(127, 73);
            this.btnCard4.TabIndex = 7;
            this.btnCard4.Text = "button7";
            this.btnCard4.UseVisualStyleBackColor = false;
            this.btnCard4.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard3
            // 
            this.btnCard3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard3.Location = new System.Drawing.Point(286, 86);
            this.btnCard3.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard3.Name = "btnCard3";
            this.btnCard3.Size = new System.Drawing.Size(127, 73);
            this.btnCard3.TabIndex = 8;
            this.btnCard3.Text = "button8";
            this.btnCard3.UseVisualStyleBackColor = false;
            this.btnCard3.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard2
            // 
            this.btnCard2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard2.Location = new System.Drawing.Point(156, 86);
            this.btnCard2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard2.Name = "btnCard2";
            this.btnCard2.Size = new System.Drawing.Size(127, 73);
            this.btnCard2.TabIndex = 9;
            this.btnCard2.Text = "button9";
            this.btnCard2.UseVisualStyleBackColor = false;
            this.btnCard2.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard7
            // 
            this.btnCard7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard7.Location = new System.Drawing.Point(156, 161);
            this.btnCard7.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard7.Name = "btnCard7";
            this.btnCard7.Size = new System.Drawing.Size(127, 73);
            this.btnCard7.TabIndex = 10;
            this.btnCard7.Text = "button10";
            this.btnCard7.UseVisualStyleBackColor = false;
            this.btnCard7.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard10
            // 
            this.btnCard10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard10.Location = new System.Drawing.Point(546, 161);
            this.btnCard10.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard10.Name = "btnCard10";
            this.btnCard10.Size = new System.Drawing.Size(127, 73);
            this.btnCard10.TabIndex = 11;
            this.btnCard10.Text = "button11";
            this.btnCard10.UseVisualStyleBackColor = false;
            this.btnCard10.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard15
            // 
            this.btnCard15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard15.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard15.Location = new System.Drawing.Point(546, 238);
            this.btnCard15.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard15.Name = "btnCard15";
            this.btnCard15.Size = new System.Drawing.Size(127, 73);
            this.btnCard15.TabIndex = 12;
            this.btnCard15.Text = "button12";
            this.btnCard15.UseVisualStyleBackColor = false;
            this.btnCard15.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard20
            // 
            this.btnCard20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard20.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard20.Location = new System.Drawing.Point(546, 315);
            this.btnCard20.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard20.Name = "btnCard20";
            this.btnCard20.Size = new System.Drawing.Size(127, 73);
            this.btnCard20.TabIndex = 13;
            this.btnCard20.Text = "button13";
            this.btnCard20.UseVisualStyleBackColor = false;
            this.btnCard20.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard25
            // 
            this.btnCard25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard25.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard25.Location = new System.Drawing.Point(546, 392);
            this.btnCard25.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard25.Name = "btnCard25";
            this.btnCard25.Size = new System.Drawing.Size(127, 73);
            this.btnCard25.TabIndex = 14;
            this.btnCard25.Text = "button14";
            this.btnCard25.UseVisualStyleBackColor = false;
            this.btnCard25.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard24
            // 
            this.btnCard24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard24.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard24.Location = new System.Drawing.Point(416, 392);
            this.btnCard24.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard24.Name = "btnCard24";
            this.btnCard24.Size = new System.Drawing.Size(127, 73);
            this.btnCard24.TabIndex = 15;
            this.btnCard24.Text = "button15";
            this.btnCard24.UseVisualStyleBackColor = false;
            this.btnCard24.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard23
            // 
            this.btnCard23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard23.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard23.Location = new System.Drawing.Point(286, 392);
            this.btnCard23.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard23.Name = "btnCard23";
            this.btnCard23.Size = new System.Drawing.Size(127, 73);
            this.btnCard23.TabIndex = 16;
            this.btnCard23.Text = "button16";
            this.btnCard23.UseVisualStyleBackColor = false;
            this.btnCard23.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard22
            // 
            this.btnCard22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard22.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard22.Location = new System.Drawing.Point(156, 392);
            this.btnCard22.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard22.Name = "btnCard22";
            this.btnCard22.Size = new System.Drawing.Size(127, 73);
            this.btnCard22.TabIndex = 17;
            this.btnCard22.Text = "button17";
            this.btnCard22.UseVisualStyleBackColor = false;
            this.btnCard22.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard13
            // 
            this.btnCard13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard13.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard13.Location = new System.Drawing.Point(286, 238);
            this.btnCard13.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard13.Name = "btnCard13";
            this.btnCard13.Size = new System.Drawing.Size(127, 73);
            this.btnCard13.TabIndex = 18;
            this.btnCard13.Text = "button18";
            this.btnCard13.UseVisualStyleBackColor = false;
            this.btnCard13.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard8
            // 
            this.btnCard8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard8.Location = new System.Drawing.Point(286, 161);
            this.btnCard8.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard8.Name = "btnCard8";
            this.btnCard8.Size = new System.Drawing.Size(127, 73);
            this.btnCard8.TabIndex = 19;
            this.btnCard8.Text = "button19";
            this.btnCard8.UseVisualStyleBackColor = false;
            this.btnCard8.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard17
            // 
            this.btnCard17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard17.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard17.Location = new System.Drawing.Point(156, 315);
            this.btnCard17.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard17.Name = "btnCard17";
            this.btnCard17.Size = new System.Drawing.Size(127, 73);
            this.btnCard17.TabIndex = 20;
            this.btnCard17.Text = "button20";
            this.btnCard17.UseVisualStyleBackColor = false;
            this.btnCard17.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard12
            // 
            this.btnCard12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard12.Location = new System.Drawing.Point(156, 238);
            this.btnCard12.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard12.Name = "btnCard12";
            this.btnCard12.Size = new System.Drawing.Size(127, 73);
            this.btnCard12.TabIndex = 21;
            this.btnCard12.Text = "button21";
            this.btnCard12.UseVisualStyleBackColor = false;
            this.btnCard12.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard9
            // 
            this.btnCard9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard9.Location = new System.Drawing.Point(416, 161);
            this.btnCard9.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard9.Name = "btnCard9";
            this.btnCard9.Size = new System.Drawing.Size(127, 73);
            this.btnCard9.TabIndex = 22;
            this.btnCard9.Text = "button22";
            this.btnCard9.UseVisualStyleBackColor = false;
            this.btnCard9.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard19
            // 
            this.btnCard19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard19.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard19.Location = new System.Drawing.Point(416, 315);
            this.btnCard19.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard19.Name = "btnCard19";
            this.btnCard19.Size = new System.Drawing.Size(127, 73);
            this.btnCard19.TabIndex = 23;
            this.btnCard19.Text = "button23";
            this.btnCard19.UseVisualStyleBackColor = false;
            this.btnCard19.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard18
            // 
            this.btnCard18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard18.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard18.Location = new System.Drawing.Point(286, 315);
            this.btnCard18.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard18.Name = "btnCard18";
            this.btnCard18.Size = new System.Drawing.Size(127, 73);
            this.btnCard18.TabIndex = 24;
            this.btnCard18.Text = "button24";
            this.btnCard18.UseVisualStyleBackColor = false;
            this.btnCard18.Click += new System.EventHandler(this.pickCard);
            // 
            // btnCard14
            // 
            this.btnCard14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCard14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCard14.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCard14.Location = new System.Drawing.Point(416, 238);
            this.btnCard14.Margin = new System.Windows.Forms.Padding(2);
            this.btnCard14.Name = "btnCard14";
            this.btnCard14.Size = new System.Drawing.Size(127, 73);
            this.btnCard14.TabIndex = 25;
            this.btnCard14.Text = "button25";
            this.btnCard14.UseVisualStyleBackColor = false;
            this.btnCard14.Click += new System.EventHandler(this.pickCard);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 27;
            // 
            // llbRoleTurn
            // 
            this.llbRoleTurn.AutoSize = true;
            this.llbRoleTurn.BackColor = System.Drawing.Color.Transparent;
            this.llbRoleTurn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.llbRoleTurn.ForeColor = System.Drawing.Color.White;
            this.llbRoleTurn.Location = new System.Drawing.Point(212, 15);
            this.llbRoleTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbRoleTurn.Name = "llbRoleTurn";
            this.llbRoleTurn.Size = new System.Drawing.Size(158, 35);
            this.llbRoleTurn.TabIndex = 28;
            this.llbRoleTurn.Text = "\"Role turn\"";
            // 
            // lblClue
            // 
            this.lblClue.AutoSize = true;
            this.lblClue.BackColor = System.Drawing.Color.Transparent;
            this.lblClue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.lblClue.ForeColor = System.Drawing.Color.White;
            this.lblClue.Location = new System.Drawing.Point(695, 47);
            this.lblClue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClue.Name = "lblClue";
            this.lblClue.Size = new System.Drawing.Size(45, 20);
            this.lblClue.TabIndex = 29;
            this.lblClue.Text = "Clue:";
            // 
            // txtClue
            // 
            this.txtClue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtClue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClue.Location = new System.Drawing.Point(746, 47);
            this.txtClue.Margin = new System.Windows.Forms.Padding(2);
            this.txtClue.Name = "txtClue";
            this.txtClue.Size = new System.Drawing.Size(176, 23);
            this.txtClue.TabIndex = 30;
            // 
            // lblGuessAmount
            // 
            this.lblGuessAmount.AutoSize = true;
            this.lblGuessAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblGuessAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.lblGuessAmount.ForeColor = System.Drawing.Color.White;
            this.lblGuessAmount.Location = new System.Drawing.Point(695, 85);
            this.lblGuessAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuessAmount.Name = "lblGuessAmount";
            this.lblGuessAmount.Size = new System.Drawing.Size(119, 20);
            this.lblGuessAmount.TabIndex = 31;
            this.lblGuessAmount.Text = "Guess Amount:";
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.BackColor = System.Drawing.Color.Coral;
            this.btnEndTurn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEndTurn.Location = new System.Drawing.Point(689, 161);
            this.btnEndTurn.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(100, 28);
            this.btnEndTurn.TabIndex = 33;
            this.btnEndTurn.Text = "End turn";
            this.btnEndTurn.UseVisualStyleBackColor = false;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.Coral;
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnStartTimer.Location = new System.Drawing.Point(746, 11);
            this.btnStartTimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(100, 28);
            this.btnStartTimer.TabIndex = 34;
            this.btnStartTimer.Text = "Start Timer";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.Coral;
            this.btnEndGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEndGame.Location = new System.Drawing.Point(834, 161);
            this.btnEndGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(100, 28);
            this.btnEndGame.TabIndex = 35;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnSubmitClue
            // 
            this.btnSubmitClue.BackColor = System.Drawing.Color.Coral;
            this.btnSubmitClue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubmitClue.Location = new System.Drawing.Point(761, 122);
            this.btnSubmitClue.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitClue.Name = "btnSubmitClue";
            this.btnSubmitClue.Size = new System.Drawing.Size(100, 28);
            this.btnSubmitClue.TabIndex = 36;
            this.btnSubmitClue.Text = "Submit clue";
            this.btnSubmitClue.UseVisualStyleBackColor = false;
            this.btnSubmitClue.Click += new System.EventHandler(this.btnSubmitClue_Click);
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.BackColor = System.Drawing.Color.Coral;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCountDown.Location = new System.Drawing.Point(851, 17);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(51, 19);
            this.lblCountDown.TabIndex = 37;
            this.lblCountDown.Text = "label1";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Red Team Points:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Blue Team Points:";
            // 
            // lblRedTeamPoints
            // 
            this.lblRedTeamPoints.AutoSize = true;
            this.lblRedTeamPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedTeamPoints.Location = new System.Drawing.Point(569, 15);
            this.lblRedTeamPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRedTeamPoints.Name = "lblRedTeamPoints";
            this.lblRedTeamPoints.Size = new System.Drawing.Size(16, 17);
            this.lblRedTeamPoints.TabIndex = 40;
            this.lblRedTeamPoints.Text = "0";
            // 
            // lblBlueTeamPoints
            // 
            this.lblBlueTeamPoints.AutoSize = true;
            this.lblBlueTeamPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueTeamPoints.Location = new System.Drawing.Point(569, 47);
            this.lblBlueTeamPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlueTeamPoints.Name = "lblBlueTeamPoints";
            this.lblBlueTeamPoints.Size = new System.Drawing.Size(16, 17);
            this.lblBlueTeamPoints.TabIndex = 42;
            this.lblBlueTeamPoints.Text = "0";
            // 
            // cbGuess
            // 
            this.cbGuess.FormattingEnabled = true;
            this.cbGuess.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbGuess.Location = new System.Drawing.Point(819, 87);
            this.cbGuess.Name = "cbGuess";
            this.cbGuess.Size = new System.Drawing.Size(103, 21);
            this.cbGuess.TabIndex = 43;
            // 
            // gvLog
            // 
            this.gvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLog.Location = new System.Drawing.Point(689, 200);
            this.gvLog.Name = "gvLog";
            this.gvLog.Size = new System.Drawing.Size(245, 265);
            this.gvLog.TabIndex = 44;
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Coral;
            this.btnRules.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRules.Location = new System.Drawing.Point(615, 11);
            this.btnRules.Margin = new System.Windows.Forms.Padding(2);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(93, 28);
            this.btnRules.TabIndex = 45;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // BoardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodenamesGroupProjectWinForms.Properties.Resources.dgmxybg4kb7eab7x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 525);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.gvLog);
            this.Controls.Add(this.cbGuess);
            this.Controls.Add(this.lblBlueTeamPoints);
            this.Controls.Add(this.lblRedTeamPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.btnSubmitClue);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.lblGuessAmount);
            this.Controls.Add(this.txtClue);
            this.Controls.Add(this.lblClue);
            this.Controls.Add(this.llbRoleTurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCard14);
            this.Controls.Add(this.btnCard18);
            this.Controls.Add(this.btnCard19);
            this.Controls.Add(this.btnCard9);
            this.Controls.Add(this.btnCard12);
            this.Controls.Add(this.btnCard17);
            this.Controls.Add(this.btnCard8);
            this.Controls.Add(this.btnCard13);
            this.Controls.Add(this.btnCard22);
            this.Controls.Add(this.btnCard23);
            this.Controls.Add(this.btnCard24);
            this.Controls.Add(this.btnCard25);
            this.Controls.Add(this.btnCard20);
            this.Controls.Add(this.btnCard15);
            this.Controls.Add(this.btnCard10);
            this.Controls.Add(this.btnCard7);
            this.Controls.Add(this.btnCard2);
            this.Controls.Add(this.btnCard3);
            this.Controls.Add(this.btnCard4);
            this.Controls.Add(this.btnCard5);
            this.Controls.Add(this.btnCard21);
            this.Controls.Add(this.btnCard6);
            this.Controls.Add(this.btnCard11);
            this.Controls.Add(this.btnCard16);
            this.Controls.Add(this.btnCard1);
            this.Controls.Add(this.lblTeamTurn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BoardGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoardGame";
            this.Load += new System.EventHandler(this.BoardGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamTurn;
        private System.Windows.Forms.Button btnCard1;
        private System.Windows.Forms.Button btnCard16;
        private System.Windows.Forms.Button btnCard11;
        private System.Windows.Forms.Button btnCard6;
        private System.Windows.Forms.Button btnCard21;
        private System.Windows.Forms.Button btnCard5;
        private System.Windows.Forms.Button btnCard4;
        private System.Windows.Forms.Button btnCard3;
        private System.Windows.Forms.Button btnCard2;
        private System.Windows.Forms.Button btnCard7;
        private System.Windows.Forms.Button btnCard10;
        private System.Windows.Forms.Button btnCard15;
        private System.Windows.Forms.Button btnCard20;
        private System.Windows.Forms.Button btnCard25;
        private System.Windows.Forms.Button btnCard24;
        private System.Windows.Forms.Button btnCard23;
        private System.Windows.Forms.Button btnCard22;
        private System.Windows.Forms.Button btnCard13;
        private System.Windows.Forms.Button btnCard8;
        private System.Windows.Forms.Button btnCard17;
        private System.Windows.Forms.Button btnCard12;
        private System.Windows.Forms.Button btnCard9;
        private System.Windows.Forms.Button btnCard19;
        private System.Windows.Forms.Button btnCard18;
        private System.Windows.Forms.Button btnCard14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label llbRoleTurn;
        private System.Windows.Forms.Label lblClue;
        private System.Windows.Forms.TextBox txtClue;
        private System.Windows.Forms.Label lblGuessAmount;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Button btnSubmitClue;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRedTeamPoints;
        private System.Windows.Forms.Label lblBlueTeamPoints;
        private System.Windows.Forms.ComboBox cbGuess;
        private System.Windows.Forms.DataGridView gvLog;
        private System.Windows.Forms.Button btnRules;
    }
}