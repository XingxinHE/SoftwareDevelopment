#include <iostream>
#include <typeinfo>
#include "StateBase.h"

using namespace std;

class Context
{
private:
    StateBase *_state;
public:
    Context(StateBase *state)
        : _state(nullptr)
        {

        };
    ~Context()
    {
        delete _state;
    }

    void TransitionTo(StateBase *state)
    {
        cout << "Context: Transition to " << typeid(*state).name() << endl;
        if (this->_state != nullptr)
        {
            delete this->_state;
            this->_state = state;
            this->_state->set_context(this);
        }
    }

    void ReportMyState()
    {
        this->_state->Report();
        return;
    }

    void Request1()
    {
        this->_state->Handle1();
        return;
    }

    void Request2()
    {
        this->_state->Handle2();
        return;
    }
};