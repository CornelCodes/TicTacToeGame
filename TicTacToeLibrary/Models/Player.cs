using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary.Models
{
    public class Player
    {
        public string Name { get; private set; }
        public string GameSymbol { get; private set; }
        public bool IsCurrentTurn { get; set; } = false;

        public Player(string name, string gameSymbol)
        {
            Name = name;
            GameSymbol = gameSymbol;
        }
    }
}
