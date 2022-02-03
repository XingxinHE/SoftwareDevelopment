//
//Procedural Solution to the Square/Circle Problem
//--square.h---------------------------------------
//

#include <iostream>
using namespace std;

struct Square
{
	ShapeType itsType;
	double itsSide;
	Point itsTopLeft;
};

void DrawSquare(struct Square*);

void DrawSquare(Square* s)
{
	cout << "Drawing a square with side length: " << s->itsSide << endl;
}