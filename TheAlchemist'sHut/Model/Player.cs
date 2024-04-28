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
        public int x { get; set; }
        public int y { get; set; }
        public int speed {  get; set; }
        public bool holdingItem { get; set; }

        public bool goUp, goDown, goRight, goLeft;

        public Image playerImg;

        public int height = 72;

        public int width = 72;

        public List<string> playerMovements = new List<string>();

        public int step = 0;

        public int slowDownFrameRate = 0;

        public Player() 
        {
            x = 0;
            y = 0;
            speed = 6; 
            holdingItem = false;

            playerMovements = Directory.GetFiles("Textures/PlayerAnimation", "*.png").ToList();
            playerImg = Image.FromFile(playerMovements[0]);
        }
    }
}