using System.Drawing;
using System.Net.Mime;

namespace TheAlchemist_sHut.Model
{
    public class ItemSpook : IItems
    {
        public string Name { get; set; }  
        public int Height { get; set; }
        public int Width { get; set; }
        public Image ItemImg { get; set; }
        
        public ItemSpook()
        {
            Height = 32;
            Width = 32;
            Name = "Спук";
            ItemImg = Image.FromFile("Textures/Items/spook.png");
        }
    }
}