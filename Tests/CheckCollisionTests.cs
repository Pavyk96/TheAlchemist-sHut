using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAlchemist_sHut.Controller;
using TheAlchemist_sHut.Model;

namespace Tests
{
    [TestFixture]
    public class CheckCollisionTests
    {
        [Test]
        public void CheckCollisions_WithCollisionOnLeft()
        {
            var player = new Player() { X = 15, Y = 10 };
            var map = new Map();
            var obj = new Table() { X = 10, Y = 10, Height = 10, Width = 10, Img = null };
            map.Objects.Add(obj);

            InteractionItems.CheckCollisions(player);

            Assert.IsFalse(player.GoLeft);
        }

        [Test]
        public void CheckCollisions_WithCollisionOnRight()
        {
            var player = new Player() { X = 5, Y = 10 };
            var map = new Map();
            var obj = new Table() { X = 10, Y = 10, Height = 10, Width = 10, Img = null };
            map.Objects.Add(obj);

            InteractionItems.CheckCollisions(player);

            Assert.IsFalse(player.GoRight);
        }

        [Test]
        public void CheckCollisions_WithCollisionOnTop()
        {
            var player = new Player() { X = 10, Y = 15 };
            var map = new Map();
            var obj = new Table() { X = 10, Y = 10, Height = 10, Width = 10, Img = null };
            map.Objects.Add(obj);

            InteractionItems.CheckCollisions(player);

            Assert.IsFalse(player.GoUp);
        }

        [Test]
        public void CheckCollisions_WithCollisionOnBottom()
        {
            var player = new Player() { X = 10, Y = 5 };
            var map = new Map();
            var obj = new Table() { X = 10, Y = 10, Height = 10, Width = 10, Img = null };
            map.Objects.Add(obj);

            InteractionItems.CheckCollisions(player);

            Assert.IsFalse(player.GoRight);
        }

        [Test]
        public void CheckCollisions_NoCollision()
        {
            var player = new Player() { X = 20, Y = 20 };
            var map = new Map();
            var obj = new Table() { X = 10, Y = 10, Height = 10, Width = 10, Img = null };
            map.Objects.Add(obj);

            InteractionItems.CheckCollisions(player);

            Assert.IsFalse(player.GoRight);
            Assert.IsFalse(player.GoLeft);
            Assert.IsFalse(player.GoDown);
            Assert.IsFalse(player.GoUp);
        }

    }
}
