using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeGenerator
{
    public class TestGeneratePrimes
    {
        static void Main(string[] args)
        {
            TestPrimes();
        }

        public static void TestPrimes()
        {
            int[] nullArray = GeneratePrime.GeneratePrimes(0);
            if (!int.Equals(nullArray.Length, 0))
            { 
                throw new Exception("Failed"); 
            }

            int[] minArray = GeneratePrime.GeneratePrimes(2);
            if (!int.Equals(minArray.Length, 1) || !int.Equals(minArray[0], 2))
            {
                throw new Exception("Failed");
            }

            int[] threeArray = GeneratePrime.GeneratePrimes(3);
            if (!int.Equals(threeArray.Length, 2) || 
                !int.Equals(threeArray[0], 2) ||
                !int.Equals(threeArray[1], 3))
            {
                throw new Exception("Failed");
            }

            int[] centArray = GeneratePrime.GeneratePrimes(100);
            if (!int.Equals(centArray.Length, 25) || 
                !int.Equals(centArray[24], 97))
            {
                throw new Exception("Failed");
            }
        }
    }
}
