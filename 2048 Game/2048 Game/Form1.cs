using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_Game
{
    public partial class Form1 : Form
    {
        Label[,] game_board;
        public Form1()
        {
            InitializeComponent();

            game_board = new Label[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    game_board[i, j] = new Label();
                    game_board[i, j].Text = "2";
                    game_board[i, j].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    game_board[i, j].Font = new Font("Tahoma", 32);
                    game_board[i, j].BackColor = Color.LightGray;
                    var margin = game_board[i, j].Margin;
                    margin.All = 4;
                    game_board[i, j].Margin= margin; 
                    game_board[i, j].TextAlign = ContentAlignment.MiddleCenter;


                    tableLayoutPanel1.Controls.Add(game_board[i, j], i, j);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.Up)
            {
                MessageBox.Show("up");
            }
            else if (e.KeyData == Keys.Down)
            {
                MessageBox.Show("down");
            }
            else if (e.KeyData == Keys.Left)
            {
                MessageBox.Show("left");
            }
            else if (e.KeyData == Keys.Right)
            {
                MessageBox.Show("right");
            }
        }
    }
}
