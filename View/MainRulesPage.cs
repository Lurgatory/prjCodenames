﻿using System;
using System.Windows.Forms;

namespace CodenamesGroupProjectWinForms
{
    public partial class MainRulesPage : Form
    {
        public MainRulesPage()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            
            BoardGame newBoardGame = new BoardGame();
            newBoardGame.Show();
            this.Hide();
        }

        private void lblRule2_Click(object sender, EventArgs e)
        {

        }

        private void lblRule1_Click(object sender, EventArgs e)
        {

        }
    }
}
