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
        bool jumping = false;
        int jumpSpeed = 12;
        int force = 12;
        int Score = 0;

        public Trex_Game()
        {
            InitializeComponent();
            GameRest();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr_dino.Start();
        }

        private void tmr_dino_Tick(object sender, EventArgs e)
        {

        }

        private void tmr_dino_TickEvent(object sender, EventArgs e)
        {
            
        }

        private void pic_dino_Click(object sender, EventArgs e)
        {

        }

        private void key_down(object sender, KeyEventArgs e)
        {

        }

        private void key_up(object sender, KeyEventArgs e)
        {

        }
        private void GameRest()
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
