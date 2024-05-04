using System.Drawing;
using System.Net.Mime;

namespace TheAlchemist_sHut.Model
{
    public class ItemFrog : IItems
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Image ItemImg { get; set; }
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);

        public ItemFrog(Player player)
        {
            X = player.X + 15;
            Y = player.Y - 25;

            Height = 24;
            Width = 24;

            ItemImg = Image.FromFile("Textures/Items/apple.png");
        }
        
        public ItemFrog()
        {
            Height = 44;
            Width = 44;

            ItemImg = Image.FromFile("Textures/Items/frog4x.png");
        }
    }
}