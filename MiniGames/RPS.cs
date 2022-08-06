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
    public partial class RPS : UserControl
    {
        public RPS()
        {
            InitializeComponent();
        }

        private void CheckResultRPS(string userInput)
        {
            string systemInput;
            int randomNo;
            Random rnd = new Random();
            randomNo = rnd.Next(1, 4);

            if (randomNo == 1)
                systemInput = "Rock";
            else if (randomNo == 2)
                systemInput = "Paper";
            else
                systemInput = "Scissors";

            if (userInput == systemInput)
            {
                Console.WriteLine("Game Tie");
                result.Text = ($"Game Tied, computer has chosen {systemInput} and you have chosen {userInput}");
            }
            
            else if (systemInput == "Rock")
            {
                if (userInput == "Paper")
                {
                    result.Text = ($"You Win, computer has chosen {systemInput} and you have chosen {userInput}");
                }
                else if (userInput == "Scissors")
                {
                    result.Text = ($"You Lose, computer has chosen {systemInput} and you have chosen {userInput}");
                }
            }
            
            else if (systemInput == "Paper") 
            {
                if (userInput == "Scissors")
                {
                    result.Text = ($"You Win, computer has chosen {systemInput} and you have chosen {userInput}");
                }
                else if (userInput == "Rock")
                {
                    result.Text = ($"You Lose, computer has chosen {systemInput} and you have chosen {userInput}");
                }
            }
            
            else if (systemInput == "Scissors")
            {
                if (userInput == "Rock")
                {
                    result.Text = ($"You Win, computer has chosen {systemInput} and you have chosen {userInput}");
                }
                else if (userInput == "Paper")
                {
                    result.Text = ($"You Lose, computer has chosen {systemInput} and you have chosen {userInput}");
                }
            }

        }


        private void Rock_Click_1(object sender, EventArgs e)
        {
            CheckResultRPS("Rock");
        }

        private void Paper_Click_1(object sender, EventArgs e)
        {
            CheckResultRPS("Paper");
        }

        private void Scissors_Click_1(object sender, EventArgs e)
        {
            CheckResultRPS("Scissors");
        }
    }
}
