using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model
{
    public class ItemGelatine : IItems
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Image ItemImg { get; set; }

        public ItemGelatine()
        {
            Height = 32;
            Width = 32;
            Name = "Желатин";
            ItemImg = Image.FromFile("Textures/Items/gelatine4x.png");
        }
    }
}
