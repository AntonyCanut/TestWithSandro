using System;
using ClassLibrary;
using NUnit.Framework;

namespace TestWithSandro
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Should_Player_One_Play_First()
        {
            TicTacToe t = new TicTacToe();
            Assert.AreEqual(t.GetCurrentPlayer(), 1);
        }
        
        [Test]
        public void Should_Next_Player()
        {
            TicTacToe t = new TicTacToe();

            t.Next();
            
            Assert.AreEqual(t.GetCurrentPlayer(), 2);
        }
        
        [Test]
        public void Should_Next_Next_Player()
        {
            TicTacToe t = new TicTacToe();

            t.Next();
            t.Next();
            
            Assert.AreEqual(t.GetCurrentPlayer(), 1);
        }

        [Test]
        public void Should_First_Lose_Whith_Fist_Turn()
        {
            TicTacToe t = new TicTacToe();
            PlayGame(t, 0,0,0,1);

            var win = t.Win();
            
            Assert.AreEqual(win, false);
        }
        
        
        [Test]
        public void Should_First_Win_Whith_Fist_Turn()
        {
            TicTacToe t = new TicTacToe();
            PlayGame(t, 0,0,0,1);
            Assert.AreEqual(t.Win(), false);
            PlayGame(t, 1,1,1,2);
            Assert.AreEqual(t.Win(), false);
            PlayGame(t, 2,2,2,1);

            var win = t.Win();
            
            Assert.AreEqual(win, true);
        }

        private void PlayGame(TicTacToe t, int x, int y, int p2x, int p2y)
        {
            t.Play(x,y);
            t.Next();
            t.Play(p2x,p2y);
            t.Next();
        }
    }
}
