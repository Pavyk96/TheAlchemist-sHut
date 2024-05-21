using System.Drawing;

namespace TheAlchemist_sHut.Model
{
    public interface IItems
    {
        int Height { get; set; }
        int Width { get; set; }
        string Name { get; set; }
        Image ItemImg { get; set; }
    }
}