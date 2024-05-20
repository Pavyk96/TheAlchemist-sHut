using System.Drawing;

namespace TheAlchemist_sHut.Model
{
    public class ItemMane : IItems
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Image ItemImg { get; set; }

        public ItemMane()
        {
            Height = 32;
            Width = 32;
            Name = "Грива";
            ItemImg = Image.FromFile("Textures/Items/horseman.png");
        }
    }
}