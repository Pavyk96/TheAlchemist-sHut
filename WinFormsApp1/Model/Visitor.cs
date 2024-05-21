using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TheAlchemist_sHut.Model.Potions;

namespace TheAlchemist_sHut.Model 
{
    public class Visitor : IMap
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);
        public Image VisitorImage;
        public bool IsAccepted;
        public IPotion Order { get; set; }
        public Image Img { get; set; }

        //public Timer Timer;

        public Visitor()
        {
            X = 887;
            Y = 278;
            Height = 90;
            Width = 90;
            IsAccepted = false;
            Img = Image.FromFile("Textures/Visitors/visitor.png");
        }

    }
}
