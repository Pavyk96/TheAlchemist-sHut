using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAlchemist_sHut.Model.Potions
{
    public interface IPotion
    {
        string FirstIngredient { get; set; }
        string SecondIngredient { get; set; }
        string ThirdIngredient { get; set; }
        string Name { get; set; }

        List<IItems> Ingredients { get; set; } 
    }
}
