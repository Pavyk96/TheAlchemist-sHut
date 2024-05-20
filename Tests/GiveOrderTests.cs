using System;
using System.Numerics;
using TheAlchemist_sHut;
using TheAlchemist_sHut.Controller;
using TheAlchemist_sHut.Model;
using TheAlchemist_sHut.Model.Potions;

namespace Tests;

[TestFixture]
public class GiveOrderTests
{
    [Test]
    public void GiveOrder_PlayerMadeCorrectPotion()
    {
        var player = new Player();
        player.HoldingItem = true;
        player.Potion = new PotionHappy();
        var visitor = new Visitor();
        visitor.Order = new PotionHappy();

        InteractionItems.GiveOrder(player, visitor);

        Assert.AreEqual(50, player.Sum);
        Assert.IsFalse(player.HoldingItem);
        Assert.IsNull(player.Item);
        Assert.IsNull(player.Potion);
        Assert.IsFalse(visitor.IsAccepted);
    }

    [Test]
    public void GiveOrder_PlayerHasIncorrectPotion_DecreasesPlayerSumAndSetsVisitorIsAcceptedToFalse()
    {
        var player = new Player();
        player.HoldingItem = true;
        player.Potion = new PotionHappy();
        var visitor = new Visitor();
        visitor.Order = new PotionBones(); ;

        InteractionItems.GiveOrder(player, visitor);

        Assert.AreEqual(-100, player.Sum);
        Assert.IsFalse(player.HoldingItem);
        Assert.IsNull(player.Item);
        Assert.IsNull(player.Potion);
        Assert.IsFalse(visitor.IsAccepted);
    }
}