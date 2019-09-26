using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Tor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        bool turn = true;
        
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int player_count = 0;

        private void button_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            player_count++;
            if(turn)
            {
                button.Text = " ";
                button.BackgroundImage = Tic_Tac_Tor.Properties.Resources.redO;
            }
            else
            {
                button.Text = "  ";
                button.BackgroundImage = Tic_Tac_Tor.Properties.Resources.redX;
            }
            button.Enabled = false;
                
            if(checkForAWinner())
            {
                if(turn)
                {
                    MessageBox.Show("Player O is the winner", "We have a winner");
                    reset();
                }
                else
                {
                    MessageBox.Show("Player X is the winner","We have a winner");
                    reset();
                }
            }
            turn = !turn;
            if (player_count==16 && checkForAWinner() == false)
            {
                MessageBox.Show("It's a draw", "draw");
                reset();
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Tomer's Tic Tac Toe", "Tic Tac Toe");
            reset();
            
        }

        public void reset()
        {
            A1.Enabled = true;
            A1.Text = null;
            A2.Enabled = true;
            A2.Text = null;
            A3.Enabled = true;
            A3.Text = null;
            A4.Enabled = true;
            A4.Text = null;
            B1.Enabled = true;
            B1.Text = null;
            B2.Enabled = true;
            B2.Text = null;
            B3.Enabled = true;
            B3.Text = null;
            B4.Enabled = true;
            B4.Text = null;
            C1.Enabled = true;
            C1.Text = null;
            C2.Enabled = true;
            C2.Text = null;
            C3.Enabled = true;
            C3.Text = null;
            C4.Enabled = true;
            C4.Text = null;
            D1.Enabled = true;
            D1.Text = null;
            D2.Enabled = true;
            D2.Text = null;
            D3.Enabled = true;
            D3.Text = null;
            D4.Enabled = true;
            D4.Text = null;
        }

        public bool checkForAWinner()
        {
          
            if ((A1.Text == A2.Text && A2.Text == A3.Text && A3.Text == A4.Text && !A1.Enabled)
                || (B1.Text == B2.Text && B2.Text == B3.Text && A3.Text == B4.Text && !B1.Enabled)
                || (C1.Text == C2.Text && C2.Text == C3.Text && C3.Text == C4.Text && !C4.Enabled)
                || (D1.Text == D2.Text && D2.Text == D3.Text && D3.Text == D4.Text && !D4.Enabled)
                || (A1.Text == B1.Text && B1.Text == C1.Text && C1.Text == D1.Text && !D1.Enabled)
                || (A2.Text == B2.Text && B2.Text == C2.Text && C2.Text == D2.Text && !D2.Enabled)
                || (A3.Text == B3.Text && B3.Text == C3.Text && C3.Text == D3.Text && !D3.Enabled)
                || (A4.Text == B4.Text && B4.Text == C4.Text && C4.Text == D4.Text && !D4.Enabled)
                || (A1.Text == B2.Text && B2.Text == C3.Text && C3.Text == D4.Text && !D4.Enabled)
                || (A4.Text == B3.Text && B3.Text == C2.Text && C2.Text == D1.Text && !D1.Enabled))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
