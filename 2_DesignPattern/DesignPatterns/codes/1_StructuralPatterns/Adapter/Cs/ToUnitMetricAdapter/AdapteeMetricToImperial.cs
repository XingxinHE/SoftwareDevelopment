using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitAdapter
{
    /*
     * Meter to Inch
     */
    class AdapteeMetricToImperial : BaseAdaptee
    {
        public override void PrintLength(double length)
        {
            // meter -> inch
            Console.WriteLine($"Imperial Length: {length * 39.37}");
        }
        public override void PrintArea(double area)
        {
            // square meter -> square inch
            Console.WriteLine($"Imperial Area: {area * 1550}");
        }
        public override void PrintVolume(double volume)
        {
            //cubic meter -> cubic inch
            Console.WriteLine($"Imperial Volume: {volume * 61024}");
        }
    }
}
