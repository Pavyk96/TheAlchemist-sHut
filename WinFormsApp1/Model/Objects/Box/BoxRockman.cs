using System.Drawing;

namespace TheAlchemist_sHut.Model.Objects
{
    public class BoxRockman : IBox, IMap
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IItems ItemInBox { get; set; }
        public Image Img { get; set; }
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);

        public BoxRockman()
        {
            X = 38;
            Y = 93;
            Width = 63;
            Height = 59;
            ItemInBox = new ItemRockman();
            Img = Image.FromFile("Textures/Box/tile000.png");
        }
    }
}