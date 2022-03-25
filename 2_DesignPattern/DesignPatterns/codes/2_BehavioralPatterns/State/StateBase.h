#ifndef STATE_BASE_H
#define STATE_BASE_H

#include <string>

using namespace std;

class Context;

class StateBase
{
protected:
    Context *_context;
    int _x, _y;
    string title;

public:
    virtual ~StateBase() {}

    virtual void set_context(Context *context)
    {
        this->_context = context;
    }

    virtual void Handle1() = 0;
    virtual void Handle2() = 0;
    virtual void Report() = 0;
};

#endif