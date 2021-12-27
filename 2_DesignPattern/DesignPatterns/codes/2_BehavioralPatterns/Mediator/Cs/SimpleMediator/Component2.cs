using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediator
{
    //see the same description of Component 1
    class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component 2 does C.");
            this._mediator.Notify(this, "C");
            /* Because this _mediator will be set to ConcreteMediator
             * therefore, invoke this Notify here basically invoke the
             * Notify function of ConcreteMediator!!
             */
        }

        public void DoD()
        {
            Console.WriteLine("Component 2 does D");
            this._mediator.Notify(this, "D");
            /* Because this _mediator will be set to ConcreteMediator
             * therefore, invoke this Notify here basically invoke the
             * Notify function of ConcreteMediator!!
             */
        }
    }
}
