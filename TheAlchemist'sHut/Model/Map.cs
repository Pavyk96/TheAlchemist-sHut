using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAlchemist_sHut.Model.Objects;

namespace TheAlchemist_sHut.Model
{
    public class Map
    {
        public List<IBox> Boxes { get; set; }

        public Map ()
        {
            Boxes = new List<IBox> { 
                new BoxFrog(), 
                new BoxPumpkin(),
                new BoxChilliPaper()
            };
        }
    }
}
