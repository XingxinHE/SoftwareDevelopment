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

        private static bool[] isCrossed;
        private static int[] result;

        private static void putUncrossedIntegerIntoResult()
        {
            int i;
            int j;

            // how many primes are there?
            int count = 0;
            for (i = 0; i < isCrossed.Length; i++)
            {
                if (isCrossed[i])
                {
                    count++;
                }
            }

            result = new int[count];

            //move the primes into the result
            for (i = 0, j = 0; i < isCrossed.Length; i++)
            {
                if (isCrossed[i])
                {
                    result[j] = i;
                    j++;  // if it is prime, increment
                }
            }
        }

        private static int calcMaxPrimeFactor()
        {
            // We cross out all multiples of p; where p is prime.
            // Thus, all crossed out multiples have p and q for
            // factors. If p > sqrt of the size of the array, then
            // q will never be greater than 1. Thus p is the
            // largest prime factor in the array, and is also
            // the iteration limit.

            double maxPrimeFactor = Math.Sqrt(isCrossed.Length) + 1;
            return (int)maxPrimeFactor;
        }

        private static void crossOutMultiples()
        {
            int maxPrimeFactor = calcMaxPrimeFactor();
            for (int i = 2; i<=maxPrimeFactor; i++)
            {
                if (notCrossed(i))
                {
                    crossOutMultiplesOf(i);
                }
            }
        }

        private static void crossOutMultiplesOf(int i)
        {
            for (int multiple = 2*i; multiple < isCrossed.Length; multiple+=i)
            {
                isCrossed[multiple] = true;
            }
        }

        private static bool notCrossed(int i)
        {
            return isCrossed[i] == false;
        }

        private static void initializeArrayOfIntegers(int maxValue)
        {
            // since start counting from 0 to last index, therefore +1
            // e.g. max=25, we have to loop from 0 to 25
            isCrossed = new bool[maxValue + 1];

            for (int i = 2 ; i < isCrossed.Length; i++)
            {
                isCrossed [i] = false;
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
