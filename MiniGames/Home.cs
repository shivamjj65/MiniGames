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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            GAMEPANEL.Visible = false;
        }
        private void RPS_Click(object sender, EventArgs e)
        {
            GAMEPANEL.Visible = true;
            tictactoe1.Visible = false;
            rps1.Visible = true;
        }
        private void TTT_Click(object sender, EventArgs e)
        {
            GAMEPANEL.Visible = true;
            rps1.Visible = false;
            tictactoe1.Visible = true;
        }
    }
}
