using CodenamesGroupProjectWinForms.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodenamesGroupProjectWinForms.Control
{
    public class PublicMethod
    {
        public static void endGame(Codenames gameState, Team blueTeam, Team redTeam, bool assassinPicked = false)
        {
            if (assassinPicked)
            {
                if (gameState.TeamTurn == TeamTurn.red)
                {
                    BoardGame.winningTeam = "blue team";
                    BoardGame.winningTeamPoints = blueTeam.Points;
                }
                else
                {
                    BoardGame.winningTeam = "red team";
                    BoardGame.winningTeamPoints = redTeam.Points;
                }
            }
            else
            {
                if (blueTeam.Points == redTeam.Points)
                {
                    BoardGame.winningTeam = "draw";
                }
                else if (blueTeam.Points > redTeam.Points)
                {
                    BoardGame.winningTeam = "blue team";
                    BoardGame.winningTeamPoints = blueTeam.Points;
                }
                else
                {
                    BoardGame.winningTeam = "red team";
                    BoardGame.winningTeamPoints = redTeam.Points;
                }
            }

        }

        public static void boardState(Card[] roleTypes, List<Button> btn_list,bool isSpymasterTurn)
        {
            if (isSpymasterTurn)
            {
                for (int i = 0; i < 25; i++)
                {
                    switch (roleTypes[i].CardType)
                    {
                        case CardTypes.red:
                            if (roleTypes[i].IsFlipped == false)
                            {
                                btn_list[i].BackColor = Color.Red;
                                btn_list[i].ForeColor = Color.White;
                            }
                            else
                            {
                                btn_list[i].BackColor = Color.Red;
                                btn_list[i].ForeColor = Color.Red;
                            }
                            break;
                        case CardTypes.blue:
                            if (roleTypes[i].IsFlipped == false)
                            {
                                btn_list[i].BackColor = Color.Blue;
                                btn_list[i].ForeColor = Color.White;
                            }
                            else
                            {
                                btn_list[i].BackColor = Color.Blue;
                                btn_list[i].ForeColor = Color.Blue;
                            }
                            break;
                        case CardTypes.assassin:
                            if (roleTypes[i].IsFlipped == false)
                            {
                                btn_list[i].BackColor = Color.Gray;
                                btn_list[i].ForeColor = Color.White;
                            }
                            break;
                        case CardTypes.bystander:
                            if (roleTypes[i].IsFlipped == false)
                            {
                                btn_list[i].BackColor = Color.LightGoldenrodYellow;
                                btn_list[i].ForeColor = Color.Black;
                            }
                            else
                            {
                                btn_list[i].BackColor = Color.LightGoldenrodYellow;
                                btn_list[i].ForeColor = Color.LightGoldenrodYellow;
                            }
                            break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 25; i++)
                {
                    if (roleTypes[i].IsFlipped == false)
                    {
                        btn_list[i].BackColor = Color.LightGoldenrodYellow;
                        btn_list[i].ForeColor = Color.Black;
                    }
                    else
                    {
                        if (roleTypes[i].CardType == CardTypes.red)
                        {
                            btn_list[i].BackColor = Color.Red;
                            btn_list[i].ForeColor = Color.Red;
                        }
                        else if (roleTypes[i].CardType == CardTypes.blue)
                        {
                            btn_list[i].BackColor = Color.Blue;
                            btn_list[i].ForeColor = Color.Blue;
                        }
                        if (roleTypes[i].CardType == CardTypes.bystander)
                        {
                            btn_list[i].BackColor = Color.LightGoldenrodYellow;
                            btn_list[i].ForeColor = Color.LightGoldenrodYellow;
                        }
                    }
                }
            }
        }

        public static void ChangeTurnMessage(Label lblTeamTurn,Label llbRoleTurn, Codenames gameState, Player currentPlayer)
        {
            lblTeamTurn.Text = gameState.TeamTurn == 0 ? "Blue team" : "Red team";
            llbRoleTurn.Text = currentPlayer.Role == 0 ? "Spymaster" : "Field Agents";
            MessageBox.Show("It is now " + (gameState.TeamTurn == 0 ? "Blue team" : "Red team") + " " + (currentPlayer.Role == 0 ? "spymaster" : "field Agent"), "Turn Change", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Load(ref Codenames gameState,ref Player currentPlayer, Label lblTeamTurn, Label llbRoleTurn,ref List<string> btn_words_list, BoardGameWords boardGameWords, List<Button> btn_list,ref Card[] roleTypes)
        {
            //GAMESTATE variable that tracks whose current team turn it is
            //current player variable tracks which type of players turn it is, spymaster or field agent.
            gameState = new Codenames(1);
            currentPlayer = new Player();
            lblTeamTurn.Text = gameState.TeamTurn == 0 ? "Blue team" : "Red team";
            llbRoleTurn.Text = currentPlayer.Role == 0 ? "Spymaster" : "Field Agents";

            //team class tracks the points for each team, we create them on load so that they can update whenever pick card is activated they can update.
            //One tracker for each teams points is created
            Team blueTeamPoints = new Team();
            Team redTeamPoints = new Team();

            btn_words_list = Codenames.GenerateBoard(boardGameWords);          
            try
            {
                for (int i = 0; i < btn_list.Count; i++)
                {
                    btn_list[i].Text = btn_words_list.ElementAt(i);
                }
            }
            catch
            {
                MessageBox.Show("There are not enough words in the list");
            }

            roleTypes = new Card[25];
            Random rnd = rnd = new Random();
            int tempNumber;
            int counterRed = 0;
            int counterBlue = 0;
            int counterAssassin = 0;
            int counterBystander = 0;
            for (int i = 0; i < 25; i++)
            {
                do
                {
                    tempNumber = rnd.Next(0, 4);
                } while ((counterRed == 9 && tempNumber == 0) || (counterBlue == 8 && tempNumber == 1) || (counterAssassin == 1 && tempNumber == 2) || (counterBystander == 7 && tempNumber == 3));

                switch (tempNumber)
                {
                    case 0:
                        counterRed++;
                        Card card = new Card(btn_list[i].Text.ToString(), 0);
                        roleTypes[i] = card;
                        break;
                    case 1:
                        counterBlue++;
                        Card card1 = new Card(btn_list[i].Text.ToString(), 1);
                        roleTypes[i] = card1;
                        break;
                    case 2:
                        counterAssassin++;
                        Card card2 = new Card(btn_list[i].Text.ToString(), 2);
                        roleTypes[i] = card2;
                        break;
                    default:
                        counterBystander++;
                        Card card3 = new Card(btn_list[i].Text.ToString(), 3);
                        roleTypes[i] = card3;
                        break;
                }
            }
        }

    }
}
