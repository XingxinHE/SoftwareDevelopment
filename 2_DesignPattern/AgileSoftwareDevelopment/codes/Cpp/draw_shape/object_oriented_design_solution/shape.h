//OOD solution to Square/Circle problem.
//----shape.h---------------------------
#include <typeinfo>
#include <string>
#include <iostream>

using namespace std;

class Shape
{
	public:
		virtual void Draw() = 0;
		virtual bool Precedes(const Shape&) = 0;

		bool operator <(const Shape& s){return Precedes(s);}
	private:
		static const char* typeOrderTable[];
};

const char* Shape::typeOrderTable[]=
{
	typeid(Circle).name(),
	typeid(Square).name(),
	0
};

// This function searches a table for the class names.
// The table defines the order in which the
// shapes are to be drawn. Shapes that are not
// found always precede shapes that are found.
//
bool Shape::Precedes(const Shape& s) const
{
	const char* thisType = typeid(*this).name();
	const char* argType = typeid(s).name();
	bool done = false;
	int thisOrd = -1;
	int argOrd = -1;
	for(int i = 0; !done; i++)
	{
		const char* tableEntry typeOrderTable[i];
		if(tableEntry!=0)
		{
			if (strcmp(tableEntry, thisType) == 0)
				thisOrd = i;
			if (strcmp(tableEntry, argType) == 0)
				argOrd = i;
			if ((argOrd >= 0) && (thisOrd >= 0))
				done = true;
		}
		else  //table entry == 0
			done = true;
	}
	return thisOrd<argOrd;
}
