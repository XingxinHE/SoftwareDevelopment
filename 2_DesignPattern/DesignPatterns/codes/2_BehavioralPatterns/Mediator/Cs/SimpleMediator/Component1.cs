using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediator
{
    /*
     * Concrete Components implement various functionality. They don't depend
     * on other components. They are also don't depend on any concrete mediator
     * class.
     */
    class Component1 : BaseComponent
    {
        //Operation A of component 1
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");
            this._mediator.Notify(this, "A");
        }

        //Operation B of component 1
        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");
            this._mediator.Notify(this, "B");
        }
    }
}
