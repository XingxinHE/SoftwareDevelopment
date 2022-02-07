#include <iostream>
using namespace std;
#include "geometry.h"

void DrawShape(const Shape& s);

int main()
{
	Shape c = new Circle();
	Shape s = new Square();
	DrawShape(&c);
	DrawShape(&s);
	cout << "Hello world!" << endl;
	return 0;
}

void DrawShape(const Shape& s)
{
	if (s.itsType == Shape::square)
		static_cast<const Square&>(s).Draw();
	else if (s.itsType == Shape::circle)
		static_cast<const Circle&>(s).Draw();
}
