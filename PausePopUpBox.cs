using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Turtle_s_Revenge
{
    public partial class PausePopUpBox : Form
    {
        private Form1 mainForm;
        public PausePopUpBox(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            StartPage sp = new StartPage();
            mainForm.Hide();
            sp.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resumeBtn_Click(object sender, EventArgs e)
        {
            mainForm.StartTimer();
            this.Hide();
        }
    }
}
