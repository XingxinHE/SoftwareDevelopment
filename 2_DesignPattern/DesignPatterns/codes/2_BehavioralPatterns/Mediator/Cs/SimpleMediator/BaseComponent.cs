using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediator
{
    /*
     * The Base Component provides the basic functionality of storing
     * a mediator's instance inside component instance.
     */
    class BaseComponent
    {
        //mediator stored as a field
        protected IMediator _mediator;

        //init the component with a mediator
        public BaseComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        //set the mediator
        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }

    }
}
