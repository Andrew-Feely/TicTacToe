using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public string PlayerName { get; set; }
        public string Mark { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }


        public Player() { }

        public Player(string theName)
        {
            PlayerName = theName;
        }
    }
}
