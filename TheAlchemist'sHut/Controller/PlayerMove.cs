using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TheAlchemist_sHut.Model;

namespace TheAlchemist_sHut.Controller
{
    public class PlayerMove
    {
        public static void MakeMove(Player player, Form1 form)
        {
            if (player.goLeft && player.x >= 0)
            {
                player.x -= player.speed;
                AnimatePlayer(player ,4, 7);
            } 
            else if (player.goRight && player.x + player.width <= form.Width)
            {
                player.x += player.speed;
                AnimatePlayer(player, 8, 11);
            }
            else if (player.goUp && player.y >= 0)
            {
                player.y -= player.speed;
                AnimatePlayer(player, 12, 15);
            }
            else if (player.goDown && player.y + player.height <= form.Height)
            {
                player.y += player.speed;
                AnimatePlayer(player, 0, 3);
            }
            else
            {
                AnimatePlayer(player, 0, 0);
            }
        }

        private static void AnimatePlayer(Player player ,int start, int end)
        {
            player.slowDownFrameRate += 1;

            if (player.slowDownFrameRate == 4)
            {
                player.step++;
                player.slowDownFrameRate = 0;
            }


            if (player.step > end || player.step < start)
                player.step = start;

            player.playerImg = Image.FromFile(player.playerMovements[player.step]);
        }

        public static void StartMove(KeyEventArgs e, Player player)
        {
            var key = e.KeyCode;

            switch (key)
            {
                case Keys.A:
                    player.goLeft = true;
                    break;

                case Keys.D:
                    player.goRight = true;
                    break;

                case Keys.W:
                    player.goUp = true;
                    break;

                case Keys.S:
                    player.goDown = true;
                    break;
            }
        }

        public static void StopMove(KeyEventArgs e, Player player)
        {
            var key = e.KeyCode;

            switch (key)
            {
                case Keys.A:
                    player.goLeft = false;
                    break;

                case Keys.D:
                    player.goRight = false;
                    break;

                case Keys.W:
                    player.goUp = false;
                    break;

                case Keys.S:
                    player.goDown = false;
                    break;
            }
        }
    }
}
