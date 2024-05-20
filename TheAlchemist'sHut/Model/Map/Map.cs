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
        public List<IMap> Objects { get; set; }
        public Visitor Visitor { get; set; }
        public Boiler Boiler { get; set; }
        public Table Table { get; set; }

        public Map ()
        {
            Boxes = new List<IBox> {
                new BoxSpook(),
                new BoxMane(),
                new BoxGost(),
                new BoxRockman(),
                new BoxFish(),
                new BoxGelatine(),
                new BoxPepper(),
            };
            Visitor = new Visitor();
            Boiler = new Boiler();
            Table = new Table();
            Objects = new List<IMap>
            {
                Visitor,
                Boiler,
                Table,
                new BoxSpook(),
                new BoxMane(),
                new BoxGost(),
                new BoxRockman(),
                new BoxFish(),
                new BoxGelatine(),
                new BoxPepper(),
            };
        }
    }
}
