using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TheAlchemist_sHut.Controller;
using TheAlchemist_sHut.Model;

namespace TheAlchemist_sHut
{
    public partial class Form1 : Form
    {
        public Player player = new Player();
        public Form1()
        {
            InitializeComponent();
            SetUp();
        }

        private void InitializeComponent()
        {
            components = new Container();
            GameTimer = new Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainTimerEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(40, 36);
            label1.TabIndex = 1;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(39, 36);
            label2.TabIndex = 2;
            label2.Text = "Y:";
            // 
            // Form1
            // 
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Paint += FormPaintEvent;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ResumeLayout(false);
            PerformLayout();

        }

        //новое

        protected override void OnPaint(PaintEventArgs e)
        { 
            base.OnPaint(e); 
            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            PlayerMove.MakeMove(player, this);

            Invalidate();
            label1.Text = "X: " + player.x;
            label2.Text = "Y: " + player.y;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            PlayerMove.StartMove(e, player);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            PlayerMove.StopMove(e, player);
        }


        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.DrawImage(player.playerImg, player.x, player.y, player.width, player.height);
        }

        private void SetUp()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }
    }
}
