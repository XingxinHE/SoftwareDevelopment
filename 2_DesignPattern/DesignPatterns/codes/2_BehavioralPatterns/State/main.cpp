#include <iostream>
#include <string>
#include "Context.h"
#include "StateLeft.h"
#include "StateRight.h"

int main()
{
    Context* context = new Context(new StateLeft());

    context->ReportMyState();
    context->Request1();
    context->Request2();

    context->TransitionTo(new StateRight());
    context->ReportMyState();
    context->Request1();
    context->Request2();

    return 0;
}