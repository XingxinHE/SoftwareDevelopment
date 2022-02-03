#include <iostream>
using namespace std;

struct Circle
{
	ShapeType itsType;
	double itsRadius;
	Point itsCenter;
};

void DrawCircle(Circle*);

void DrawCircle(Circle* c)
{
	cout << "Drawing a circle with radius: " << c->itsRadius << endl;
}
