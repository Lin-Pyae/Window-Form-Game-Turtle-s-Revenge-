using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turtle_s_Revenge
{

    public partial class Form1 : Form
    {
        bool goUp, goDown, goStraight, goBack, shot, gameOver;
        int score = 0;
        int speed = 8;
        int UFOspeed = 10;

        Random rand = new Random();

        int turtleSpeed = 7;
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            if (goUp == true && turtle.Top > 0)
            {
                turtle.Top -= turtleSpeed;
            }
            if (goDown == true && turtle.Top + turtle.Height < this.ClientSize.Height)
            {
                turtle.Top += turtleSpeed;
            }
            if (goStraight == true && turtle.Left + turtle.Width < this.ClientSize.Width)
            {
                turtle.Left += turtleSpeed;
            }
            if (goBack == true && turtle.Left + turtle.Width < this.ClientSize.Width)
            {
                turtle.Left -= turtleSpeed;
            }
            ufo.Left -= UFOspeed;
            if (ufo.Left + ufo.Width < 0)
            {
                Changeenemy();
            }
            if (score > 5)
            {
                switch (score)
                {
                    case 5:
                        UFOspeed = 12;
                        break;
                    case 10:
                        UFOspeed = 14;
                        break;
                    case 20:
                        UFOspeed = 16;
                        break;
                    case 30:
                        UFOspeed = 18;
                        break;
                    default:
                        UFOspeed = 21;
                        break;

                }
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "tree")
                {
                    Rectangle bounds = new Rectangle(x.Left + 5, x.Top +5, x.Width - 70, x.Height - 70);
                    x.SendToBack();
                    x.Left -= speed;
                    if (x.Left < -200)
                    {
                        x.Left = 1000;
                    }
                    if (turtle.Bounds.IntersectsWith(bounds))
                    {
                 
                        GameOver(Convert.ToString(x.Tag));
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;
                    if(x.Left > 800)
                    {
                        RemoveBullet((PictureBox)x);
                    }

                    if (ufo.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet((PictureBox)x);
                        score += 1;
                        Changeenemy();

                    }
                }

                if (turtle.Bounds.IntersectsWith(ufo.Bounds))
                {
                    GameOver(Convert.ToString(ufo.Tag));
                }

            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goStraight = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goBack = true;
            }
            if (e.KeyCode == Keys.S && shot == false)
            {
                Shoot();
                shot = true;
            }
            if(e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
            if(e.KeyCode == Keys.Space)
            {
                GameTimer.Stop();
                PausePopUpBox pause = new PausePopUpBox(this);
                pause.Show();
            }
        }

        private void KeyIsup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goStraight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goBack = false;
            }
            if (shot == true)
            {
                shot = false;
            }
        }

        private void Shoot()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.Rocket;
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.Width = 20;
            bullet.Height = 15;
            bullet.Left = turtle.Left + turtle.Width;
            bullet.Top = turtle.Top + turtle.Height / 2;
            bullet.Tag = "bullet";
            bullet.BringToFront();
            this.Controls.Add(bullet);
        }

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void Changeenemy()
        {
            if (index > 2)
            {
                index = 1;
            }
            else
            {
                index += 1;
            }

            switch (index)
            {
                case 1:
                    ufo.Image = Properties.Resources.UFO;
                    break;
                case 2:
                    ufo.Image = Properties.Resources.Robot;
                    break;
            }
            ufo.Left = 1000;
            ufo.Top = rand.Next(20, 400);
            ufo.Size = new Size(50, 50);

        }

        private void RestartGame()
        {
            goUp = false;
            goDown = false;
            goStraight = false;
            goBack = false;
            shot = false;
            gameOver = false;
            score = 0;
            speed = 8;
            UFOspeed = 10;
            txtScore.Text = "Score: " + score;
            Changeenemy();
            turtle.Top = 150;
            tree.Left = 569;
            GameTimer.Start();

        }

        private void GameOver(string cause)
        {
            GameTimer.Stop();
            txtScore.Text = "Score : " + score+$" \n Turtle was hit by {cause}. Press Enter to restart";  
            gameOver = true;
        }

        public void StartTimer()
        {
            GameTimer.Start();
        }
    }
}
