using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLibrary.Models;
using TicTacToeLibrary.ViewModels;

namespace WinFormUI
{
    static class Program
    {
        private static GameSession currentGameSession;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            currentGameSession = new GameSession();
            Application.Run(new TicTacToeMainForm(currentGameSession));
        }

    }
}
