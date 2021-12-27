using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitAdapter
{
    /*
     * Inch to Meter
     */
    class AdapteeImperialToMetric : BaseAdaptee
    {
        public override void PrintLength(double length)
        {
            //inch -> meter
            Console.WriteLine($"Metric Length: {length / 39.37}");
        }
        public override void PrintArea(double area)
        {
            //square inch -> square meter
            Console.WriteLine($"Metric Area: {area / 1550}");
        }
        public override void PrintVolume(double volume)
        {
            //cubic inch -> cubic meter
            decimal result = checked((decimal)volume / 61024);
            Console.WriteLine($"Metric Volume: {result}");
        }
    }
}
