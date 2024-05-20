using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAlchemist_sHut.Model.Potions;

namespace TheAlchemist_sHut.Model
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed {  get; set; }
        public bool HoldingItem { get; set; }
        public bool IsGotOrder { get; set; }
        public bool GoUp, GoDown, GoRight, GoLeft;
        public Image PlayerImg;
        public readonly int Height = 90;
        public readonly int Width = 90;
        public List<string> PlayerMovements = new List<string>();
        public int Step = 0;
        public int SlowDownFrameRate = 0;
        public int Sum = 0;

        public IItems Item;
        public IPotion Potion;
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);

        public Player() 
        {
            X = 916;
            Y = 584;
            Speed = 11; 
            HoldingItem = false;
            IsGotOrder = false;

            PlayerMovements = Directory.GetFiles("Textures/PlayerAnimation", "*.png").ToList();
            PlayerImg = Image.FromFile(PlayerMovements[0]);

            Item = null;
            Potion = null;
        }
    }
}