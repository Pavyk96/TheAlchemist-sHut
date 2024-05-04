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
            if (player.GoLeft && player.X >= 0)
            {
                player.X -= player.Speed;
                if (player.Item != null) player.Item.X -= player.Speed;
                AnimatePlayer(player ,4, 7);
            } 
            else if (player.GoRight && player.X + player.Width <= form.Width)
            {
                player.X += player.Speed;
                if (player.Item != null) player.Item.X += player.Speed;
                AnimatePlayer(player, 8, 11);
            }
            else if (player.GoUp && player.Y >= 0)
            {
                player.Y -= player.Speed;
                if (player.Item != null) player.Item.Y -= player.Speed;
                AnimatePlayer(player, 12, 15);
            }
            else if (player.GoDown && player.Y + player.Height <= form.Height)
            {
                player.Y += player.Speed;
                if (player.Item != null) player.Item.Y += player.Speed;
                AnimatePlayer(player, 0, 3);
            }
            else
            {
                AnimatePlayer(player, 0, 0);
            }
        }

        private static void AnimatePlayer(Player player ,int start, int end)
        {
            player.SlowDownFrameRate += 1;

            if (player.SlowDownFrameRate == 4)
            {
                player.Step++;
                player.SlowDownFrameRate = 0;
            }


            if (player.Step > end || player.Step < start)
                player.Step = start;

            player.PlayerImg = Image.FromFile(player.PlayerMovements[player.Step]);
        }

        public static void StartMove(KeyEventArgs e, Player player)
        {
            var key = e.KeyCode;

            switch (key)
            {
                case Keys.A:
                    player.GoLeft = true;
                    break;

                case Keys.D:
                    player.GoRight = true;
                    break;

                case Keys.W:
                    player.GoUp = true;
                    break;

                case Keys.S:
                    player.GoDown = true;
                    break;
            }
        }

        public static void StopMove(KeyEventArgs e, Player player)
        {
            var key = e.KeyCode;

            switch (key)
            {
                case Keys.A:
                    player.GoLeft = false;
                    break;

                case Keys.D:
                    player.GoRight = false;
                    break;

                case Keys.W:
                    player.GoUp = false;
                    break;

                case Keys.S:
                    player.GoDown = false;
                    break;
            }
        }
    }
}
