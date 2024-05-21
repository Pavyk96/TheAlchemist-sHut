using System.Drawing;

namespace TheAlchemist_sHut.Model
{
    public class ItemGhost : IItems
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Image ItemImg { get; set; }

        public ItemGhost()
        {
            Height = 32;
            Width = 32;
            Name = "Призрак";
            ItemImg = Image.FromFile("Textures/Items/ghost4x.png");
        }
    }
}