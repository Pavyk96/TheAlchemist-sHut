using System.Drawing;

namespace TheAlchemist_sHut.Model
{
    public interface IItems
    {
        int X { get; set; }
        int Y { get; set; }

        int Height { get; set; }

        int Width { get; set; }
        
        Image ItemImg { get; set; }

        Rectangle Bounds { get; }
    }
}