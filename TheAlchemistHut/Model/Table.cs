using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model
{
    public class Table : IMap
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Image Img { get; set; }
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);

        public Table() 
        {
            X = 771;
            Y = 0;
            Width = 87;
            Height = 563;
            Img = Image.FromFile("Textures/Map/table.png");
        }
    }
}
