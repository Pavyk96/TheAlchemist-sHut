using System.Drawing;

namespace TheAlchemist_sHut.Model
{
    public class ItemGhost : IItems
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Image ItemImg { get; set; }
        public Rectangle Bounds { get; }

        public ItemGhost()
        {
            Height = 32;
            Width = 32;

            ItemImg = Image.FromFile("Textures/Items/ghost4x.png");
        }
    }
}