using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TheAlchemist_sHut.Controller;
using TheAlchemist_sHut.Model.Potions;

namespace TheAlchemist_sHut.Model
{
    public class Boiler : IMap
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Image Img { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);
        public List<IItems> AddedIngredients { get; set; }

        // public List<IPotion> Potions { get; set; }


        public Boiler() 
        {
            X = 421;
            Y = 287;
            Width = 183;
            Height = 193;
            Img = Image.FromFile("Textures/Map/boiler.png");
            AddedIngredients = new List<IItems>();
            //Potions = new List<IPotion> { new PotionHappy() };
        }
    }
}
