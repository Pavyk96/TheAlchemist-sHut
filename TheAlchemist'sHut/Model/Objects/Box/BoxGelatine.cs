using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAlchemist_sHut.Model;

namespace TheAlchemist_sHut.Model.Objects
{
    public class BoxGelatine : IBox, IMap
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IItems ItemInBox { get; set; }
        public Image Img { get; set; }

        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);

        public BoxGelatine()
        {
            X = 38;
            Y = 633;
            Width = 63;
            Height = 59;
            ItemInBox = new ItemGelatine();
            Img = Image.FromFile("Textures/Box/tile000.png");
        }
    }
}
