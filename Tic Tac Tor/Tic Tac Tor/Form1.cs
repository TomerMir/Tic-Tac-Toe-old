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
        
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int player_count = 0;

        private void button_click(object sender, EventArgs e)
        {
            TTTButton button = sender as TTTButton;
            player_count++;
                       
            button.XO = "X";
            button.BackgroundImage = Tic_Tac_Tor.Properties.Resources.redO;
            button.Enabled = false;

            
            if (checkForAWinner())
            {                              
                MessageBox.Show("Player O is the winner", "We have a winner");
                reset();
            }
            
            if (player_count==16 && checkForAWinner() == false)
            {
                MessageBox.Show("It's a draw", "draw");
                reset();
            }

            ComputerTurn();

            if (checkForAWinner())
            {
                MessageBox.Show("Player X is the winner", "We have a winner");
                reset();
            }

            if (player_count == 16 && checkForAWinner() == false)
            {
                MessageBox.Show("It's a draw", "draw");
                reset();
            }
        }

        public void ComputerTurn()
        {


            foreach (Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;
                if (b.Enabled)
                {
                    if(checkBox1.Checked)
                    {
                        b.BackgroundImage = Tic_Tac_Tor.Properties.Resources.redO;
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(50);
                    }
                    b.XO = "O";
                    if (checkForAWinner())
                    {
                        b.BackgroundImage = Tic_Tac_Tor.Properties.Resources.redX;
                        b.Enabled = false;
                        player_count++;
                        return;
                    }
                    else
                    {
                        b.XO = null;
                        b.BackgroundImage = null;
                    }
                    if (checkBox1.Checked)
                    {
                        b.BackgroundImage = Tic_Tac_Tor.Properties.Resources.redX;
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(50);
                    }
                    b.XO = "X";
                    if (checkForAWinner())
                    {                       
                        b.BackgroundImage = Tic_Tac_Tor.Properties.Resources.redX;
                        b.Enabled = false;
                        b.XO = "O";
                        player_count++;
                        return;
                    }
                    else
                    {
                        b.XO = null;
                        b.BackgroundImage = null;
                    }

                }
            }
                       
            Random random = new Random();
            int tmp = 0;
            List<int> enabledButtons = new List<int>();
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;
                if (b.Enabled == true)
                {
                    enabledButtons.Add(tmp);
                }
                tmp++;
            }
            int tmprand = random.Next(0,((enabledButtons.ToArray()).Length));
            int rand = enabledButtons.ToArray()[tmprand];
            int anotherTmp = 0;
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;
                if (rand == anotherTmp)
                {
                    b.BackgroundImage = Tic_Tac_Tor.Properties.Resources.redX;
                    b.XO = "O";
                    b.Enabled = false;                    
                    player_count++;
                    return;
                }
                anotherTmp++;
            }

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
                        
            reset();
            
        }

        public void reset()
        {
            foreach(Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;

                b.BackgroundImage = null;
                b.Enabled = true;
                b.XO = null;
                
            }
            player_count = 0;
            
        }


        public bool checkForAWinner()
        {
          
            if ((A1.XO == A2.XO && A2.XO == A3.XO && A3.XO == A4.XO && A1.XO != null)
                || (B1.XO == B2.XO && B2.XO == B3.XO && B3.XO == B4.XO && B4.XO != null)
                || (C1.XO == C2.XO && C2.XO == C3.XO && C3.XO == C4.XO && C4.XO != null)
                || (D1.XO == D2.XO && D2.XO == D3.XO && D3.XO == D4.XO && D4.XO != null)
                || (A1.XO == B1.XO && B1.XO == C1.XO && C1.XO == D1.XO && D1.XO != null)
                || (A2.XO == B2.XO && B2.XO == C2.XO && C2.XO == D2.XO && D2.XO != null)
                || (A3.XO == B3.XO && B3.XO == C3.XO && C3.XO == D3.XO && D3.XO != null)
                || (A4.XO == B4.XO && B4.XO == C4.XO && C4.XO == D4.XO && D4.XO != null)
                || (A1.XO == B2.XO && B2.XO == C3.XO && C3.XO == D4.XO && D4.XO != null)
                || (A4.XO == B3.XO && B3.XO == C2.XO && C2.XO == D1.XO && D1.XO != null))
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
