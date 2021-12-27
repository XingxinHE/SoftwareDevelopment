using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitAdapter
{
    interface ITarget
    {
        void PrintLength(double length);
        void PrintArea(double area);
        void PrintVolume(double volume);
    }
}
