using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitAdapter
{
    class Program
    {
        static void doWork()
        {
            /*
             * Init the adaptee and target(plugged with adpater later)
             */
            BaseAdaptee adaptee = new BaseAdaptee();
            ITarget target = null;


            /*
             * Imperial -> Metric
             * Set adaptee to ImperialToMetric
             * Plug adaptee into adapter
             */
            adaptee = new AdapteeImperialToMetric();
            target = new Adapter(adaptee);

            target.PrintArea(10);
            target.PrintLength(10);
            target.PrintVolume(10);

            /*
             * Metric -> Imperial
             * Set adaptee to MetricToImperial
             * Plug adaptee into adapter
             */
            adaptee = new AdapteeMetricToImperial();
            target = new Adapter(adaptee);

            target.PrintArea(10);
            target.PrintLength(10);
            //target.PrintVolume(10);

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
