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

    enum Players { circle, cross};

    public partial class Form1 : Form
    {

        bool isMenuOpened = false;
        Players player;
        Point lastPoint;
        short moveCounter;

        public Form1()
        {
            InitializeComponent();
            player = new Players();
            player = Players.circle;
            moveCounter = 0;
        }

        private void label1_Click(object sender, EventArgs e) // reset in menu
        {
            player = Players.circle;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button9.Text = "";
            button8.Text = "";
            panel2.Visible = false;
            label5.Text = "Menu";
            isMenuOpened = !isMenuOpened;
            EnableButtons();
            moveCounter = 0;
        }

        private void label4_Click(object sender, EventArgs e) // X on the right side
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // menu picture
        {
            if (isMenuOpened)
            {
                panel2.Visible = false;
                label5.Text = "Menu";
                isMenuOpened = !isMenuOpened;
            }
            else
            {
                panel2.Visible = true;
                label5.Text = "Close";
                isMenuOpened = !isMenuOpened;
            }
        }

        private void label5_Click(object sender, EventArgs e) // menu text
        {
            if (isMenuOpened)
            {
                panel2.Visible = false;
                label5.Text = "Menu";
                isMenuOpened = !isMenuOpened;
            }
            else
            {
                panel2.Visible = true;
                label5.Text = "Close";
                isMenuOpened = !isMenuOpened;
            }
        }

        private void label3_Click(object sender, EventArgs e) // exit button
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "")
            {
                if(player == Players.circle)
                {
                    button1.Text = "O";
                    player = Players.cross;
                }
                else
                {
                    button1.Text = "X";
                    player = Players.circle;
                }
                CheckWinner();
                moveCounter++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (player == Players.circle)
                {
                    button2.Text = "O";
                    player = Players.cross;
                }
                else
                {
                    button2.Text = "X";
                    player = Players.circle;
                }
                CheckWinner();
                moveCounter++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (player == Players.circle)
                {
                    button3.Text = "O";
                    player = Players.cross;
                }
                else
                {
                    button3.Text = "X";
                    player = Players.circle;
                }
                CheckWinner();
                moveCounter++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (player == Players.circle)
                {
                    button4.Text = "O";
                    player = Players.cross;
                }
                else
                {
                    button4.Text = "X";
                    player = Players.circle;
                }
                CheckWinner();
                moveCounter++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (player == Players.circle)
                {
                    button5.Text = "O";
                    player = Players.cross;
                }
                else
                {
                    button5.Text = "X";
                    player = Players.circle;
                }
                CheckWinner();
                moveCounter++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (player == Players.circle)
                {
                    button6.Text = "O";
                    player = Players.cross;
                }
                else
                {
                    button6.Text = "X";
                    player = Players.circle;
                }
                CheckWinner();
                moveCounter++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (player == Players.circle)
                {
                    button7.Text = "O";
                    player = Players.cross;
                }
                else
                {
                    button7.Text = "X";
                    player = Players.circle;
                }
                CheckWinner();
                moveCounter++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (player == Players.circle)
                {
                    button9.Text = "O";
                    player = Players.cross;
                }
                else
                {
                    button9.Text = "X";
                    player = Players.circle;
                }
                CheckWinner();
                moveCounter++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (player == Players.circle)
                {
                    button8.Text = "O";
                    player = Players.cross;
                }
                else
                {
                    button8.Text = "X";
                    player = Players.circle;
                }
                CheckWinner();
                moveCounter++;
            }
        }

        private void CheckWinner() // checking if someone won, and displaying it
        {
            if (
                (button1.Text == button2.Text && button3.Text == button2.Text && button2.Text != "") ||
                (button4.Text == button5.Text && button6.Text == button5.Text && button5.Text != "") ||
                (button7.Text == button8.Text && button9.Text == button8.Text && button8.Text != "") || //horizontal check
                (button1.Text == button4.Text && button7.Text == button4.Text && button4.Text != "") ||
                (button2.Text == button5.Text && button8.Text == button5.Text && button5.Text != "") ||
                (button3.Text == button6.Text && button9.Text == button6.Text && button6.Text != "") || // vertical check
                (button1.Text == button5.Text && button9.Text == button5.Text && button5.Text != "") ||
                (button3.Text == button5.Text && button7.Text == button5.Text && button5.Text != ""))
                    {
                if(player == Players.circle) { label6.Text = "X has won!"; }
                else { label6.Text = "O has won!"; }
                panel4.Visible = true;
                DisableButtons();
                    }
            else if(moveCounter == 8)
            {
                label6.Text = "It's a draw!";
                panel4.Visible = true;
                DisableButtons();
            }
        }

        private void button10_Click(object sender, EventArgs e) // after winning button
        {
            player = Players.circle;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button9.Text = "";
            button8.Text = "";
            panel4.Visible = false;
            panel2.Visible = false;
            isMenuOpened = false;
            EnableButtons();
            moveCounter = 0;
        }

        private void DisableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        
        private void EnableButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e) // closing credits
        {
            panel5.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e) // Credits
        {
            panel5.Visible = true;
            panel2.Visible = false;
            label5.Text = "Menu";
            isMenuOpened = false;
        }
    }

}
