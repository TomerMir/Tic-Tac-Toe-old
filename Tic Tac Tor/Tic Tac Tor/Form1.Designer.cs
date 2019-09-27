using System.Collections.Generic;

namespace Tic_Tac_Tor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.D4 = new Tic_Tac_Tor.TTTButton();
            this.D3 = new Tic_Tac_Tor.TTTButton();
            this.D2 = new Tic_Tac_Tor.TTTButton();
            this.D1 = new Tic_Tac_Tor.TTTButton();
            this.C4 = new Tic_Tac_Tor.TTTButton();
            this.C3 = new Tic_Tac_Tor.TTTButton();
            this.C2 = new Tic_Tac_Tor.TTTButton();
            this.C1 = new Tic_Tac_Tor.TTTButton();
            this.B4 = new Tic_Tac_Tor.TTTButton();
            this.B3 = new Tic_Tac_Tor.TTTButton();
            this.B2 = new Tic_Tac_Tor.TTTButton();
            this.B1 = new Tic_Tac_Tor.TTTButton();
            this.A1 = new Tic_Tac_Tor.TTTButton();
            this.A2 = new Tic_Tac_Tor.TTTButton();
            this.A3 = new Tic_Tac_Tor.TTTButton();
            this.A4 = new Tic_Tac_Tor.TTTButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.replayButton = new System.Windows.Forms.Button();
            this.continuePlaying = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.D4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.D3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.D2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.D1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.C4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.C3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.C2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.C1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.B3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.B2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.B1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.A1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.A2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.A3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.A4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 424);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // D4
            // 
            this.D4.Location = new System.Drawing.Point(321, 321);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(103, 100);
            this.D4.TabIndex = 15;
            this.D4.UseVisualStyleBackColor = true;
            this.D4.Click += new System.EventHandler(this.button_click);
            // 
            // D3
            // 
            this.D3.Location = new System.Drawing.Point(215, 321);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(100, 100);
            this.D3.TabIndex = 14;
            this.D3.UseVisualStyleBackColor = true;
            this.D3.Click += new System.EventHandler(this.button_click);
            // 
            // D2
            // 
            this.D2.Location = new System.Drawing.Point(109, 321);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(100, 100);
            this.D2.TabIndex = 13;
            this.D2.UseVisualStyleBackColor = true;
            this.D2.Click += new System.EventHandler(this.button_click);
            // 
            // D1
            // 
            this.D1.Location = new System.Drawing.Point(3, 321);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(100, 100);
            this.D1.TabIndex = 12;
            this.D1.UseVisualStyleBackColor = true;
            this.D1.Click += new System.EventHandler(this.button_click);
            // 
            // C4
            // 
            this.C4.Location = new System.Drawing.Point(321, 215);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(103, 100);
            this.C4.TabIndex = 11;
            this.C4.UseVisualStyleBackColor = true;
            this.C4.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(215, 215);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 10;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(109, 215);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(3, 215);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 8;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(321, 109);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(103, 100);
            this.B4.TabIndex = 7;
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(215, 109);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(109, 109);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(3, 109);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A1.ForeColor = System.Drawing.Color.Transparent;
            this.A1.Location = new System.Drawing.Point(3, 3);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(109, 3);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(215, 3);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // A4
            // 
            this.A4.Location = new System.Drawing.Point(321, 3);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(103, 100);
            this.A4.TabIndex = 3;
            this.A4.UseVisualStyleBackColor = true;
            this.A4.Click += new System.EventHandler(this.button_click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(96, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Options";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // replayButton
            // 
            this.replayButton.Location = new System.Drawing.Point(275, 0);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(75, 23);
            this.replayButton.TabIndex = 3;
            this.replayButton.Text = "Replay";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // continuePlaying
            // 
            this.continuePlaying.Location = new System.Drawing.Point(194, 0);
            this.continuePlaying.Name = "continuePlaying";
            this.continuePlaying.Size = new System.Drawing.Size(75, 23);
            this.continuePlaying.TabIndex = 4;
            this.continuePlaying.Text = "Next Game";
            this.continuePlaying.UseVisualStyleBackColor = true;
            this.continuePlaying.Click += new System.EventHandler(this.ContinuePlaying_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.continuePlaying);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe By Tomer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TTTButton D4;
        private TTTButton D3;
        private TTTButton D2;
        private TTTButton D1;
        private TTTButton C4;
        private TTTButton C3;
        private TTTButton C2;
        private TTTButton C1;
        private TTTButton B4;
        private TTTButton B3;
        private TTTButton B2;
        private TTTButton B1;
        private TTTButton A1;
        private TTTButton A2;
        private TTTButton A3;
        private TTTButton A4;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button continuePlaying;
    }

    class TTTButton : System.Windows.Forms.Button
    {
        public string XO;

    }
}

