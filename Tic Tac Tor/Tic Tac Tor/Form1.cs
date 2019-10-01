using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

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
        int whoWins = 0;
        bool canClick = true;
        int player_count = 0;
        bool canPlay;

        List<TTTButton> replay = new List<TTTButton>();
        private void button_click(object sender, EventArgs e)
        {
            if (canClick == false)
            {
                return;
            }
            if (textBox.Text == "")
            {
                MessageBox.Show("Enter your name first", "Enter you name");
                return;
            }
            textBox.Hide();
            label.Hide();
            TTTButton button = sender as TTTButton;
            player_count++;

            button.XO = "X";
            button.BackgroundImage = Tic_Tac_Tor.Properties.Resources.redO;
            button.Enabled = false;
            replay.Add(button);

            if (checkForAWinner())
            {
                canClick = false;
                whoWins = 1;
                writeAtFile(textBox.Text, 1);
                MessageBox.Show("Player O is the winner", "We have a winner");
                replayButton.Show();
                continuePlaying.Show();
                return;
            }

            if (player_count == 16 && checkForAWinner() == false)
            {
                canClick = false;
                whoWins = 2;
                MessageBox.Show("It's a draw", "draw");
                writeAtFile(textBox.Text, 2);
                replayButton.Show();
                continuePlaying.Show();
                return;
            }

            ComputerTurn();

            if (checkForAWinner())
            {
                canClick = false;
                whoWins = 3;
                MessageBox.Show("Player X is the winner", "We have a winner");
                writeAtFile(textBox.Text, 3);
                replayButton.Show();
                continuePlaying.Show();
                return;
            }

            if (player_count == 16 && checkForAWinner() == false)
            {
                canClick = false;
                whoWins = 2;
                MessageBox.Show("It's a draw", "draw");
                writeAtFile(textBox.Text, 2);
                replayButton.Show();
                continuePlaying.Show();
                return;

            }
        }

        public void ComputerTurn()
        {
            if (checkBox1.Checked)
            {
                canPlay = false;
            }
            canClick = false;
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;
                if (b.Enabled)
                {
                    if (checkBox1.Checked)
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
                        replay.Add(b);
                        canClick = true;
                        canPlay = true;
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
                        replay.Add(b);
                        canClick = true;
                        canPlay = true;
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
            int tmprand = random.Next(0, ((enabledButtons.ToArray()).Length));
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
                    replay.Add(b);
                    canClick = true;
                    canPlay = true;
                    return;
                }
                anotherTmp++;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
            canPlay = false;
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;
                b.Hide();
            }
            textBox.Hide();
            label.Hide();
            checkBox1.Hide();
            if (!Directory.Exists(Root))
            {
                Directory.CreateDirectory(Root);
            }


        }
        public void reset()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;

                b.BackgroundImage = null;
                b.Enabled = true;
                b.XO = null;
                b.TabStop = false;

            }
            textBox.Show();
            label.Show();
            canClick = true;
            player_count = 0;
            replayButton.Hide();
            continuePlaying.Hide();
            replay.Clear();
            whoWins = 0;
        }

        const string Root = "c:\\Users\\Public\\TicTacToe\\";
        public List<string> highScores()
        {
            Regex extractName = new Regex(".*user_(.*)\\.txt");
            var userFiles = Directory.GetFiles(Root, "user_*.txt");
            List<string> list = new List<string>();
            foreach (var fileName in userFiles)
            {
                Match m = extractName.Match(fileName);
                if (m.Success)
                {
                    var a = m.Groups[1].Value;
                    list.Add(a);
                }
            }
            return (list);

        }
        public void writeAtFile(string input, int won)
        {
            if (!Directory.Exists(Root))
            {
                Directory.CreateDirectory(Root);
            }
            string path = (Root + "\\user_" + input + ".txt");


            using (StreamWriter sw2 = new StreamWriter(path, true))
            {
                if (won == 1)
                {
                    sw2.WriteLine(input + " won at " + DateTime.Now.ToString("MM/dd/yyyy h:mm tt"));
                }
                if (won == 2)
                {
                    sw2.WriteLine(input + " draw at " + DateTime.Now.ToString("MM/dd/yyyy h:mm tt"));
                }
                if (won == 3)
                {
                    sw2.WriteLine(input + " lost at " + DateTime.Now.ToString("MM/dd/yyyy h:mm tt"));
                }

            }
            StreamReader sr = new StreamReader(path, true);
            char[] filearr = ((sr.ReadToEnd()).ToString()).ToArray();
            sr.Close();

            StreamWriter sw = new StreamWriter(path, true);

            int[] replace = new int[filearr.Length];
            int i = 0;
            foreach (char c in filearr)
            {
                replace[i] = (int)Convert.ToChar(filearr[i]);
                i++;
            }
            StringBuilder sb = new StringBuilder();
            foreach (int n in replace)
            {
                sb.Append(n.ToString("x2"));
            }
            string rep = sb.ToString();
            sw.Close();


            File.WriteAllText(path, "");
            StreamWriter sw1 = new StreamWriter(path, true);
            sw1.Write(rep);
            sw1.Close();
        }
        public int readAFile(string input)
        {

            string path = (Root + "user_" + input + ".txt");
            StreamReader sr = new StreamReader(path, true);
            char[] filearr = ((sr.ReadToEnd()).ToString()).ToArray();
            sr.Close();
            int[] ascii = new int[filearr.Length];
            char[] starr = new char[ascii.Length];
            for (int i = 0; i < filearr.Length - 1; i += 2)
            {
                string tmp = new string(filearr, i, 2);
                ascii[i] = Convert.ToInt32(tmp, 16);
                starr[i] = (char)ascii[i];
            }
            char[] halfarr = new char[starr.Length];
            int k = 0;
            for (int i = 0; i < filearr.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    halfarr[k] = starr[i];
                    k++;
                }

            }
            string allText = String.Join("", halfarr);
            string[] arrText = allText.Split(' ');
            int j = 0;
            int r = 0;
            foreach (string won in arrText)
            {
                if (arrText[r] == "won")
                {
                    j++;
                }
                r++;
            }
            return j;


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
        private void ReplayButton_Click(object sender, EventArgs e)
        {
            canPlay = false;
            checkBox1.Hide();
            continuePlaying.Hide();
            replayButton.Hide();
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;

                b.BackgroundImage = null;
                b.Enabled = true;
                b.XO = null;

            }
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;
                b.Enabled = false;
            }
            TTTButton[] buttonArr = replay.ToArray();
            bool turn = true;
            for (int i = 0; i < buttonArr.Length; i++)
            {
                if (turn)
                {
                    Application.DoEvents();
                    buttonArr[i].BackgroundImage = Tic_Tac_Tor.Properties.Resources.redO;
                }
                else
                {
                    Application.DoEvents();
                    buttonArr[i].BackgroundImage = Tic_Tac_Tor.Properties.Resources.redX;
                }
                turn = !turn;
                System.Threading.Thread.Sleep(500);
            }
            if (whoWins == 1)
            {
                MessageBox.Show("Player O won", "O");
            }
            if (whoWins == 2)
            {
                MessageBox.Show("Draw", "Draw");
            }
            if (whoWins == 3)
            {
                MessageBox.Show("Player X won", "X");
            }
            replayButton.Show();
            continuePlaying.Show();
            checkBox1.Show();
            canPlay = true;

        }
        private void Play_Click(object sender, EventArgs e)
        {
            play.Hide();
            score.Hide();
            textBox.Show();
            label.Show();
            checkBox1.Show();
            canPlay = true;
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                TTTButton b = c as TTTButton;
                if (b == null) continue;
                b.Show();
            }


        }
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (canPlay == false)
            {
                MessageBox.Show("You cannot reset your game right now", "Error");
                return;
            }
            reset();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ContinuePlaying_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            char[] txtarr = textBox.Text.ToArray();
            foreach (char a in txtarr)
            {
                if (a == '1' || a == '2' || a == '3' || a == '4' || a == '5' || a == '6' || a == '7' || a == '8' || a == '9' || a == '0')
                {
                    MessageBox.Show("You cannot enter numbers here", "Error");
                    textBox.Clear();
                }
                if (a == '.' || a == '\\' || a == '_' || a == ':' || a == ';' || a == '/' || a == ':' || a == '!' || a == '@' || a == '#'
                    || a == '$' || a == '%' || a == '^' || a == '&' || a == '&' || a == '*' || a == '(' || a == ')' || a == '-' || a == '='
                    || a == '+' || a == '?')
                {
                    MessageBox.Show("You can enter only letters here", "Error");
                    textBox.Clear();
                }

            }
        }

        private void Score_Click(object sender, EventArgs e)
        {
            int lenght = Directory.GetFiles(Root).Length;
            if (lenght < 1)
            {
                MessageBox.Show("You need to play at least one game to see the results", "Error");
                return;
            }
            string[] arr = highScores().ToArray();
            int[] numarr = new int[arr.Length];
            int i = 0;
            foreach (string a in arr)
            {
                numarr[i] = readAFile(arr[i]);
                i++;
            }
            int tmp;
            string strtmp;
            for (int k = 0; k < numarr.Length - 1; k++)
            {
                for (int j = 0; j < numarr.Length - 1; j++)
                {
                    if (numarr[k] > numarr[k + 1])
                    {
                        tmp = numarr[k];
                        strtmp = arr[k];
                        numarr[k] = numarr[k + 1];
                        arr[k] = arr[k + 1];
                        numarr[k + 1] = tmp;
                        arr[k + 1] = strtmp;
                    }
                }
            }
            MessageBox.Show("First place is " + arr[lenght - 1] + " with " + numarr[lenght - 1] + " wins ", "1st place");
            if (lenght < 2)
            {
                return;
            }
            MessageBox.Show("Second place is " + arr[lenght - 2] + " with " + numarr[lenght - 2] + " wins ", "2st place");
            if (lenght < 3)
            {
                return;
            }
            MessageBox.Show("Thired place is " + arr[lenght - 3] + " with " + numarr[lenght - 3] + " wins ", "3st place");
        }

        private void label1Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            while (true)
            {
                var cl = MessageBox.Show("Algoritim", "Easter egg");
            }
        }
    }
}