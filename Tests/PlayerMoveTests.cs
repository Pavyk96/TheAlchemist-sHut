using System;
using System.Numerics;
using TheAlchemist_sHut;
using TheAlchemist_sHut.Controller;
using TheAlchemist_sHut.Model;
using TheAlchemist_sHut.Model.Objects;
using TheAlchemist_sHut.Model.Potions;

namespace Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void PlayerDirectionTest1()
    {
        var player = new Player();
        PlayerMove.StartMove(PlayerDirection.Left, player);
        Assert.IsTrue(player.GoLeft);
        PlayerMove.StartMove(PlayerDirection.Right, player);
        Assert.IsTrue(player.GoRight);
        PlayerMove.StartMove(PlayerDirection.Up, player);
        Assert.IsTrue(player.GoUp);
        PlayerMove.StartMove(PlayerDirection.Down, player);
        Assert.IsTrue(player.GoDown);
    }

    [Test]
    public void PlayerDirectionTest2()
    {
        var player = new Player();
        PlayerMove.StopMove(PlayerDirection.Left, player);
        Assert.IsFalse(player.GoLeft);
        PlayerMove.StopMove(PlayerDirection.Right, player);
        Assert.IsFalse(player.GoRight);
        PlayerMove.StopMove(PlayerDirection.Up, player);
        Assert.IsFalse(player.GoUp);
        PlayerMove.StopMove(PlayerDirection.Down, player);
        Assert.IsFalse(player.GoDown);
    }

    [Test]
    public void PlayerMoveTest()
    {
        var player = new Player();
        var form = new Form1();
        PlayerMove.MakeMove(player, form);
        Assert.IsTrue(player.X == 916 & player.Y == 584);
        player.GoRight = true;
        PlayerMove.MakeMove(player, form);
        Assert.IsTrue(player.X == 916 + 11 & player.Y == 584);
        //и так далее
    }

    [Test]
    public void PickItemTest()
    {
        var player = new Player();
        var boxGelatine = new BoxGelatine();

        InteractionItems.PickItems(boxGelatine.ItemInBox, player);
        Assert.IsTrue(player.Item == boxGelatine.ItemInBox);
    }

    [Test]
    public void ThrowItemTest()
    {
        var player = new Player();
        player.Item = new ItemFish();
        InteractionItems.ThrowItem(player);
        Assert.IsTrue(player.Item == null);
    }

}
