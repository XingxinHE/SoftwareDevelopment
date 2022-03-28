#ifndef COMMAND_H
#define COMMAND_H

class Command
{
private:
        /* data */
public:
        Command();
        virtual ~Command(){};
        virtual void Execute() const = 0;
};

Command::Comman()
{
}

Command::~Command()
{
}

#endif