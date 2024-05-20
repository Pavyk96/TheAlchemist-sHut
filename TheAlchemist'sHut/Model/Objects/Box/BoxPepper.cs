using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model.Objects
{
    public class BoxPepper : IBox, IMap
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IItems ItemInBox { get; set; }
        public Image Img { get; set; }
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);

        public BoxPepper() 
        {
            X = 38;
            Y = 743;
            Width = 63;
            Height = 59;
            ItemInBox = new ItemPepper();
            Img = Image.FromFile("Textures/Box/tile000.png");
        }
    }
}
