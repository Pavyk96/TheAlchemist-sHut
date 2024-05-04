using System.Drawing;

namespace TheAlchemist_sHut.Model.Objects
{
    public class BoxFrog : IBox
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IItems ItemInBox { get; set; }
        public Image BoxImg { get; set; }
        
        public Rectangle Bounds => new Rectangle(X + 10, Y + 10, Width, Height);

        public BoxFrog()
        {
            X = 200;
            Y = 500;
            Width = 56;
            Height = 56;
            ItemInBox = new ItemFrog();
            BoxImg = Image.FromFile("Textures/Box/tile000.png");
        }
    }
}