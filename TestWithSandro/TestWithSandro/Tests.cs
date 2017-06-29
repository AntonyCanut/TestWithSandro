﻿using System;
using ClassLibrary;
using NUnit.Framework;

namespace TestWithSandro
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Should_Have_2_Players() 
        {
            TicTacToe t = new TicTacToe();
            Assert.AreEqual(t.players, 2);
        }

        [Test]
        public void Should_Player_One_Play_First()
        {
            TicTacToe t = new TicTacToe();
            Assert.AreEqual(t.CurrentPlayer, 1);
        }
        
        [Test]
        public void Should_Next_Player()
        {
            TicTacToe t = new TicTacToe();

            t.Next();
            
            Assert.AreEqual(t.CurrentPlayer, 2);
        }
    }
}
