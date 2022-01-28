using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeGenerator
{
    public class PrimeGenerator
    {
        /*
         * The following algorithm can refer to
         * https://zh.wikipedia.org/wiki/%E5%9F%83%E6%8B%89%E6%89%98%E6%96%AF%E7%89%B9%E5%B0%BC%E7%AD%9B%E6%B3%95
         */

        private static bool[] f;
        private static int[] result;

        private static void putUncrossedIntegerIntoResult()
        {
            int i;
            int j;

            // how many primes are there?
            int count = 0;
            for (i = 0; i < f.Length; i++)
            {
                if (f[i])
                {
                    count++;
                }
            }

            result = new int[count];

            //move the primes into the result
            for (i = 0, j = 0; i < f.Length; i++)
            {
                if (f[i])
                {
                    result[j] = i;
                    j++;  // if it is prime, increment
                }
            }
        }

        private static void crossOutMultiples()
        {
            int i;
            int j;
            // here is important, see the wiki
            for (i = 2; i < Math.Sqrt(f.Length) + 1; i++)
            {
                if (f[i])
                {
                    for (j = 2 * i; j < f.Length; j += i)
                    {
                        f[j] = false;
                    }
                }
            }
        }

        private static void initializeArrayOfIntegers(int maxValue)
        {
            // since start counting from 0 to last index, therefore +1
            // e.g. max=25, we have to loop from 0 to 25
            f = new bool[maxValue + 1];

            // 0 & 1 are known non-primes
            f[0] = f[1] = false;

            int i;
            // initialize array to be true
            for (i = 2; i < f.Length; i++)
            {
                f[i] = true;
            }
        }

        public static int[] GeneratePrimes(int maxValue)
        {
            if (maxValue < 2)
            {
                return new int[0];
            }
            else
            {
                initializeArrayOfIntegers(maxValue);
                crossOutMultiples();
                putUncrossedIntegerIntoResult();
                return result;  //return the prime
            }
        }
    }
}
