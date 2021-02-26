using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLibrary.ViewModels;

namespace WinFormUI
{
    public partial class TicTacToeMainForm : Form
    {
        public GameSession CurrentGameSession { get; private set; }
        private Button clickedButton;
        private bool HasWon = false;

        public TicTacToeMainForm(GameSession gameSession)
        {
            InitializeComponent();
            CurrentGameSession = gameSession;
        }

        private void TicTacToeMainForm_Load(object sender, EventArgs e)
        {
            ClearGameTiles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "")
            {
                clickedButton = button1;
                SetSymbol();
                CheckIfPlayerHasWon();
            }
            if (HasWon == true)
            {
                PlayerWon();
            }
            //Change the symbol to the corresponding players symbol
            //Check if player has won
            //If yes end game
            //If not switch to other player
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                clickedButton = button2;
                SetSymbol();
                CheckIfPlayerHasWon();
            }
            if(HasWon == true)
            {
                PlayerWon();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                clickedButton = button3;
                SetSymbol();
                CheckIfPlayerHasWon();
            }
            if (HasWon == true)
            {
                PlayerWon();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                clickedButton = button4;
                SetSymbol();
                CheckIfPlayerHasWon();
            }
            if (HasWon == true)
            {
                PlayerWon();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                clickedButton = button5;
                SetSymbol();
                CheckIfPlayerHasWon();
            }
            if (HasWon == true)
            {
                PlayerWon();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                clickedButton = button6;
                SetSymbol();
                CheckIfPlayerHasWon();
            }
            if (HasWon == true)
            {
                PlayerWon();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                clickedButton = button7;
                SetSymbol();
                CheckIfPlayerHasWon();
            }
            if (HasWon == true)
            {
                PlayerWon();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                clickedButton = button8;
                SetSymbol();
                CheckIfPlayerHasWon();
            }
            if (HasWon == true)
            {
                PlayerWon();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                clickedButton = button9;
                SetSymbol();
                CheckIfPlayerHasWon();
            }
            if (HasWon == true)
            {
                PlayerWon();
            }
        }

        private void SetSymbol()
        {
            //Get the current symbol from gamesession and set the button clicked to that symbol
            clickedButton.Text = CurrentGameSession.CurrentSymbol;
            CurrentGameSession.ChangePlayer();
            UpdateGameNotificationLabel();
        }

        private void ClearGameTiles()
        {
            //Clear the game tiles
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            gameNotificationLabel.Text = "";
        }

        private void UpdateGameNotificationLabel() 
        {
            gameNotificationLabel.Text = $"Player {CurrentGameSession.CurrentSymbol}'s turn";
        }

        private void CheckIfPlayerHasWon()
        {
            if (button1.Text != "")
            {
                if (button1.Text == button2.Text && button2.Text == button3.Text)
                {
                    HasWon = true;
                }
            }

            if(button4.Text != "")
            {
                if (button4.Text == button5.Text && button5.Text == button6.Text)
                {
                    HasWon = true;
                }
            }

            if(button7.Text != "")
            {
                if (button7.Text == button8.Text && button8.Text == button9.Text)
                {
                    HasWon = true;
                }
            }
            

            if (button1.Text != "")
            {
                if (button1.Text == button4.Text && button4.Text == button7.Text)
                {
                    HasWon = true;
                }
            }
            

            if (button2.Text != "")
            {
                if (button2.Text == button5.Text && button5.Text == button8.Text)
                {
                    HasWon = true;
                }
            }
            

            if (button3.Text != "")
            {
                if (button3.Text == button6.Text && button6.Text == button9.Text)
                {
                    HasWon = true;
                }
            }
            

            if (button1.Text != "")
            {
                if (button1.Text == button5.Text && button5.Text == button9.Text)
                {
                    HasWon = true;
                }
            }
            

            if (button3.Text != "")
            {
                if (button3.Text == button5.Text && button5.Text == button7.Text)
                {
                    HasWon = true;
                }
            }

        }

        private void PlayerWon()
        {
            gameNotificationLabel.Text = $"Player {CurrentGameSession.NextPlayer.GameSymbol} is the Winner!";
            HasWon = false;
            ShowStartGameButton();
        }

        private void ShowStartGameButton()
        {
            startGameButton.Enabled = true;
            startGameButton.Visible = true;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            ClearGameTiles();
            HasWon = true;
            startGameButton.Enabled = false;
            startGameButton.Visible = false;
        }
    }
}
