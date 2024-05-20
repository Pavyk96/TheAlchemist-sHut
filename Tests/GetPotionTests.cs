using System;
using System.Numerics;
using TheAlchemist_sHut;
using TheAlchemist_sHut.Controller;
using TheAlchemist_sHut.Model;
using TheAlchemist_sHut.Model.Potions;
using NUnit.Framework;

namespace Tests;

[TestFixture]
public class GetPotionTests
{
    [Test]
    public void GetPotion_HappyIngredients_CreatesHappyPotion()
    {
        var player = new Player();
        var map = new Map();
        map.Boiler.AddedIngredients.Add(new ItemSpook());
        map.Boiler.AddedIngredients.Add(new ItemGhost());
        map.Boiler.AddedIngredients.Add(new ItemMane());

        InteractionItems.GetPotion(player);

        Assert.AreEqual(typeof(PotionHappy), player.Potion.GetType());
        Assert.IsTrue(player.HoldingItem);
    }

    [Test]
    public void GetPotion_PowerIngredients_CreatesPowerPotion()
    {
        var player = new Player();
        var map = new Map();
        map.Boiler.AddedIngredients.Add(new ItemRockman());
        map.Boiler.AddedIngredients.Add(new ItemGhost());
        map.Boiler.AddedIngredients.Add(new ItemGelatine());

        InteractionItems.GetPotion(player);

        Assert.AreEqual(typeof(PotionPower), player.Potion.GetType());
        Assert.IsTrue(player.HoldingItem);
    }

    [Test]
    public void GetPotion_SpeedIngredients_CreatesSpeedPotion()
    {
        var player = new Player();
        var map = new Map();
        map.Boiler.AddedIngredients.Add(new ItemFish());
        map.Boiler.AddedIngredients.Add(new ItemPepper());
        map.Boiler.AddedIngredients.Add(new ItemGhost());

        InteractionItems.GetPotion(player);

        Assert.AreEqual(typeof(PotionSpeed), player.Potion.GetType());
        Assert.IsTrue(player.HoldingItem);
    }

    [Test]
    public void GetPotion_MonsterIngredients_CreatesMonsterPotion()
    {
        var player = new Player();
        var map = new Map();
        map.Boiler.AddedIngredients.Add(new ItemSpook());
        map.Boiler.AddedIngredients.Add(new ItemRockman());
        map.Boiler.AddedIngredients.Add(new ItemFish());

        InteractionItems.GetPotion(player);

        Assert.AreEqual(typeof(PotionMonster), player.Potion.GetType());
        Assert.IsTrue(player.HoldingItem);
    }

    [Test]
    public void GetPotion_InvizIngredients_CreatesInvizPotion()
    {
        var player = new Player();
        var map = new Map();
        map.Boiler.AddedIngredients.Add(new ItemGelatine());
        map.Boiler.AddedIngredients.Add(new ItemMane());
        map.Boiler.AddedIngredients.Add(new ItemPepper());

        InteractionItems.GetPotion(player);

        Assert.AreEqual(typeof(PotionInviz), player.Potion.GetType());
        Assert.IsTrue(player.HoldingItem);
    }

    [Test]
    public void GetPotion_TruthIngredients_CreatesTruthPotion()
    {
        var player = new Player();
        var map = new Map();
        map.Boiler.AddedIngredients.Add(new ItemMane());
        map.Boiler.AddedIngredients.Add(new ItemSpook());
        map.Boiler.AddedIngredients.Add(new ItemRockman());

        InteractionItems.GetPotion(player);

        Assert.AreEqual(typeof(PotionTruth), player.Potion.GetType());
        Assert.IsTrue(player.HoldingItem);
    }

    [Test]
    public void GetPotion_BonesIngredients_CreatesBonesPotion()
    {
        var player = new Player();
        var map = new Map();
        map.Boiler.AddedIngredients.Add(new ItemPepper());
        map.Boiler.AddedIngredients.Add(new ItemFish());
        map.Boiler.AddedIngredients.Add(new ItemSpook());

        InteractionItems.GetPotion(player);

        Assert.AreEqual(typeof(PotionBones), player.Potion.GetType());
        Assert.IsTrue(player.HoldingItem);
    }

    [Test]
    public void GetPotion_TalkativeIngredients_CreatesTalkativePotion()
    {
        var player = new Player();
        var map = new Map();
        map.Boiler.AddedIngredients.Add(new ItemGelatine());
        map.Boiler.AddedIngredients.Add(new ItemPepper());
        map.Boiler.AddedIngredients.Add(new ItemMane());

        InteractionItems.GetPotion(player);

        Assert.AreEqual(typeof(PotionTalkative), player.Potion.GetType());
        Assert.IsTrue(player.HoldingItem);
    }

    [Test]
    public void GetPotion_InvalidIngredients_CreatesBadPotion()
    {
        var player = new Player();
        var map = new Map();
        map.Boiler.AddedIngredients.Add(new ItemRockman());
        map.Boiler.AddedIngredients.Add(new ItemGhost());
        map.Boiler.AddedIngredients.Add(new ItemFish());

        InteractionItems.GetPotion(player);

        Assert.AreEqual(typeof(PotionBad), player.Potion.GetType());
        Assert.IsTrue(player.HoldingItem);
    }
}
