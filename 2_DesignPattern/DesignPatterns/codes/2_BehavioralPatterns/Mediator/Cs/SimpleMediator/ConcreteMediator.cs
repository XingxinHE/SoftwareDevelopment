using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediator
{
    class ConcreteMediator : IMediator
    {
        private Component1 _component1;
        private Component2 _component2;

        /*
         * This is the constructor of the concrete mediator. Currently it was
         * init by components explicitly. In the future, it should support
         * add components.
         */
        public ConcreteMediator(Component1 com1, Component2 com2)
        {
            this._component1 = com1;
            this._component2 = com2;

            /*
             * The reason why SetMediator can set `this` as IMediator is because
             * ConcreteMediator is also IMediator!!
             */
            this._component1.SetMediator(this);
            this._component2.SetMediator(this);
        }

        /*
         * This is the business logic which specify the interaction between each part.
         */
        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator reacts on A and trigger following operations:");
                this._component2.DoC();
            }
            if (ev == "D")
            {
                Console.WriteLine("Mediator reacts on D and trigger following operations:");
                this._component1.DoB();
                this._component2.DoC();
            }
        }
    }
}
