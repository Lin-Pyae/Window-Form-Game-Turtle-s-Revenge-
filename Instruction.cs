using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Turtle_s_Revenge
{
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Form1 play = new Form1();
            play.Show();
            this.Hide();
        }
    }
}
