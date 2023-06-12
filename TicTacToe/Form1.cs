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

        int playeronewins = 0, playertwowins = 0, jogadas = 0;

        private void btn2_Click(object sender, EventArgs e)
        {
            if (jogadas % 2 == 0)
            {
                btn2.Text = "X";
                lblPlayerTime.Text = "Vez de: Player 2 (O).";
                lblPlayerTime.ForeColor = Color.LimeGreen;
            }
            else
            {
                btn2.Text = "O";
                lblPlayerTime.Text = "Vez de: Player 1 (X).";
                lblPlayerTime.ForeColor = Color.Red;
            }
            jogadas++;

            btn2.Enabled = false;
            Testar();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (jogadas % 2 == 0)
            {
                btn3.Text = "X";
                lblPlayerTime.Text = "Vez de: Player 2 (O).";
                lblPlayerTime.ForeColor = Color.LimeGreen;
            }
            else
            {
                btn3.Text = "O";
                lblPlayerTime.Text = "Vez de: Player 1 (X).";
                lblPlayerTime.ForeColor = Color.Red;
            }
            jogadas++;

            btn3.Enabled = false;
            Testar();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (jogadas % 2 == 0)
            {
                btn4.Text = "X";
                lblPlayerTime.Text = "Vez de: Player 2 (O).";
                lblPlayerTime.ForeColor = Color.LimeGreen;
            }
            else
            {
                btn4.Text = "O";
                lblPlayerTime.Text = "Vez de: Player 1 (X).";
                lblPlayerTime.ForeColor = Color.Red;
            }
            jogadas++;

            btn4.Enabled = false;
            Testar();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (jogadas % 2 == 0)
            {
                btn5.Text = "X";
                lblPlayerTime.Text = "Vez de: Player 2 (O).";
                lblPlayerTime.ForeColor = Color.LimeGreen;
            }
            else
            {
                btn5.Text = "O";
                lblPlayerTime.Text = "Vez de: Player 1 (X).";
                lblPlayerTime.ForeColor = Color.Red;
            }
            jogadas++;

            btn5.Enabled = false;
            Testar();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (jogadas % 2 == 0)
            {
                btn6.Text = "X";
                lblPlayerTime.Text = "Vez de: Player 2 (O).";
                lblPlayerTime.ForeColor = Color.LimeGreen;
            }
            else
            {
                btn6.Text = "O";
                lblPlayerTime.Text = "Vez de: Player 1 (X).";
                lblPlayerTime.ForeColor = Color.Red;
            }
            jogadas++;

            btn6.Enabled = false;
            Testar();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (jogadas % 2 == 0)
            {
                btn7.Text = "X";
                lblPlayerTime.Text = "Vez de: Player 2 (O).";
                lblPlayerTime.ForeColor = Color.LimeGreen;
            }
            else
            {
                btn7.Text = "O";
                lblPlayerTime.Text = "Vez de: Player 1 (X).";
                lblPlayerTime.ForeColor = Color.Red;
            }
            jogadas++;

            btn7.Enabled = false;
            Testar();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (jogadas % 2 == 0)
            {
                btn8.Text = "X";
                lblPlayerTime.Text = "Vez de: Player 2 (O).";
                lblPlayerTime.ForeColor = Color.LimeGreen;
            }
            else
            {
                btn8.Text = "O";
                lblPlayerTime.Text = "Vez de: Player 1 (X).";
                lblPlayerTime.ForeColor = Color.Red;
            }
            jogadas++;

            btn8.Enabled = false;
            Testar();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (jogadas % 2 == 0)
            {
                btn9.Text = "X";
                lblPlayerTime.Text = "Vez de: Player 2 (O).";
                lblPlayerTime.ForeColor = Color.LimeGreen;
            }
            else
            {
                btn9.Text = "O";
                lblPlayerTime.Text = "Vez de: Player 1 (X).";
                lblPlayerTime.ForeColor = Color.Red;
            }
            jogadas++;

            btn9.Enabled = false;
            Testar();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (jogadas % 2 == 0)
            {
                btn1.Text = "X";
                lblPlayerTime.Text = "Vez de: Player 2 (O).";
                lblPlayerTime.ForeColor = Color.LimeGreen;
            }
            else
            {
                btn1.Text = "O";
                lblPlayerTime.Text = "Vez de: Player 1 (X).";
                lblPlayerTime.ForeColor = Color.Red;
            }
            jogadas++;

            btn1.Enabled = false;
            Testar();
        }

        public void Testar()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                MessageBox.Show("Player 1 GANHOU!");
                playeronewins++;
                lblplayerone.Text = "Player 1: " + playeronewins;
                Limpar();
            }
            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("Player 1 GANHOU!");
                playeronewins++;
                lblplayerone.Text = "Player 1: " + playeronewins;
                Limpar();
            }
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Player 1 GANHOU!");
                playeronewins++;
                lblplayerone.Text = "Player 1: " + playeronewins;
                Limpar();
            }
            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("Player 1 GANHOU!");
                playeronewins++;
                lblplayerone.Text = "Player 1: " + playeronewins;
                Limpar();
            }
            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Player 1 GANHOU!");
                playeronewins++;
                lblplayerone.Text = "Player 1: " + playeronewins;
                Limpar();
            }
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Player 1 GANHOU!");
                playeronewins++;
                lblplayerone.Text = "Player 1: " + playeronewins;
                Limpar();
            }
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                MessageBox.Show("Player 1 GANHOU!");
                playeronewins++;
                lblplayerone.Text = "Player 1: " + playeronewins;
                Limpar();
            }
            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                MessageBox.Show("Player 1 GANHOU!");
                playeronewins++;
                lblplayerone.Text = "Player 1: " + playeronewins;
                Limpar();
            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                MessageBox.Show("Player 2 GANHOU!");
                playertwowins++;
                lblplayertwo.Text = "Player 2: " + playertwowins;
                Limpar();
            }
            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("Player 2 GANHOU!");
                playertwowins++;
                lblplayertwo.Text = "Player 2: " + playertwowins;
                Limpar();
            }
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Player 2 GANHOU!");
                playertwowins++;
                lblplayertwo.Text = "Player 2: " + playertwowins;
                Limpar();
            }
            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("Player 2 GANHOU!");
                playertwowins++;
                lblplayertwo.Text = "Player 2: " + playertwowins;
                Limpar();
            }
            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Player 2 GANHOU!");
                playertwowins++;
                lblplayertwo.Text = "Player 2: " + playertwowins;
                Limpar();
            }
            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Player 2 GANHOU!");
                playertwowins++;
                lblplayertwo.Text = "Player 2: " + playertwowins;
                Limpar();
            }
            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                MessageBox.Show("Player 2 GANHOU!");
                playertwowins++;
                lblplayertwo.Text = "Player 2: " + playertwowins;
                Limpar();
            }
            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                MessageBox.Show("Player 2 GANHOU!");
                playertwowins++;
                lblplayertwo.Text = "Player 2: " + playertwowins;
                Limpar();
            }
            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                MessageBox.Show("Deu velha!");
                Limpar();
            }
        }

        public void Limpar()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            jogadas = 0;

            lblPlayerTime.Text = "Vez de: Player 1 (X).";
            lblPlayerTime.ForeColor = Color.Red;
        }
    }
}
