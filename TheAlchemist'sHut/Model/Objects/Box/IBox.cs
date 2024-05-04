using System.Drawing;

namespace TheAlchemist_sHut.Model.Objects
{
    public interface IBox
    {
        int X { get; set; }
        int Y { get; set; }

        int Width { get; set; }

        int Height { get; set; }

        IItems ItemInBox { get; set; }
        Image BoxImg { get; set; }

        Rectangle Bounds { get; }
    }
}