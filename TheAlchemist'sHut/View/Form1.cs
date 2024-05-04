using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TheAlchemist_sHut.Controller;
using TheAlchemist_sHut.Model;
using TheAlchemist_sHut.Model.Objects;

namespace TheAlchemist_sHut
{
    public partial class Form1 : Form
    {
        public static Player player = new Player();
        public static Map map = new Map();
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
            label1.Text = "(X,Y) : " + '(' + player.X + ',' + player.Y + ')';
            label2.Text = "IsHoldingItems: " + player.HoldingItem + "            Items: " + player.Item;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                foreach (var box in map.Boxes)
                {
                    if (player.Bounds.IntersectsWith(box.Bounds))
                    {
                        InteractionItems.PickItems(box.ItemInBox, player);
                        break;
                    }
                }
            }
            
            if (e.KeyCode == Keys.Q)
                InteractionItems.ThrowItem(player);
            
            PlayerMove.StartMove(e, player);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            PlayerMove.StopMove(e, player);
        }


        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.DrawImage(player.PlayerImg, player.X, player.Y, player.Width, player.Height);
            foreach (var box in map.Boxes)
            {
                Canvas.DrawImage(box.BoxImg, box.X, box.Y, box.Width, box.Height);
            }
            if (player.Item != null)
                Canvas.DrawImage(player.Item.ItemImg, player.Item.X, player.Item.Y, player.Item.Width,player.Item.Height);
        }

        private void SetUp()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }
    }
}
