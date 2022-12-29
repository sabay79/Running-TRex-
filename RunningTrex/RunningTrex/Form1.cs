using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningTrex
{
    
    public partial class Trex_Game : Form
    {
        bool jump = false;
        int jumpingSpeed;
        int frc = 12;
        int scoreofthegame = 0;
        int obstSpeed = 10;
        readonly Random random = new Random();
        int pos;
        bool isgameover = false;

        public Trex_Game()
        {
            InitializeComponent();
            GameRest();
        }

        private void ResetGame()
        {
            frc = 12;
            jumpingSpeed = 0;
            jump = false;
            scoreofthegame = 0;
            obstSpeed = 10;
            score.Text = "Score: " + scoreofthegame;
            orange_dino.Image = Properties.Resources.dino;
            isgameover = false;
            orange_dino.Top = 420;
            orange_dino.Height = 90;
            orange_dino.Width = 60;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game_tmr.Start();
        }

        private void tmr_dino_Tick(object sender, EventArgs e)
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

            if (orange_dino.Top > 419 && jump == false)
            {
                frc = 12;
                orange_dino.Top = 420;
                jumpingSpeed = 0;
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
                        orange_dino.Enabled= false;

                        //orange_dino.Image = Properties.Resources.deadFlamigo;
                        orange_dino.Top = 420;
                        orange_dino.Height = 70;
                        orange_dino.Width = 100;

                        score.Text += "   Press T to Restart";
                        isgameover = true;
                    }
                }
            }
            if (scoreofthegame > 5)
            { obstSpeed = 15; }
        }

        private void pic_dino_Click(object sender, EventArgs e)
        {

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
        }
        private void GameRest()
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void water_patch_Click(object sender, EventArgs e)
        {

        }
    }
}
