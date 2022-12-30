using System;
using System.Windows.Forms;

namespace RunningTrex
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Trex_Game main = new Trex_Game();
                this.Hide();
                main.Show();
            }
        }
    }
}
