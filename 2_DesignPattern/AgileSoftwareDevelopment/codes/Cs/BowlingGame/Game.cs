using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private int itsCurrentFrame = 1;
        private bool firstThrowInFrame = true;
        private Scorer itsScorer = new Scorer();

        public int Score()
        {
            return ScoreForFrame(itsCurrentFrame);
        }

        public void Add(int pins)
        {
            itsScorer.AddThrow(pins);
            adjustCurrentFrame(pins);
        }

        private void adjustCurrentFrame(int pins)
        {
            if (lastBallInFrame(pins))
            {
                advanceFrame();
            }
            else
            {
                firstThrowInFrame = false;
            }
        }



        private bool strike(int pins)
        {
            return (firstThrowInFrame && pins == 10);
        }

        private bool lastBallInFrame(int pins)
        {
            return strike(pins) || !firstThrowInFrame;
        }

        private void advanceFrame()
        {
            itsCurrentFrame = Math.Min(10, itsCurrentFrame + 1);
        }

        public int GetCurrentFrame()
        {
            return itsCurrentFrame;
        }

        public int ScoreForFrame(int theFrame)
        {
            return itsScorer.ScoreForFrame(theFrame);
        }
    }
}
