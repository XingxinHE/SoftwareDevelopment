using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        /*
         * Create a static void method to init singleton and assign a value
         */
        static void SingletonOperation(string text)
        {
            NoLockThreadSafeSingleton singleton = NoLockThreadSafeSingleton.Instance;
            singleton.Text = text;
            Console.WriteLine(singleton.Text);
        }

        static void doWork()
        {
            Console.WriteLine(
                "This thread-safe method is different from the lock one\n"+
                "If you see different values, the singleton maybe also used\n"+
                "since the text here not init once but can assign multiple times\n"+
                "RESULT:\n"
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
            Thread process3 = new Thread(() =>
            {
                SingletonOperation("BLENDER");
            });
            Thread process4 = new Thread(() =>
            {
                SingletonOperation("SOLIDWORKS");
            });
            Thread process5 = new Thread(() =>
            {
                SingletonOperation("SUBSTANCE3D");
            });

            process1.Start();
            process2.Start();
            process3.Start();
            process4.Start();
            process5.Start();

            process1.Join();
            process2.Join();
            process3.Join();
            process4.Join();
            process5.Join();
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

