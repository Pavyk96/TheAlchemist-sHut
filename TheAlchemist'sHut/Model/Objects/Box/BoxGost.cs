using System.Drawing;

namespace TheAlchemist_sHut.Model.Objects
{
    public class BoxGost : IBox
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IItems ItemInBox { get; set; }
        public Image BoxImg { get; set; }
        public Rectangle Bounds => new Rectangle(X + 10, Y + 10, Width, Height);

        public BoxGost()
        {
            X = 200;
            Y = 400;
            Width = 56;
            Height = 56;
            ItemInBox = new ItemGhost();
            BoxImg = Image.FromFile("Textures/Box/tile000.png");
        }
    }
}