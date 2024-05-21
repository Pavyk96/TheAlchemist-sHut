using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model
{
    public class ItemPepper : IItems
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Name { get; set; }
        public Image ItemImg { get; set; }

        public ItemPepper()
        {
            Height = 32;
            Width = 32;
            Name = "Перец";
            ItemImg = Image.FromFile("Textures/Items/chilli_paper.png");
        }
    }
}
