using CodenamesGroupProjectWinForms.Control;
using CodenamesGroupProjectWinForms.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CodenamesGroupProjectWinForms
{
    public partial class BoardGame : Form
    {
        public static string winningTeam;
        public static int winningTeamPoints;
        BoardGameWords boardGameWords = new BoardGameWords();
        List<Button> btn_list;
        List<string> btn_words_list;
        Card[] roleTypes;
        Codenames gameState;
        Player currentPlayer;
        Clue clue;
        int cardsPicked;
        Team redTeam = new Team(), blueTeam = new Team();
        List<Clue> clue_list = new List<Clue>();

        const int TimeToAct = 10;
        int timeLeft = TimeToAct;

        public BoardGame()
        {
            InitializeComponent();

            lblCountDown.Text = timeLeft.ToString();
        }

        //A-- Jiarui
        private void BoardGame_Load(object sender, EventArgs e)
        {
            btn_list = new List<Button>
            {
                btnCard1,btnCard2,btnCard3,btnCard4,btnCard5,btnCard6,btnCard7,btnCard8,btnCard9,btnCard10,btnCard11,btnCard12,btnCard13,btnCard14,btnCard15,btnCard16,btnCard17,btnCard18,btnCard19,btnCard20,btnCard21,btnCard22,btnCard23,btnCard24,btnCard25
            };
            PublicMethod.Load(ref gameState,ref currentPlayer, lblTeamTurn, llbRoleTurn,ref btn_words_list, boardGameWords, btn_list, ref roleTypes);            
            boardState(true);

            gvLog.DataSource = clue_list;
            gvLog.Columns["hint"].HeaderText = "Hints";
            gvLog.Columns["potentialCardNumber"].HeaderText = "Times";
            cbGuess.SelectedIndex = 0;
            gvLog.Enabled = false;
            cbGuess.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSubmitClue_Click(object sender, EventArgs e)
        {
            
            if(currentPlayer.Role == Role.spymaster)
            {
                //Flag to check if the clue passes validations
                bool checker = false;
                int guessNumber = 0;
                string guess = txtClue.Text.Trim();
                List<string> currentWords = boardGameWords.GetBoardWords;
                string validationMessage = "";

                guessNumber = Convert.ToInt32(cbGuess.SelectedItem);
                

                //Clue validation, if it is empty or invalid

                validationMessage = Clue.checkValidity(guess, guessNumber);

                if (validationMessage != "")
                {
                    checker = true;
                    MessageBox.Show(validationMessage, "Invalid Clue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                checker = Codenames.CheckWordList(currentWords, guess);

                if (checker)
                {
                    MessageBox.Show("Clue cannot be part of the words on the board currently visible, please try again", "Invalid clue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Creating the clue if submitted guess and hint number pass all validations
                    txtClue.Text = "";
                    cbGuess.SelectedIndex = 0;
                    clue_list.Add(new Clue(guess, guessNumber));
                    gvLog.DataSource = null;
                    gvLog.DataSource = clue_list;
                    gvLog.Columns["hint"].HeaderText = "Hints";
                    gvLog.Columns["potentialCardNumber"].HeaderText = "Times";
                    clue = Codenames.giveClue(guess, guessNumber + 1);
                    Player.changeRole(currentPlayer);
                    btnSubmitClue.Enabled = false;
                    boardState(false);
                    PublicMethod.ChangeTurnMessage(lblTeamTurn, llbRoleTurn, gameState, currentPlayer);
                    //ChangeTurnMessage();
                    cardsPicked = 1;
                    
                }
            }
        }      
        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            if (!btnSubmitClue.Enabled)
            {
                btnSubmitClue.Enabled = true;
            }
            timer.Stop();
            timeLeft = TimeToAct;
            lblCountDown.Text = timeLeft.ToString();

            Codenames.EndTurn(gameState, currentPlayer);
            if(currentPlayer.Role == Role.spymaster)
            {
                boardState(true);
            }
            else
            {
                boardState(false);
            }
            PublicMethod.ChangeTurnMessage(lblTeamTurn, llbRoleTurn, gameState, currentPlayer);
           // ChangeTurnMessage();
        }

        private void boardState(bool isSpymasterTurn)
        {
            PublicMethod.boardState(roleTypes,btn_list,isSpymasterTurn);
        }

        public void ChangeTurnMessage()
        {
            lblTeamTurn.Text = gameState.TeamTurn == 0 ? "Blue team" : "Red team";
            llbRoleTurn.Text = currentPlayer.Role == 0 ? "Spymaster" : "Field Agents";
            MessageBox.Show("It is now " + (gameState.TeamTurn == 0 ? "Blue team" : "Red team") + " " + (currentPlayer.Role == 0 ? "spymaster" : "field Agent"), "Turn Change", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        

        private void btnStartTimer_Click(object sender, EventArgs e)
        {

            if(!timer.Enabled)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to start the timer?", "Start Timer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    timer.Start();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

           
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft -= 1;
                lblCountDown.Text = timeLeft.ToString();

            }

            else
            {
                timeLeft = TimeToAct;
                lblCountDown.Text = timeLeft.ToString();
                timer.Stop();

                Codenames.EndTurn(gameState, currentPlayer);
                if (currentPlayer.Role == Role.spymaster)
                {
                    boardState(true);
                }
                else
                {
                    boardState(false);
                }
                PublicMethod.ChangeTurnMessage(lblTeamTurn, llbRoleTurn, gameState, currentPlayer);



            }
            
        }
        private void buttonRules_Click(object sender, EventArgs e)
        {
            MainRulesPage rulesPage = new MainRulesPage();
            rulesPage.Show();

        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            endGame();
        }

        public void endGame(bool assassinPicked = false)
        {           
            PublicMethod.endGame(gameState, blueTeam, redTeam);
            this.Hide();
            View.EndGame newForm = new View.EndGame();
            newForm.Show();

        }




        //B-- Shengxiong

        void pickCard(Object sender, EventArgs e)
        {
            // Return early if currentPlayer is a spymaster
            if (currentPlayer.Role == Role.spymaster)
            {
                MessageBox.Show("Error, you can not flip a card as a spymaster", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Button pickedButton = sender as Button;
            int pickedButtonIndex = 0;
            int counter = 0;

            foreach (Button btn in btn_list)
            {
                if (btn == pickedButton)
                {
                    pickedButtonIndex = counter;
                }
                counter++;
            }

            //if red team selects proper card
            if (gameState.TeamTurn == TeamTurn.red && roleTypes[pickedButtonIndex].CardType == CardTypes.red && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
                roleTypes[pickedButtonIndex].IsFlipped = true;
                boardGameWords.RemoveWord(pickedButton.Text);
                redTeam.addPoint();
                lblRedTeamPoints.Text = redTeam.Points.ToString();
                cardsPicked++;
                boardState(false);
                if (redTeam.Points == 9)
                {
                    endGame();
                }
                if (cardsPicked == clue.PotentialCardNumber + 1)
                {
                    btnSubmitClue.Enabled = true;
                    Codenames.changeTeam(gameState);
                    Player.changeRole(currentPlayer);
                    boardState(true);
                    ChangeTurnMessage();
                }
            }
            //If red team select blue team card
            if (gameState.TeamTurn == TeamTurn.red && roleTypes[pickedButtonIndex].CardType == CardTypes.blue && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
                roleTypes[pickedButtonIndex].IsFlipped = true;
                boardGameWords.RemoveWord(pickedButton.Text);
                blueTeam.addPoint();
                lblBlueTeamPoints.Text = blueTeam.Points.ToString();
                cardsPicked++;
                boardState(false);
                if (blueTeam.Points == 8)
                {
                    endGame();
                }
                btnSubmitClue.Enabled = true;
                timer.Stop();
                timeLeft = TimeToAct;
                lblCountDown.Text = timeLeft.ToString();
                Codenames.EndTurn(gameState, currentPlayer);
                boardState(true);
                ChangeTurnMessage();
            }
            //If blue team select proper card
            else if (gameState.TeamTurn == TeamTurn.blue && roleTypes[pickedButtonIndex].CardType == CardTypes.blue && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
                roleTypes[pickedButtonIndex].IsFlipped = true;
                boardGameWords.RemoveWord(pickedButton.Text);
                blueTeam.addPoint();
                lblBlueTeamPoints.Text = blueTeam.Points.ToString();
                cardsPicked++;
                boardState(false);
                if (blueTeam.Points == 8)
                {
                    endGame();
                }
                if (cardsPicked == clue.PotentialCardNumber + 1)
                {
                    btnSubmitClue.Enabled = true;
                    Codenames.changeTeam(gameState);
                    Player.changeRole(currentPlayer);
                    boardState(true);
                    ChangeTurnMessage();
                }
            }
            //If blue team selects red card
            else if (gameState.TeamTurn == TeamTurn.blue && roleTypes[pickedButtonIndex].CardType == CardTypes.red && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
                roleTypes[pickedButtonIndex].IsFlipped = true;
                boardGameWords.RemoveWord(pickedButton.Text);
                redTeam.addPoint();
                lblRedTeamPoints.Text = redTeam.Points.ToString();
                cardsPicked++;
                boardState(false);
                if (redTeam.Points == 9)
                {
                    endGame();
                }
                btnSubmitClue.Enabled = true;
                timer.Stop();
                timeLeft = TimeToAct;
                lblCountDown.Text = timeLeft.ToString();
                Codenames.EndTurn(gameState, currentPlayer);
                boardState(true);
                ChangeTurnMessage();
            }
            //if any team selects the bystander card
            else if (roleTypes[pickedButtonIndex].CardType == CardTypes.bystander && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
                roleTypes[pickedButtonIndex].IsFlipped = true;
                boardGameWords.RemoveWord(pickedButton.Text);
                btnSubmitClue.Enabled = true;
                Codenames.changeTeam(gameState);
                Player.changeRole(currentPlayer);
                boardState(true);
                ChangeTurnMessage();
            }
            // if any team select the assassing card
            else if (roleTypes[pickedButtonIndex].CardType == CardTypes.assassin && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
                endGame(true);
            }
        }


        private void txtGuessAmount_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}


