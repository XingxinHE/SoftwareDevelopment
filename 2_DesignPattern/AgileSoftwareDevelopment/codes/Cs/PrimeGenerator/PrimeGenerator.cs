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

        private static bool[] crossedOut;
        private static int[] result;

        public static int[] GeneratePrimes(int maxValue)
        {
            if (maxValue < 2)
            {
                return new int[0];
            }
            else
            {
                uncrossIntegetsUpTo(maxValue);
                crossOutMultiples();
                putUncrossedIntegersIntoResult();
                return result;  //return the prime
            }
        }

        private static void uncrossIntegetsUpTo(int maxValue)
        {
            // since start counting from 0 to last index, therefore +1
            // e.g. max=25, we have to loop from 0 to 25
            crossedOut = new bool[maxValue + 1];

            for (int i = 2; i < crossedOut.Length; i++)
            {
                crossedOut[i] = false;
            }
        }

        private static void crossOutMultiples()
        {
            int maxPrimeFactor = determineIterationLimit();
            for (int i = 2; i <= maxPrimeFactor; i++)
            {
                if (notCrossed(i))
                {
                    crossOutMultiplesOf(i);
                }
            }
        }

        private static int determineIterationLimit()
        {
            // Every multiple in the array has a prime factor that
            // is less than or equal to the root of the arrya size,
            // so we don't have to cross of multiples of numbers
            // larger than that root.

            double iterationLimit = Math.Sqrt(crossedOut.Length) + 1;
            return (int)iterationLimit;
        }

        private static void crossOutMultiplesOf(int i)
        {
            for (int multiple = 2*i; multiple < crossedOut.Length; multiple+=i)
            {
                crossedOut[multiple] = true;
            }
        }

        private static bool notCrossed(int i)
        {
            return crossedOut[i] == false;
        }
        private static void putUncrossedIntegersIntoResult()
        {
            result = new int[numberOfUncrossedIntegers()];
            for (int i = 2, j = 0; i < crossedOut.Length; i++)
            {
                if (notCrossed(i))
                {
                    result[j] = i;
                    j++;
                }
            }
        }

        private static int numberOfUncrossedIntegers()
        {
            int count = 0;
            for (int i = 2; i< crossedOut.Length; i++)
            {
                if (notCrossed(i))
                {
                    count++;
                }
            }
            return count;
        }

        

        
    }
}
