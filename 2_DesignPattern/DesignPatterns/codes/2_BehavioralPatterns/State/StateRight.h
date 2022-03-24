#include <iostream>
#include <string>
#include "StateBase.h"

using namespace std;

class StateRight : public StateBase
{
public:
    void set_context(Context *context) override
    {
        this->set_context(context);
        this->title = "Right";
        this->_x = 1;
        this->_y = 1;
    }

    void Handle1() override
    {
        cout << "Right handling 1..." << endl;
    }

    void Handle2() override
    {
        cout << "Right handling 2..." << endl;
    }

    void Report() override
    {
        cout << "Current State: " << this->title << endl;
        cout << "X: " << _x << " Y: " << _y << endl;
    }
};