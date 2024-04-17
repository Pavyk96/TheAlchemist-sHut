using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = global::TheAlchemist_sHut.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(430, 127);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(62, 99);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown); //подписка
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //новое

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e); 
        //    //e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);
        //    Player.Location.X = 
        //}


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
    }
}
