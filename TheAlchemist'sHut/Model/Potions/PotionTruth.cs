﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model.Potions
{
    public class PotionTruth : IPotion, IItems
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

        public PotionTruth()
        {
            FirstIngredient = "Грива";
            SecondIngredient = "Спук";
            ThirdIngredient = "Камень";
            Height = 32;
            Width = 32;
            Name = "зелье правды";
            ItemImg = Image.FromFile("Textures/Potions/potionTruth.png");
            Ingredients = new List<IItems> { new ItemMane(), new ItemSpook(), new ItemRockman() };
        }
    }
}