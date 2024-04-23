using System;
using System.Collections.Generic;
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
        public Player Player { get; set; }

        public static bool goUp, goDown, goRight, goLeft;
        public static bool IsMoving = false;

        public static void StartMove(KeyEventArgs e)
        {
            var key = e.KeyCode;

            switch (key)
            {
                case Keys.A:
                    goLeft = true;
                    break;

                case Keys.D:
                    goRight = true;
                    break;

                case Keys.W:
                    goUp = true;
                    break;

                case Keys.S:
                    goDown = true;
                    break;
            }
        }

        public static void StopMove(KeyEventArgs e)
        {
            var key = e.KeyCode;

            switch (key)
            {
                case Keys.A:
                    goLeft = false;
                    break;

                case Keys.D:
                    goRight = false;
                    break;

                case Keys.W:
                    goUp = false;
                    break;

                case Keys.S:
                    goDown = false;
                    break;
            }
        }

        public static void MakeMove(PictureBox player)
        {
            foreach (Control control in Form1.ActiveForm.Controls)
            {
                if (control is PictureBox && !(control.Name == "player")
                    && player.Bounds.IntersectsWith(control.Bounds))
                {
                    if (player.Left > control.Left && player.Left < control.Right)
                        goLeft = false;
                    if (player.Right < control.Right && player.Right > control.Left)
                        goRight = false;
                    if (player.Top > control.Top && player.Top < control.Bottom)
                        goUp = false;
                    if (player.Bottom < control.Bottom && player.Bottom > control.Top)
                        goDown = false;
                }
            }
            if (goLeft == true && player.Left > 0)
                player.Left -= Player.Speed;
            if (goRight == true && player.Left + player.Width < 1920)
                player.Left += Player.Speed;
            if (goUp == true && player.Top > 0)
                player.Top -= Player.Speed;
            if (goDown == true && player.Top + player.Height < 1080)
                player.Top += Player.Speed;
        }
    }
}
