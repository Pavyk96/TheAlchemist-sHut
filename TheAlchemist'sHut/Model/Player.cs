using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed {  get; set; }
        public bool HoldingItem { get; set; }

        public bool GoUp, GoDown, GoRight, GoLeft;

        public Image PlayerImg;

        public readonly int Height = 72;

        public readonly int Width = 72;

        public List<string> PlayerMovements = new List<string>();

        public int Step = 0;

        public int SlowDownFrameRate = 0;

        public IItems Item;
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);

        public Player() 
        {
            X = 0;
            Y = 0;
            Speed = 6; 
            HoldingItem = false;

            PlayerMovements = Directory.GetFiles("Textures/PlayerAnimation", "*.png").ToList();
            PlayerImg = Image.FromFile(PlayerMovements[0]);

            Item = null;
        }
    }
}