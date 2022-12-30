using System;
using System.Windows.Forms;

namespace RunningTrex
{
    public partial class Trex_Game : Form
    {
        bool jump = false;
        int jumpingSpeed;
        int frc = 12;
        int scoreofthegame = 0;
        int obstSpeed = 15;
        readonly Random random = new Random();
        int pos;
        bool isgameover = false;
        int cloudspeed = 7;
       
        public Trex_Game()
        {
            InitializeComponent();
            ResetGame();
        }

        private void ResetGame()
        {
            frc = 12;
            jumpingSpeed = 0;
            jump = false;
            scoreofthegame = 0;
            obstSpeed = 15;
            score.Text = "Score: " + scoreofthegame;
            orange_dino.Image = Properties.Resources.dino;
            isgameover = false;
            orange_dino.Top = 341;
            orange_dino.Enabled = true;
            
            foreach (Control t in this.Controls)
            {
                if (t is PictureBox && (string)t.Tag == "obstacle")
                {
                    pos = this.ClientSize.Width + random.Next(500, 1000) + (t.Width * 10);
                    t.Left = pos;
                }
            }
            game_tmr.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tmr_dino_TickEvent(object sender, EventArgs e)
        {
            orange_dino.Top += jumpingSpeed;

            score.Text = "Score = " + scoreofthegame;

            if (jump == true && frc < 0)
            { jump = false; }

            if (jump == true)
            {
                jumpingSpeed = -12;
                frc -= 1;
            }
            else
            { jumpingSpeed = 12; }

            if (orange_dino.Top > 340 && jump == false)
            {
                frc = 12;
                orange_dino.Top = 341;
                jumpingSpeed = 0;
            }
            cloud1.Left -= cloudspeed;
            cloud2.Left -= cloudspeed;

            if (cloud1.Left < -250)
            {
                cloud1.Left = 500;
            }
            if (cloud2.Left < -400)
            {
                cloud2.Left = 900;
            }

        

            foreach (Control t in this.Controls)
            {
                if (t is PictureBox && (string)t.Tag == "obstacle")
                {
                    t.Left -= obstSpeed;

                    if (t.Left < -100)
                    {
                        t.Left = this.ClientSize.Width + random.Next(200, 500) + (t.Width * 15);
                        scoreofthegame++;
                    }

                    if (orange_dino.Bounds.IntersectsWith(t.Bounds))
                    {
                        game_tmr.Stop();
                        orange_dino.Enabled = false;

                        orange_dino.Image = Properties.Resources.deadDino;
                        orange_dino.Top = 341;
                        orange_dino.Height = 62;
                        orange_dino.Width = 69;

                        score.Text += " (T) Restart & (Q) Quit";
                        isgameover = true;
                    }
                }
            }
            if (scoreofthegame > 5)
            { obstSpeed = 15; }
        }
        private void key_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jump == false)
            { jump = true; }
        }

        private void key_up(object sender, KeyEventArgs e)
        {
            if (jump == true)
            { jump = false; }

            if (e.KeyCode == Keys.T && isgameover == true)
            { ResetGame(); }

            if (e.KeyCode == Keys.Q && isgameover == true)
            { System.Windows.Forms.Application.Exit(); }
        }
    }
}
