using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model.Potions
{
    public class PotionHappy : IPotion, IItems
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Name { get; set; }
        public Image ItemImg { get; set; }

        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);

        public string FirstIngredient { get; set; }
        public string SecondIngredient { get; set; }
        public string ThirdIngredient { get; set; }
        public List<IItems> Ingredients { get; set; }

        public PotionHappy()
        {
            FirstIngredient = "Спук";
            SecondIngredient = "Призрак";
            ThirdIngredient = "Грива";
            Height = 32;
            Width = 32;
            Name = "зелье счастья";
            ItemImg = Image.FromFile("Textures/Potions/potionHappy.png");
            Ingredients = new List<IItems> { new ItemSpook(), new ItemGhost(), new ItemMane() };
        }
    }
}
