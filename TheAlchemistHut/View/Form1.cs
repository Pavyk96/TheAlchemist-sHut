using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using TheAlchemist_sHut.Controller;
using TheAlchemist_sHut.Model;
using TheAlchemist_sHut.Model.Objects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using TheAlchemist_sHut.Model.Potions;

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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new Font("Arial Cyr", 16);
            this.label1.ForeColor = Color.FromArgb(26, 13, 13);
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "E - взять предмет/получить заказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = Color.FromArgb(26, 13, 13);
            this.label2.Font = new Font("Arial Cyr", 16);
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Q - выбросить предмет/отдать заказ";
            // 
            // Form1
            // 
            this.BackColor = Color.FromArgb(222, 184, 135);
            this.ClientSize = new System.Drawing.Size(1024, 825);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            //Обработка событий
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
        }

        //Отрисовка
        protected override void OnPaint(PaintEventArgs e)
        { 
            base.OnPaint(e); 
            Graphics Canvas = e.Graphics;
            foreach (var obj in map.Objects)
                Canvas.DrawImage(obj.Img, obj.X, obj.Y, obj.Width, obj.Height);
            if (player.HoldingItem)
                Canvas.DrawImage(player.Item.ItemImg, player.X + (player.Width - player.Item.Width) / 2, player.Y - 30, player.Item.Width, player.Item.Height);
            //Объекты на карте, заменить на цикл ля отрисовки всех объектов
            //Отрисовывать предмет, который держит игрок, относительно игрока, а не хранить координаты для каждого объекта
            Canvas.DrawImage(player.PlayerImg, player.X, player.Y, player.Width, player.Height);
            //Canvas.DrawImage(map.Table.TableImg, map.Table.X, map.Table.Y, map.Table.Width, map.Table.Height);
            //Canvas.DrawImage(map.Boiler.BoilerImg, map.Boiler.X, map.Boiler.Y, map.Boiler.Width, map.Boiler.Height);
            //Canvas.DrawImage(map.Visitor.VisitorImage, map.Visitor.X, map.Visitor.Y, map.Visitor.Width, map.Visitor.Height);
            Canvas.DrawString("Сумма: " + player.Sum.ToString(), new Font("Arial Cyr", 16),
                                new SolidBrush(Color.FromArgb(26, 13, 13)),
                                726, 778);

            foreach (var box in map.Boxes)
            {
                Canvas.DrawImage(box.Img, box.X, box.Y, box.Width, box.Height);
                Canvas.DrawString(box.ItemInBox.Name, new Font("Arial Cyr", 14),
                                  new SolidBrush(Color.FromArgb(52, 33, 33)),
                                  box.X,
                                  box.Y + box.Height);
            }
            
            if (map.Boiler.AddedIngredients.Count > 0)
                for (var i = 0; i < map.Boiler.AddedIngredients.Count; ++i)
                    Canvas.DrawImage(map.Boiler.AddedIngredients[i].ItemImg, map.Boiler.X + i * 80, map.Boiler.Y - 50,
                        map.Boiler.AddedIngredients[i].Width, map.Boiler.AddedIngredients[i].Height);

            if (map.Visitor.IsAccepted)
            {
                Canvas.DrawString("Мой заказ - \n" + map.Visitor.Order.Name.Split()[0] + "\n" + map.Visitor.Order.Name.Split()[1] + ":",
                                  new Font("Arial Cyr", 14),
                                  new SolidBrush(Color.FromArgb(52, 33, 33)),
                                  860, 150);
                for (var i = 0; i < map.Visitor.Order.Ingredients.Count; ++i)
                    Canvas.DrawString(map.Visitor.Order.Ingredients[i].Name,
                                        new Font("Arial Cyr", 14),
                                        new SolidBrush(Color.FromArgb(52, 33, 33)),
                                        860, 215 + i * 20);
            }
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            PlayerMove.MakeMove(player, this);
            Invalidate();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;

            if (key == Keys.E)
            {
                foreach (var box in map.Boxes)
                {
                    if (player.Bounds.IntersectsWith(box.Bounds))
                    {
                        InteractionItems.PickItems(box.ItemInBox, player);
                        break;
                    }
                }

                if (player.Bounds.IntersectsWith(map.Visitor.Bounds))
                    InteractionItems.TakeOrder(player, map.Visitor);
            }

            if (key == Keys.Q)
            {
                if (player.Bounds.IntersectsWith(map.Visitor.Bounds) && map.Visitor.Order != null)
                    InteractionItems.GiveOrder(player, map.Visitor);
                else if (player.Bounds.IntersectsWith(map.Visitor.Bounds) && map.Visitor.Order == null)
                    MessageBox.Show("Для начала возьмите первый заказ!");
                if (player.Bounds.IntersectsWith(map.Boiler.Bounds) && player.Item != null)
                {
                    if (map.Boiler.AddedIngredients.Count < 3)
                    {
                        map.Boiler.AddedIngredients.Add(player.Item);
                        InteractionItems.ThrowItem(player);
                    }
                    if (map.Boiler.AddedIngredients.Count == 3)
                        InteractionItems.GetPotion(player, map.Boiler);
                }
                else
                    InteractionItems.ThrowItem(player);
            }

            if (key == Keys.A)
                PlayerMove.StartMove(PlayerDirection.Left, player);
            if (key == Keys.D)
                PlayerMove.StartMove(PlayerDirection.Right, player);
            if (key == Keys.W)
                PlayerMove.StartMove(PlayerDirection.Up, player);
            if (key == Keys.S)
                PlayerMove.StartMove(PlayerDirection.Down, player);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;
            if (key == Keys.A)
                PlayerMove.StopMove(PlayerDirection.Left, player);
            if (key == Keys.D)
                PlayerMove.StopMove(PlayerDirection.Right, player);
            if (key == Keys.W)
                PlayerMove.StopMove(PlayerDirection.Up, player);
            if (key == Keys.S)
                PlayerMove.StopMove(PlayerDirection.Down, player);
        }

        private void SetUp()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            PlayerMove.MakeMove(player, this);
            Invalidate();
        }
    }
}
