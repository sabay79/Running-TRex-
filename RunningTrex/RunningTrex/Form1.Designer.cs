﻿namespace RunningTrex
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
            this.runnimg_road = new System.Windows.Forms.PictureBox();
            this.water_patch = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.PictureBox();
            this.tmr_dino = new System.Windows.Forms.Timer(this.components);
            this.txt_score = new System.Windows.Forms.Label();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.orange_dino = new System.Windows.Forms.PictureBox();
            this.plant_rock = new System.Windows.Forms.PictureBox();
            this.cave = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.bird1 = new System.Windows.Forms.PictureBox();
            this.bird2 = new System.Windows.Forms.PictureBox();
            this.pink_dino = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.running_road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnimg_road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_patch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plant_rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink_dino)).BeginInit();
            this.SuspendLayout();
            // 
            // running_road
            // 
            this.running_road.BackColor = System.Drawing.Color.Transparent;
            this.running_road.Image = ((System.Drawing.Image)(resources.GetObject("running_road.Image")));
            this.running_road.Location = new System.Drawing.Point(-7, 493);
            this.running_road.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.running_road.Name = "running_road";
            this.running_road.Size = new System.Drawing.Size(770, 50);
            this.running_road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.running_road.TabIndex = 1;
            this.running_road.TabStop = false;
            // 
            // runnimg_road
            // 
            this.runnimg_road.BackColor = System.Drawing.Color.Transparent;
            this.runnimg_road.Image = ((System.Drawing.Image)(resources.GetObject("runnimg_road.Image")));
            this.runnimg_road.Location = new System.Drawing.Point(830, 493);
            this.runnimg_road.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runnimg_road.Name = "runnimg_road";
            this.runnimg_road.Size = new System.Drawing.Size(642, 50);
            this.runnimg_road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.runnimg_road.TabIndex = 3;
            this.runnimg_road.TabStop = false;
            // 
            // water_patch
            // 
            this.water_patch.BackColor = System.Drawing.Color.Transparent;
            this.water_patch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.water_patch.Image = ((System.Drawing.Image)(resources.GetObject("water_patch.Image")));
            this.water_patch.Location = new System.Drawing.Point(755, 493);
            this.water_patch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.water_patch.Name = "water_patch";
            this.water_patch.Size = new System.Drawing.Size(80, 50);
            this.water_patch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.water_patch.TabIndex = 4;
            this.water_patch.TabStop = false;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Image = ((System.Drawing.Image)(resources.GetObject("log.Image")));
            this.log.Location = new System.Drawing.Point(488, 449);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(91, 50);
            this.log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.log.TabIndex = 6;
            this.log.TabStop = false;
            // 
            // tmr_dino
            // 
            this.tmr_dino.Interval = 20;
            this.tmr_dino.Tick += new System.EventHandler(this.tmr_dino_TickEvent);
            // 
            // txt_score
            // 
            this.txt_score.AutoSize = true;
            this.txt_score.BackColor = System.Drawing.Color.Transparent;
            this.txt_score.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score.Location = new System.Drawing.Point(1212, 29);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(135, 33);
            this.txt_score.TabIndex = 7;
            this.txt_score.Text = "Score: 0";
            // 
            // cloud1
            // 
            this.cloud1.BackColor = System.Drawing.Color.Transparent;
            this.cloud1.Image = ((System.Drawing.Image)(resources.GetObject("cloud1.Image")));
            this.cloud1.Location = new System.Drawing.Point(592, 40);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(568, 171);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud1.TabIndex = 8;
            this.cloud1.TabStop = false;
            // 
            // cloud2
            // 
            this.cloud2.BackColor = System.Drawing.Color.Transparent;
            this.cloud2.Image = ((System.Drawing.Image)(resources.GetObject("cloud2.Image")));
            this.cloud2.Location = new System.Drawing.Point(111, 78);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(294, 86);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud2.TabIndex = 9;
            this.cloud2.TabStop = false;
            // 
            // orange_dino
            // 
            this.orange_dino.BackColor = System.Drawing.Color.Transparent;
            this.orange_dino.Image = ((System.Drawing.Image)(resources.GetObject("orange_dino.Image")));
            this.orange_dino.Location = new System.Drawing.Point(12, 421);
            this.orange_dino.Name = "orange_dino";
            this.orange_dino.Size = new System.Drawing.Size(108, 75);
            this.orange_dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orange_dino.TabIndex = 10;
            this.orange_dino.TabStop = false;
            this.orange_dino.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // plant_rock
            // 
            this.plant_rock.BackColor = System.Drawing.Color.Transparent;
            this.plant_rock.Image = ((System.Drawing.Image)(resources.GetObject("plant_rock.Image")));
            this.plant_rock.Location = new System.Drawing.Point(936, 428);
            this.plant_rock.Name = "plant_rock";
            this.plant_rock.Size = new System.Drawing.Size(121, 94);
            this.plant_rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plant_rock.TabIndex = 11;
            this.plant_rock.TabStop = false;
            // 
            // cave
            // 
            this.cave.BackColor = System.Drawing.Color.Transparent;
            this.cave.Image = ((System.Drawing.Image)(resources.GetObject("cave.Image")));
            this.cave.Location = new System.Drawing.Point(1189, 301);
            this.cave.Name = "cave";
            this.cave.Size = new System.Drawing.Size(221, 198);
            this.cave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cave.TabIndex = 12;
            this.cave.TabStop = false;
            // 
            // rock
            // 
            this.rock.BackColor = System.Drawing.Color.Transparent;
            this.rock.Image = ((System.Drawing.Image)(resources.GetObject("rock.Image")));
            this.rock.Location = new System.Drawing.Point(251, 464);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(68, 39);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock.TabIndex = 13;
            this.rock.TabStop = false;
            // 
            // bird1
            // 
            this.bird1.BackColor = System.Drawing.Color.Transparent;
            this.bird1.Image = ((System.Drawing.Image)(resources.GetObject("bird1.Image")));
            this.bird1.Location = new System.Drawing.Point(830, 183);
            this.bird1.Name = "bird1";
            this.bird1.Size = new System.Drawing.Size(89, 46);
            this.bird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird1.TabIndex = 14;
            this.bird1.TabStop = false;
            // 
            // bird2
            // 
            this.bird2.BackColor = System.Drawing.Color.Transparent;
            this.bird2.Image = ((System.Drawing.Image)(resources.GetObject("bird2.Image")));
            this.bird2.Location = new System.Drawing.Point(285, 94);
            this.bird2.Name = "bird2";
            this.bird2.Size = new System.Drawing.Size(34, 28);
            this.bird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird2.TabIndex = 15;
            this.bird2.TabStop = false;
            // 
            // pink_dino
            // 
            this.pink_dino.BackColor = System.Drawing.Color.Transparent;
            this.pink_dino.Image = ((System.Drawing.Image)(resources.GetObject("pink_dino.Image")));
            this.pink_dino.Location = new System.Drawing.Point(126, 422);
            this.pink_dino.Name = "pink_dino";
            this.pink_dino.Size = new System.Drawing.Size(108, 75);
            this.pink_dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pink_dino.TabIndex = 16;
            this.pink_dino.TabStop = false;
            // 
            // Trex_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1372, 542);
            this.Controls.Add(this.bird2);
            this.Controls.Add(this.bird1);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.water_patch);
            this.Controls.Add(this.runnimg_road);
            this.Controls.Add(this.running_road);
            this.Controls.Add(this.log);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.orange_dino);
            this.Controls.Add(this.plant_rock);
            this.Controls.Add(this.cave);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.pink_dino);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Trex_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_up);
            ((System.ComponentModel.ISupportInitialize)(this.running_road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnimg_road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_patch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plant_rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink_dino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox running_road;
        private System.Windows.Forms.PictureBox runnimg_road;
        private System.Windows.Forms.PictureBox water_patch;
        private System.Windows.Forms.PictureBox log;
        private System.Windows.Forms.Timer tmr_dino;
        private System.Windows.Forms.Label txt_score;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.PictureBox orange_dino;
        private System.Windows.Forms.PictureBox plant_rock;
        private System.Windows.Forms.PictureBox cave;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox bird1;
        private System.Windows.Forms.PictureBox bird2;
        private System.Windows.Forms.PictureBox pink_dino;
    }
}
