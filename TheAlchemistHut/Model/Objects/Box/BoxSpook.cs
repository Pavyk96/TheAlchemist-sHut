using System.Drawing;

namespace TheAlchemist_sHut.Model.Objects
{
    public class BoxSpook : IBox, IMap
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IItems ItemInBox { get; set; }
        public Image Img { get; set; }
        
        public Rectangle Bounds => new Rectangle(X + 10, Y + 10, Width, Height);

        public BoxSpook()
        {
            X = 38;
            Y = 417;
            Width = 63;
            Height = 59;
            ItemInBox = new ItemSpook();
            Img = Image.FromFile("Textures/Box/tile000.png");
        }
    }
}