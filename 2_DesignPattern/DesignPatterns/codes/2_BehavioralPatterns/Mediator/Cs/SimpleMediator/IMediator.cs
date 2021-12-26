﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediator
{
    /*
     * The Mediator interface declares a method used by components
     * to notify the mediator about various events. The Mediator may
     * react to these events and pass the execution to other components.
     */
    interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
