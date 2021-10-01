using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Game game = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            game = new Game(pnlBoard, txtMessageArea);
            game.ShowWinner += Game_ShowWinner;
            game.Start();
        }

        private void Game_ShowWinner(Player winner)
        {
            MessageBox.Show(winner.PlayerName + " won as " + winner.Mark);
        }
    }
}
