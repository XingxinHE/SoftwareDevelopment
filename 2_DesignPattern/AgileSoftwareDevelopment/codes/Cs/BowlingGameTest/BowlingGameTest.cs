using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BowlingGame;


namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game g;

        public BowlingGameTest()
        {
            this.SetUp();
        }

        public void SetUp()
        {
            g = new Game();
        }

        [TestMethod]
        public void TestScroeNoThrow()
        {
            Frame f = new Frame();
            Assert.AreEqual(0, f.GetScore());
        }

        [TestMethod]
        public void TestScoreNoThrows()
        {
            Frame f = new Frame();
            f.Add(5);
            Assert.AreEqual(5, f.GetScore());
        }

        //[TestMethod]
        //public void TestOneThrow()
        //{
        //    //Game g = new Game();
        //    g.Add(5);
        //    Assert.AreEqual(5, g.Score());
        //    Assert.AreEqual(1, g.GetCurrentFrame());
        //}

        [TestMethod]
        public void TestTwoThrowsNoMark()
        {
            //Game g = new Game();
            g.Add(5);
            g.Add(4);
            Assert.AreEqual(9, g.Score());
            Assert.AreEqual(2, g.GetCurrentFrame());
        }

        [TestMethod]
        public void TestFourThrowsNoMark()
        {
            //Game g = new Game();
            g.Add(5);
            g.Add(4);
            g.Add(7);
            g.Add(2);

            Assert.AreEqual(18, g.Score());
            Assert.AreEqual(9, g.ScoreForFrame(1));
            Assert.AreEqual(18, g.ScoreForFrame(2));
        }

        [TestMethod]
        public void TestSimpleSpare()
        {
            g.Add(3);
            g.Add(7);
            g.Add(3);
            Assert.AreEqual(13, g.ScoreForFrame(1));
            Assert.AreEqual(2, g.GetCurrentFrame());
        }

        [TestMethod]
        public void TestSimpleFrameAfterSpace()
        {
            g.Add(3);
            g.Add(7);
            g.Add(3);
            g.Add(2);
            Assert.AreEqual(13, g.ScoreForFrame(1));
            Assert.AreEqual(18, g.ScoreForFrame(2));
            Assert.AreEqual(18, g.Score());
            Assert.AreEqual(3, g.GetCurrentFrame());
        }

        [TestMethod]
        public void TestSimpleStrike()
        {
            g.Add(10);
            g.Add(3);
            g.Add(6);
            Assert.AreEqual(19, g.ScoreForFrame(1));
            Assert.AreEqual(28, g.Score());
            Assert.AreEqual(3, g.GetCurrentFrame());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            for (int i = 0; i < 12; i++)
            {
                g.Add(10);
            }
            Assert.AreEqual(300, g.Score());
            Assert.AreEqual(11, g.GetCurrentFrame());
        }

        [TestMethod]
        public void TestEndOfArray()
        {
            for (int i = 0; i < 9; i++)
            {
                g.Add(0);
                g.Add(0);
            }

            g.Add(2);
            g.Add(8);  //10th frame spare

            g.Add(10); //strike in last position of array
            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void TestSampleGame()
        {
            g.Add(1);
            g.Add(4);
            g.Add(4);
            g.Add(5);
            g.Add(6);
            g.Add(4);
            g.Add(5);
            g.Add(5);
            g.Add(10);
            g.Add(0);
            g.Add(1);
            g.Add(7);
            g.Add(3);
            g.Add(6);
            g.Add(4);
            g.Add(10);
            g.Add(2);
            g.Add(8);
            g.Add(6);
            Assert.AreEqual(133, g.Score());
        }

        [TestMethod]
        public void TestHeartBreak()
        {
            for (int i = 0; i < 11; i++)
            {
                g.Add(10);
                g.Add(9);
                Assert.AreEqual(299, g.Score());
            }
        }

        public void TestTenthFrameSpare()
        {
            for (int i = 0; i < 9; i++)
            {
                g.Add(10);
                g.Add(9);
                g.Add(1);
                g.Add(1);
                Assert.AreEqual(270, g.Score());
            }
        }

    }
}
