#ifndef SIMPLE_COMMAND_H
#define SIMPLE_COMMAND_H

#include <string>
#include <iostream>
#include "Command.h"

using namespace std;

class SimpleCommand : public Command
{
private:
        string pay_load;
public:
        explicit SimpleCommand(string pay_load)
                : pay_load(pay_load) {};

        void Execute() const override;
        ~SimpleCommand();
};



SimpleCommand::~SimpleCommand()
{
}

void SimpleCommand::Execute() const
{
        cout << "Simple Command: printing the pay_load ->" << this->pay_load << endl;
}

#endif