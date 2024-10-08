﻿using System;
using System.Windows.Forms;
using CodenamesGroupProjectWinForms.Model;

namespace CodenamesGroupProjectWinForms.View
{
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            BoardGame boardGame = new BoardGame();
            boardGame.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            //When displaying the EndGame, the title will change.
            if(BoardGame.winningTeam == "draw")
            {
                lblWinningTeamTitlePlaceholder.Text = "Both Teams ended up in a draw";

            }
            else
            {
                lblWinningTeamTitlePlaceholder.Text = "Congratulations " + BoardGame.winningTeam + ", you won!\n With " + BoardGame.winningTeamPoints + "!";
            }
            
        }
    }
}
