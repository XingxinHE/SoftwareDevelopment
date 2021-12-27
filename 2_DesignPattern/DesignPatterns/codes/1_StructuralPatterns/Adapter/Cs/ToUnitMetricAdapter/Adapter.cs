using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitAdapter
{
    class Adapter : ITarget
    {
        private readonly BaseAdaptee _adaptee;

        public Adapter(BaseAdaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public void PrintArea(double area)
        {
            this._adaptee.PrintArea(area);
        }

        public void PrintLength(double length)
        {
            this._adaptee.PrintLength(length);
        }

        public void PrintVolume(double volume)
        {
            this.PrintVolume(volume);
        }

    }
}
