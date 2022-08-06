using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class TicTacToe : UserControl
    {
        public TicTacToe()
        {
            InitializeComponent();
            int randomNo;
            Random rnd = new Random();
            randomNo = rnd.Next(1, 10);
        }

        string Player1 = ".";
        string Player2 = ".";
        private void btnX_Click(object sender, EventArgs e)
        {
            string Player1 = "X";
            string Player2 = "O";
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            string Player1 = "O";
            string Player2 = "X";
        }



        /*public static void RunLogic()
        {
            string[,] Board = new string[3, 3];
            int Rows = 3;
            int Columns = 3;
            string Player1 = ".";
            string Player2 = ".";
            
            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Columns; j++)
                {
                    Board[i, j] = ".";
                }
            }

            while (!GameOver(Board, ref Player1) && !GameOver(Board, ref Player2))
            {
                PlayGame(Board, Rows, Columns, ref Player1, ref Player2);
            }
        }


        public static void PlayGame(string[,] board, int rows, int columns, ref string player1, ref string player2)
        {
            SetPosition(board, player1);
            SetPosition(board, player2);
        }

        public static void SetPosition(string[,] board, string player)
        {
            Console.WriteLine($"player {player} choose a row (0-2):");
            int playerRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"player {player} choose a column (0-2):");
            int playerColumn = Convert.ToInt32(Console.ReadLine());

            board[playerRow, playerColumn] = player;
        }

        public static bool GameOver(string[,] board, ref string player)
        {
            string TopRow = board[0, 0] + board[0, 1] + board[0, 2];
            string MidRow = board[1, 0] + board[1, 1] + board[1, 2];
            string BotRow = board[2, 0] + board[2, 1] + board[2, 2];
            string FirCol = board[0, 0] + board[1, 0] + board[2, 0];
            string SecCol = board[0, 1] + board[1, 1] + board[2, 1];
            string ThiCol = board[0, 2] + board[1, 2] + board[2, 2];
            string Diagon = board[0, 0] + board[1, 1] + board[2, 2];
            string RevDia = board[0, 2] + board[1, 1] + board[2, 0];

            string playerTriple = player + player + player;

            if (TopRow.Equals(playerTriple)
                || MidRow.Equals(playerTriple)
                || BotRow.Equals(playerTriple)
                || FirCol.Equals(playerTriple)
                || SecCol.Equals(playerTriple)
                || ThiCol.Equals(playerTriple)
                || Diagon.Equals(playerTriple)
                || RevDia.Equals(playerTriple)
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
