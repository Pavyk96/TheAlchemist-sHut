using System.Drawing;

namespace TheAlchemist_sHut.Model
{
    public class Test : IItems
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        
        public Image ItemImg { get; set; }
        
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);
        
        public Test()
        {
            X = 500;
            Y = 500;
            Height = 40;
            Width = 40;
            ItemImg = Image.FromFile("Textures/Potions/tile062.png");
        }
    }
}