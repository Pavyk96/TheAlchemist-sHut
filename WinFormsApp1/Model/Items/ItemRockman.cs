using System.Drawing;

namespace TheAlchemist_sHut.Model
{
    public class ItemRockman : IItems
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Image ItemImg { get; set; }

        public ItemRockman()
        {
            Height = 32;
            Width = 32;
            Name = "Камень";
            ItemImg = Image.FromFile("Textures/Items/rockman4x.png");
        }
    }
}