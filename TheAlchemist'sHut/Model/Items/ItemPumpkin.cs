using System.Drawing;

namespace TheAlchemist_sHut.Model
{
    public class ItemPumpkin : IItems
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Image ItemImg { get; set; }
        public Rectangle Bounds { get; }

        public ItemPumpkin()
        {
            Height = 24;
            Width = 24;

            ItemImg = Image.FromFile("Textures/Items/pumpkin.png");
        }
    }
}