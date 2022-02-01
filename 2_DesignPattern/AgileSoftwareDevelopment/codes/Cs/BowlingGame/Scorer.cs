using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Scorer
    {
        private int ball;
        private int[] itsThrows = new int[21];
        private int itsCurrentThrow = 0;

        public void AddThrow(int pins)
        {
            itsThrows[itsCurrentThrow++] = pins;
        }

        public int ScoreForFrame(int theFrame)
        {
            ball = 0;
            int score = 0;
            for (int currentFrame = 0; currentFrame < theFrame; currentFrame++)
            {
                // ball++ will first take the current value and then increment
                if (strike())
                {
                    score += 10 + nextTwoBallsForStrike();
                    ball++;
                }
                else if (spare())
                {
                    score += 10 + nextBallForSpare();
                    ball += 2;
                }
                else
                {
                    score += twoBallsInFrame();
                    ball += 2;
                }

            }
            return score;
        }
        private bool strike()
        {
            return itsThrows[ball] == 10;
        }

        private bool spare()
        {
            return (itsThrows[ball] + itsThrows[ball + 1]) == 10;
        }

        private int nextBallForSpare()
        {
            return itsThrows[ball + 2];
        }

        private int nextTwoBallsForStrike()
        {
            return itsThrows[ball + 1] + itsThrows[ball + 2];
        }

        private int twoBallsInFrame()
        {
            return itsThrows[ball] + itsThrows[ball + 1];
        }

        
    }
}
