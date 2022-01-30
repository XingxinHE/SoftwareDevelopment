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
            TestExhaustive();
        }

        public static void TestPrimes()
        {
            int[] nullArray = PrimeGenerator.GeneratePrimes(0);
            if (!int.Equals(nullArray.Length, 0))
            {
                throw new Exception("Failed");
            }

            int[] minArray = PrimeGenerator.GeneratePrimes(2);
            if (!int.Equals(minArray.Length, 1) || !int.Equals(minArray[0], 2))
            {
                throw new Exception("Failed");
            }

            int[] threeArray = PrimeGenerator.GeneratePrimes(3);
            if (!int.Equals(threeArray.Length, 2) ||
                !int.Equals(threeArray[0], 2) ||
                !int.Equals(threeArray[1], 3))
            {
                throw new Exception("Failed");
            }

            int[] centArray = PrimeGenerator.GeneratePrimes(100);
            if (!int.Equals(centArray.Length, 25) ||
                !int.Equals(centArray[24], 97))
            {
                throw new Exception("Failed");
            }
        }

        public static void TestExhaustive()
        {
            for (int i = 2; i < 500; i++)
            {
                verifyPrimeList(PrimeGenerator.GeneratePrimes(i));
            }
        }

        private static void verifyPrimeList(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                verifyPrime(list[i]);
            }
        }

        private static void verifyPrime(int n)
        {
            for (int factor = 2; factor < n; factor++)
            {
                if (n % factor == 0)
                {
                    throw new Exception("Failed.");
                }
            }
        }
    }
}
