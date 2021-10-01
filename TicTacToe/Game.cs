using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Game
    {
        public Player CurrentPlayer { get; set; }
        public bool Winner { get; set; }
        public TextBox[,] GameBoard { get; set; }
        public Panel GamePanel { get; set; }
        public List<Player> GamePlayers { get; set; }
        public int NumberClicks { get; set; }
        public TextBox MessageArea { get; set; }

        //default constructor
        public Game() { }

        //overloaded constructor
        public Game(Panel theePanel, TextBox messageArea)
        {
            GamePanel = theePanel;
            GameBoard = new TextBox[3, 3];
            MessageArea = messageArea;
            Winner = false;
            NumberClicks = 0;
            GamePlayers = new List<Player>(3);


            //Create some players
            //todo: create method
            GamePlayers.Add(new Player("Cat"));
            GamePlayers.Add(new Player("Player 1"));
            GamePlayers.Add(new Player("Player 2"));
            //players mark
            GamePlayers[0].Mark = "Paw";
            GamePlayers[1].Mark = "X";
            GamePlayers[2].Mark = "O";

            //current player
            //todo: make random
            CurrentPlayer = GamePlayers[1];

            //Test msg Area
            MessageArea.Text = CurrentPlayer.PlayerName + " Plays first";
        }

        public delegate void EndGame(Player winner);
        public event EndGame ShowWinner;

        public void Start()
        {
            MessageArea.Clear();
            Winner = false;
            NumberClicks = 0;
            GamePanel.Controls.Clear();

            //draw board
            DrawBoard();
        }

        private void DrawBoard()
        {
            int top = 0;
            int left = 0;

            for(int row= 0; row <= GameBoard.GetUpperBound(0); row++)
            {
                left = 0;
                for(int col = 0; col <= GameBoard.GetUpperBound(1); col++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Multiline = true;
                    textBox.ReadOnly = true;
                    textBox.Font = new System.Drawing.Font("Courier New", 60);
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.Size = new System.Drawing.Size(100, 100);
                    //todo: change to none
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Location = new System.Drawing.Point(left, top);
                    GameBoard[row, col] = textBox;

                    //add txtbox to 
                    textBox.Click += TextBox_Click;
                    GamePanel.Controls.Add(textBox);

                    left += 100;
                }
                top += 100;
            }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            //Current player mark
            TextBox clickedBox = (TextBox)sender;
            if (clickedBox.Text == "")
            {
                MessageArea.Clear(); //clears errors out of msg area
                NumberClicks++;
                clickedBox.Text = CurrentPlayer.Mark;

                //check for winner
                Winner = CheckForWin();

                if (NumberClicks <9 && !Winner)
                {
                    //switch player
                    NextPlayer();
                }
                else
                {
                    if(Winner)
                    {
                        MessageArea.Text = CurrentPlayer.PlayerName + " has Won!";//todo: add the number of games won when program can keep track
                        ShowWinner(CurrentPlayer);
                    }
                    else
                    {
                        MessageArea.Text = GamePlayers[0].PlayerName + " has won";
                        ShowWinner(GamePlayers[0]);
                    }
                }
            }
            else 
            {
                MessageArea.Text = "Cant click there, illegal move.";
            }
        }

        private bool CheckForWin()
        {
            return CheckRows() || CheckColumns() || CheckDiagonal();
        }

        private bool CheckRows()
        {
            int rowMarks = 0;
            for(int row = 0; row <= GameBoard.GetUpperBound(0); row++)
            {
                for(int col = 0; col <= GameBoard.GetUpperBound(1); col++)
                {
                    if(GameBoard[row,col].Text == CurrentPlayer.Mark)
                    {
                        rowMarks++;
                    }
                }
                if(rowMarks >= 3)
                {
                    return true;
                }
                else
                {
                    rowMarks = 0;
                }
            }
            return false;
        }

        private bool CheckColumns()
        {
            int columnMarks = 0;
            for (int col = 0; col <= GameBoard.GetUpperBound(1); col++)
            {
                for (int row = 0; row <= GameBoard.GetUpperBound(0); row++)
                {
                    if (GameBoard[row, col].Text == CurrentPlayer.Mark)
                    {
                        columnMarks++;
                    }
                }
                if (columnMarks >= 3)
                {
                    return true;
                }
                else
                {
                    columnMarks = 0;
                }
            }
            return false;
        }

        private bool CheckDiagonal()
        {
            if (GameBoard[0, 0].Text == CurrentPlayer.Mark && GameBoard[1, 1].Text == CurrentPlayer.Mark && GameBoard[2, 2].Text == CurrentPlayer.Mark)
            {
                return true;
            }
            else if(GameBoard[2,0].Text == CurrentPlayer.Mark && GameBoard[1, 1].Text == CurrentPlayer.Mark && GameBoard[0,2].Text == CurrentPlayer.Mark)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void NextPlayer()
        {
            //brute force bby
            if(CurrentPlayer.Mark == GamePlayers[1].Mark)
            {
                CurrentPlayer = GamePlayers[2];
            }
            else
            {
                CurrentPlayer = GamePlayers[1];
            }
        }
    }
}
