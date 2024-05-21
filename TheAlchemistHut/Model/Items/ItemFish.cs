using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model
{
    public class ItemFish : IItems
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Name { get; set; }
        public Image ItemImg { get; set; }

        public ItemFish() 
        {
            Height = 32;
            Width = 32;
            Name = "Рыба";
            ItemImg = Image.FromFile("Textures/Items/fish.png");
        }
    }
}
