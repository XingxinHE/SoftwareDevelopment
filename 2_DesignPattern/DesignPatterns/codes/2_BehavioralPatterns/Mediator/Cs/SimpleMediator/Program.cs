using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediator
{
    class Program
    {
        static void doWork()
        {
            /*
             * Here beginning the client code:
             */

            Component1 com1 = new Component1();
            Component2 com2 = new Component2();

            new ConcreteMediator(com1, com2);

            Console.WriteLine("Client triggers operation A.");
            com1.DoA();

            Console.WriteLine("See what happende...");

            Console.WriteLine("Client triggers operation D.");
            com2.DoD();
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
