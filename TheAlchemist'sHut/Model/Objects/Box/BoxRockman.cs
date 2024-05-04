﻿using System.Drawing;

namespace TheAlchemist_sHut.Model.Objects
{
    public class BoxRockman : IBox
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IItems ItemInBox { get; set; }
        public Image BoxImg { get; set; }
        public Rectangle Bounds => new Rectangle(X + 10, Y + 10, Width, Height);

        public BoxRockman()
        {
            X = 200;
            Y = 200;
            Width = 56;
            Height = 56;
            ItemInBox = new ItemRockman();
            BoxImg = Image.FromFile("Textures/Box/tile000.png");
        }
    }
}