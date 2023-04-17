using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Turtle_s_Revenge
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Form1 startGame = new Form1();
            startGame.Show();
            this.Hide();
        }

        private void instructionBtn_Click(object sender, EventArgs e)
        {
            Instruction instruction = new Instruction();
            instruction.Show();
            this.Hide();
        }
    }
}
