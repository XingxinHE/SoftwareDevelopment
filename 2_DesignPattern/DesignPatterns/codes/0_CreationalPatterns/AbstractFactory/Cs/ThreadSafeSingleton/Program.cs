using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        /*
         * Create a static void method to init singleton with a value.
         * Because this operation didn't use the SET the TEXT property,
         * the TEXT property is merely just the init value. Therefore,
         * it is possible to see if this is thread-safe and using one 
         * instance by checking out the output of console.
         */
        static void SingletonOperation(string text)
        {
            ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance(text);
            Console.WriteLine(singleton.Text);
        }

        static void doWork()
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            /*
             * Create 2 threads to start the operation.
             */
            Thread process1 = new Thread(() =>
            {
                SingletonOperation("RHINO");
            });
            Thread process2 = new Thread(() =>
            {
                SingletonOperation("AUTOCAD");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
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
