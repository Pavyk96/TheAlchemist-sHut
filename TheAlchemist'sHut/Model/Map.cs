using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model
{
    class Map
    {
        public int Width { get; }
        public int Height { get; }

        public Map (int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
