using System.Windows.Forms;
using TheAlchemist_sHut.Model;
using TheAlchemist_sHut.Model.Objects;

namespace TheAlchemist_sHut.Controller
{
    public class InteractionItems
    {
        public static void PickItems(IItems item, Player player)
        {
            player.Item = item;
            player.HoldingItem = true;
            player.Item.X = player.X + (player.Width - item.Width) / 2;
            player.Item.Y = player.Y - 30;
            
        }
        
        public static void ThrowItem(Player player)
        {
            player.Item = null;
            player.HoldingItem = false;
        }
    }
}