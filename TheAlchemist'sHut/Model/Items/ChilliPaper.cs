using System.Drawing;

namespace TheAlchemist_sHut.Model
{
    public class ChilliPaper : IItems
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Image ItemImg { get; set; }
        public Rectangle Bounds { get; }

        public ChilliPaper()
        {
            Height = 24;
            Width = 32;

            ItemImg = Image.FromFile("Textures/Items/chilli_paper.png");
        }
    }
}