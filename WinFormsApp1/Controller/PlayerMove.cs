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
    public enum PlayerDirection
    {
        Up,
        Down,
        Left,
        Right
    }

    public class PlayerMove
    {
        public static void MakeMove(Player player, Form1 form)
        {
            InteractionItems.CheckCollisions(player);
            if (player.GoLeft && player.X >= 0)
            {
                player.X -= player.Speed;
                AnimatePlayer(player, 4, 7);
            }
            else if (player.GoRight && player.X + player.Width <= form.Width)
            {
                player.X += player.Speed;
                AnimatePlayer(player, 8, 11);
            }
            else if (player.GoUp && player.Y >= 0)
            {
                player.Y -= player.Speed;
                AnimatePlayer(player, 12, 15);
            }
            else if (player.GoDown && player.Y + player.Height <= form.Height)
            {
                player.Y += player.Speed;
                AnimatePlayer(player, 0, 3);
            }
            else
                AnimatePlayer(player, 0, 0);
        }

        private static void AnimatePlayer(Player player, int start, int end)
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

        public static void StartMove(PlayerDirection direction, Player player)
        {
            switch (direction)
            {
                case PlayerDirection.Left:
                    player.GoLeft = true;
                    break;

                case PlayerDirection.Right:
                    player.GoRight = true;
                    break;

                case PlayerDirection.Up:
                    player.GoUp = true;
                    break;

                case PlayerDirection.Down:
                    player.GoDown = true;
                    break;
            }
        }

        public static void StopMove(PlayerDirection direction, Player player)
        {
            switch (direction)
            {
                case PlayerDirection.Left:
                    player.GoLeft = false;
                    break;

                case PlayerDirection.Right:
                    player.GoRight = false;
                    break;

                case PlayerDirection.Up:
                    player.GoUp = false;
                    break;

                case PlayerDirection.Down:
                    player.GoDown = false;
                    break;
            }
        }
    }
}