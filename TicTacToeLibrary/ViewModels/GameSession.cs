using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLibrary.Models;

namespace TicTacToeLibrary.ViewModels
{
    public class GameSession
    {
        private Player playerX;
        private Player playerO;
        private List<Player> players;

        public bool PlayerHasWon { get; set; } = false;
        public string CurrentSymbol { get; private set; }
        public Player CurrentPlayer { get; private set; }
        public Player NextPlayer { get; private set; }

        public GameSession()
        {
            //Initialize all the required game objects
            InitializeGame();

            //Start the game and set the first player
            StartGame();
        }

        private void InitializeGame()
        {
            //Initialize the players and set the game symbols
            playerX = new Player("PlayerX", "X") { IsCurrentTurn = true }; //Set playerX to start first
            playerO = new Player("PlayerO", "O");
            players = new List<Player>();

            players.Add(playerX);
            players.Add(playerO);

        }

        private void StartGame()
        {
            //Sets the current player and the current symbol
            ChangePlayer();
        }

        public string GetNextSymbol()
        {
            //Called when a move is made on the form
            //Return the current symbol
            return CurrentSymbol;
        }

        public void ChangePlayer()
        {
            //Check if it is players turn then set it to current player
            foreach (Player player in players)
            {
                if (player.IsCurrentTurn == true)
                {
                    CurrentPlayer = player;
                    player.IsCurrentTurn = false;
                }
                else
                {
                    NextPlayer = player;
                    player.IsCurrentTurn = true;
                }
            }
            //If it is not their turn set them to be the next player

            ChangeSymbol();
        }

        private void ChangeSymbol()
        {
            CurrentSymbol = CurrentPlayer.GameSymbol;
        }

        private void CheckIfPlayerHasWon()
        {

        }

    }
}
