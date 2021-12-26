using System;

namespace Singleton
{
    class Program
    {
        static void doWork()
        {
            //Init the singleton
            NaiveSingleton ns1 = NaiveSingleton.GetInstance();
            NaiveSingleton ns2 = NaiveSingleton.GetInstance();

            //see if they are the same
            if (ns1.Equals(ns2))
            {
                Console.WriteLine("Singleton works! They are the same!");
            }
            else
            {
                Console.WriteLine("Singleton failed! They are not the same!");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
