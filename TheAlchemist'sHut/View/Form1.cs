using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheAlchemist_sHut.Controller;
using TheAlchemist_sHut.Model;

namespace TheAlchemist_sHut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ingredient1 = new System.Windows.Forms.PictureBox();
            this.ingredient2 = new System.Windows.Forms.PictureBox();
            this.ingredient3 = new System.Windows.Forms.PictureBox();
            this.ingredient4 = new System.Windows.Forms.PictureBox();
            this.ingredient5 = new System.Windows.Forms.PictureBox();
            this.water = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bake = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(356, 334);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(89, 150);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // ingredient1
            // 
            this.ingredient1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingredient1.BackgroundImage")));
            this.ingredient1.Location = new System.Drawing.Point(57, 128);
            this.ingredient1.Name = "ingredient1";
            this.ingredient1.Size = new System.Drawing.Size(109, 125);
            this.ingredient1.TabIndex = 1;
            this.ingredient1.TabStop = false;
            // 
            // ingredient2
            // 
            this.ingredient2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingredient2.BackgroundImage")));
            this.ingredient2.Location = new System.Drawing.Point(57, 305);
            this.ingredient2.Name = "ingredient2";
            this.ingredient2.Size = new System.Drawing.Size(109, 125);
            this.ingredient2.TabIndex = 2;
            this.ingredient2.TabStop = false;
            // 
            // ingredient3
            // 
            this.ingredient3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingredient3.BackgroundImage")));
            this.ingredient3.Location = new System.Drawing.Point(57, 480);
            this.ingredient3.Name = "ingredient3";
            this.ingredient3.Size = new System.Drawing.Size(109, 125);
            this.ingredient3.TabIndex = 3;
            this.ingredient3.TabStop = false;
            // 
            // ingredient4
            // 
            this.ingredient4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingredient4.BackgroundImage")));
            this.ingredient4.Location = new System.Drawing.Point(57, 657);
            this.ingredient4.Name = "ingredient4";
            this.ingredient4.Size = new System.Drawing.Size(109, 125);
            this.ingredient4.TabIndex = 4;
            this.ingredient4.TabStop = false;
            // 
            // ingredient5
            // 
            this.ingredient5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingredient5.BackgroundImage")));
            this.ingredient5.Location = new System.Drawing.Point(57, 833);
            this.ingredient5.Name = "ingredient5";
            this.ingredient5.Size = new System.Drawing.Size(109, 125);
            this.ingredient5.TabIndex = 5;
            this.ingredient5.TabStop = false;
            // 
            // water
            // 
            this.water.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("water.BackgroundImage")));
            this.water.Location = new System.Drawing.Point(490, 872);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(164, 164);
            this.water.TabIndex = 6;
            this.water.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(879, 872);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 164);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1265, 872);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 164);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // bake
            // 
            this.bake.BackColor = System.Drawing.Color.Transparent;
            this.bake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bake.BackgroundImage")));
            this.bake.Location = new System.Drawing.Point(490, 9);
            this.bake.Name = "bake";
            this.bake.Size = new System.Drawing.Size(191, 246);
            this.bake.TabIndex = 9;
            this.bake.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(867, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 188);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(1242, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 210);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(1652, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(107, 894);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(867, 446);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(183, 193);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bake);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.water);
            this.Controls.Add(this.ingredient5);
            this.Controls.Add(this.ingredient4);
            this.Controls.Add(this.ingredient3);
            this.Controls.Add(this.ingredient2);
            this.Controls.Add(this.ingredient1);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //новое

        /*protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawImage(global::TheAlchemist_sHut.Properties.Resources.player, 0, 0);
        }*/


        private void MainTimerEvent(object sender, EventArgs e)
        {
            PlayerMove.MakeMove(Player);
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            PlayerMove.StartMove(e);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            PlayerMove.StopMove(e);
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }
    }
}
