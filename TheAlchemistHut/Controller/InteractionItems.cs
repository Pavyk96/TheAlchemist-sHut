using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TheAlchemist_sHut.Model;
using TheAlchemist_sHut.Model.Objects;
using TheAlchemist_sHut.Model.Potions;

namespace TheAlchemist_sHut.Controller
{
    public class InteractionItems
    {
        private static Random rnd = new Random();
        public static void PickItems(IItems item, Player player)
        {
            player.Item = item;
            player.HoldingItem = true;
            //player.Item.X = player.X + (player.Width - item.Width) / 2;
            //player.Item.Y = player.Y - 30;
        }
        
        public static void ThrowItem(Player player)
        {
            player.Item = null;
            player.HoldingItem = false;
        }

        public static void GetPotion(Player player, Boiler boiler)
        {
            var firstIngredient = boiler.AddedIngredients[0].Name;
            var secondIngredient = boiler.AddedIngredients[1].Name;
            var thirdIngredient = boiler.AddedIngredients[2].Name;

            if (firstIngredient == "Спук"
                && secondIngredient == "Призрак"
                && thirdIngredient == "Грива")
            {
                MessageBox.Show("Вы приготовили зелье счастья!");
                ThrowItem(player);
                var potion = new PotionHappy();
                player.Item = potion; 
                player.Potion = potion;
                PickItems(potion, player);
                player.HoldingItem = true;
            }
            else if (firstIngredient == "Камень"
                && secondIngredient == "Призрак"
                && thirdIngredient == "Желатин")
            {
                MessageBox.Show("Вы приготовили зелье силы!");
                ThrowItem(player);
                var potion = new PotionPower();
                player.Item = potion; 
                player.Potion = potion;
                PickItems(potion, player);
                player.HoldingItem = true;
            }
            else if (firstIngredient == "Рыба"
                && secondIngredient == "Перец"
                && thirdIngredient == "Призрак")
            {
                MessageBox.Show("Вы приготовили зелье скорости!");
                ThrowItem(player);
                var potion = new PotionSpeed();
                player.Item = potion; 
                player.Potion = potion;
                PickItems(potion, player);
                player.HoldingItem = true;
            }
            else if (firstIngredient == "Спук"
                && secondIngredient == "Камень"
                && thirdIngredient == "Рыба")
            {
                MessageBox.Show("Вы приготовили умонстрительное зелье!");
                ThrowItem(player);
                var potion = new PotionMonster();
                player.Item = potion; 
                player.Potion = potion;
                PickItems(potion, player);
                player.HoldingItem = true;
            }
            else if (firstIngredient == "Желатин"
                && secondIngredient == "Грива"
                && thirdIngredient == "Перец")
            {
                MessageBox.Show("Вы приготовили зелье инвизибл!");
                ThrowItem(player);
                var potion = new PotionInviz();
                player.Item = potion; 
                player.Potion = potion;
                PickItems(potion, player);
                player.HoldingItem = true;
            }
            else if (firstIngredient == "Грива"
                && secondIngredient == "Спук"
                && thirdIngredient == "Камень")
            {
                MessageBox.Show("Вы приготовили сыворотку правды!");
                ThrowItem(player);
                var potion = new PotionTruth();
                player.Item = potion; 
                player.Potion = potion;
                PickItems(potion, player);
                player.HoldingItem = true;
            }
            else if (firstIngredient == "Перец"
                && secondIngredient == "Рыба"
                && thirdIngredient == "Спук")
            {
                MessageBox.Show("Вы приготовили костерост!");
                ThrowItem(player);
                var potion = new PotionBones();
                player.Item = potion; 
                player.Potion = potion;
                PickItems(potion, player);
                player.HoldingItem = true;
            }
            else if (firstIngredient == "Желатин"
                && secondIngredient == "Перец"
                && thirdIngredient == "Грива")
            {
                MessageBox.Show("Вы приготовили болтливое зелье!");
                ThrowItem(player);
                var potion = new PotionTalkative();
                player.Item = potion; 
                player.Potion = potion;
                PickItems(potion, player);
                player.HoldingItem = true;
            }
            else
            {
                MessageBox.Show("У вас получилась мутная вода");
                ThrowItem(player);
                var potion = new PotionBad(firstIngredient, secondIngredient, thirdIngredient);
                player.Item = potion; 
                player.Potion = potion;
                PickItems(potion, player);
                player.HoldingItem = true;
            }

            boiler.AddedIngredients.Clear();
        }

        public static void GiveOrder(Player player, Visitor visitor)
        {
            if (player.HoldingItem && player.Potion != null
                && player.Potion.FirstIngredient == visitor.Order.FirstIngredient
                && player.Potion.SecondIngredient == visitor.Order.SecondIngredient
                && player.Potion.ThirdIngredient == visitor.Order.ThirdIngredient)
            {
                player.Sum += 50;
                player.HoldingItem = false;
                player.Item = null;
                player.Potion = null;
                visitor.IsAccepted = false;
            }
            else
            {
                player.Sum -= 100;
                player.HoldingItem = false;
                player.Item = null;
                player.Potion = null;
                visitor.IsAccepted = false;
            }
        }

        public static void TakeOrder(Player player, Visitor visitor)
        {
            var rnd = new Random();
            var potions = new List<IPotion> { new PotionHappy(), 
                                            new PotionPower(), 
                                            new PotionSpeed(),
                                            new PotionMonster(),
                                            new PotionInviz(),
                                            new PotionTruth(),
                                            new PotionBones(),
                                            new PotionTalkative() };
            visitor.Order = potions[rnd.Next(8)];
            visitor.IsAccepted = true;
            player.IsGotOrder = true;
        }
        
        public static void CheckCollisions(Player player)
        {
            foreach (var e in TheAlchemist_sHut.Form1.map.Objects)
                if (player.Bounds.IntersectsWith(e.Bounds))
                {
                    if (player.Bounds.Left > e.Bounds.Left && player.Bounds.Left < e.Bounds.Right)
                        player.GoLeft = false;
                    if (player.Bounds.Right < e.Bounds.Right && player.Bounds.Right > e.Bounds.Left)
                        player.GoRight = false;
                    if (player.Bounds.Top > e.Bounds.Top && player.Bounds.Top < e.Bounds.Bottom)
                        player.GoUp = false;
                    if (player.Bounds.Bottom < e.Bounds.Bottom && player.Bounds.Bottom > e.Bounds.Top)
                        player.GoDown = false;
                }
        }
    }
}