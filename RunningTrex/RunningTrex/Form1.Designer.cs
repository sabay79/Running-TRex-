namespace RunningTrex
{
    partial class Trex_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trex_Game));
            this.running_road = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.PictureBox();
            this.game_tmr = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.orange_dino = new System.Windows.Forms.PictureBox();
            this.plant_rock = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.bird1 = new System.Windows.Forms.PictureBox();
            this.bird2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.running_road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plant_rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).BeginInit();
            this.SuspendLayout();
            // 
            // running_road
            // 
            this.running_road.BackColor = System.Drawing.Color.Transparent;
            this.running_road.Image = ((System.Drawing.Image)(resources.GetObject("running_road.Image")));
            this.running_road.Location = new System.Drawing.Point(-5, 401);
            this.running_road.Margin = new System.Windows.Forms.Padding(2);
            this.running_road.Name = "running_road";
            this.running_road.Size = new System.Drawing.Size(1046, 41);
            this.running_road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.running_road.TabIndex = 1;
            this.running_road.TabStop = false;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Image = ((System.Drawing.Image)(resources.GetObject("log.Image")));
            this.log.Location = new System.Drawing.Point(393, 366);
            this.log.Margin = new System.Windows.Forms.Padding(2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(68, 41);
            this.log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.log.TabIndex = 6;
            this.log.TabStop = false;
            this.log.Tag = "obstacle";
            // 
            // game_tmr
            // 
            this.game_tmr.Interval = 20;
            this.game_tmr.Tick += new System.EventHandler(this.tmr_dino_TickEvent);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(5, 9);
            this.score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(90, 22);
            this.score.TabIndex = 7;
            this.score.Text = "Score: 0";
            // 
            // cloud1
            // 
            this.cloud1.BackColor = System.Drawing.Color.Transparent;
            this.cloud1.Image = ((System.Drawing.Image)(resources.GetObject("cloud1.Image")));
            this.cloud1.Location = new System.Drawing.Point(333, 32);
            this.cloud1.Margin = new System.Windows.Forms.Padding(2);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(426, 139);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud1.TabIndex = 8;
            this.cloud1.TabStop = false;
            this.cloud1.Tag = "";
            // 
            // cloud2
            // 
            this.cloud2.BackColor = System.Drawing.Color.Transparent;
            this.cloud2.Image = ((System.Drawing.Image)(resources.GetObject("cloud2.Image")));
            this.cloud2.Location = new System.Drawing.Point(29, 63);
            this.cloud2.Margin = new System.Windows.Forms.Padding(2);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(220, 70);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud2.TabIndex = 9;
            this.cloud2.TabStop = false;
            this.cloud2.Tag = "";
            // 
            // orange_dino
            // 
            this.orange_dino.BackColor = System.Drawing.Color.Transparent;
            this.orange_dino.Image = global::RunningTrex.Properties.Resources.dino;
            this.orange_dino.Location = new System.Drawing.Point(9, 337);
            this.orange_dino.Margin = new System.Windows.Forms.Padding(2);
            this.orange_dino.Name = "orange_dino";
            this.orange_dino.Size = new System.Drawing.Size(105, 66);
            this.orange_dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orange_dino.TabIndex = 10;
            this.orange_dino.TabStop = false;
            // 
            // plant_rock
            // 
            this.plant_rock.BackColor = System.Drawing.Color.Transparent;
            this.plant_rock.Image = ((System.Drawing.Image)(resources.GetObject("plant_rock.Image")));
            this.plant_rock.Location = new System.Drawing.Point(762, 361);
            this.plant_rock.Margin = new System.Windows.Forms.Padding(2);
            this.plant_rock.Name = "plant_rock";
            this.plant_rock.Size = new System.Drawing.Size(68, 57);
            this.plant_rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plant_rock.TabIndex = 11;
            this.plant_rock.TabStop = false;
            this.plant_rock.Tag = "obstacle";
            // 
            // rock
            // 
            this.rock.BackColor = System.Drawing.Color.Transparent;
            this.rock.Image = ((System.Drawing.Image)(resources.GetObject("rock.Image")));
            this.rock.Location = new System.Drawing.Point(184, 377);
            this.rock.Margin = new System.Windows.Forms.Padding(2);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(37, 26);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock.TabIndex = 13;
            this.rock.TabStop = false;
            this.rock.Tag = "obstacle";
            // 
            // bird1
            // 
            this.bird1.BackColor = System.Drawing.Color.Transparent;
            this.bird1.Image = ((System.Drawing.Image)(resources.GetObject("bird1.Image")));
            this.bird1.Location = new System.Drawing.Point(801, 114);
            this.bird1.Margin = new System.Windows.Forms.Padding(2);
            this.bird1.Name = "bird1";
            this.bird1.Size = new System.Drawing.Size(67, 37);
            this.bird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird1.TabIndex = 14;
            this.bird1.TabStop = false;
            this.bird1.Tag = "obstacle";
            // 
            // bird2
            // 
            this.bird2.BackColor = System.Drawing.Color.Transparent;
            this.bird2.Image = ((System.Drawing.Image)(resources.GetObject("bird2.Image")));
            this.bird2.Location = new System.Drawing.Point(135, 166);
            this.bird2.Margin = new System.Windows.Forms.Padding(2);
            this.bird2.Name = "bird2";
            this.bird2.Size = new System.Drawing.Size(26, 23);
            this.bird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird2.TabIndex = 15;
            this.bird2.TabStop = false;
            this.bird2.Tag = "obstacle";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 440);
            this.panel1.TabIndex = 16;
            // 
            // Trex_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(879, 440);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.running_road);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.log);
            this.Controls.Add(this.plant_rock);
            this.Controls.Add(this.orange_dino);
            this.Controls.Add(this.bird1);
            this.Controls.Add(this.bird2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Trex_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_up);
            ((System.ComponentModel.ISupportInitialize)(this.running_road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plant_rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox running_road;
        private System.Windows.Forms.PictureBox log;
        private System.Windows.Forms.Timer game_tmr;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.PictureBox orange_dino;
        private System.Windows.Forms.PictureBox plant_rock;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox bird1;
        private System.Windows.Forms.PictureBox bird2;
        private System.Windows.Forms.Panel panel1;
    }
}

