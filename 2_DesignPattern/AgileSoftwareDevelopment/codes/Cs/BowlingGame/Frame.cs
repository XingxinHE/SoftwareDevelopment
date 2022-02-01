using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Frame
    {
        private int itsScroe = 0;
        public int GetScore()
        {
            return itsScroe;
        }

        public void Add(int pins)
        {
            itsScroe += pins;
        }
    }
}
