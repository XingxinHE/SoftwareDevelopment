#include <iostream>
#include "shape.h"
#include "point.h"
#include "circle.h"
#include "square.h"
#include "drawAllShapes.cc"
using namespace std;




int main()
{
	//config square 1
	Square* square1 = new Square();
	square1->itsSide = 10;
	square1->itsType = ShapeType::square;
	//config square 2
	Square* square2 = new Square();
	square2->itsSide = 20;
	square2->itsType = ShapeType::square;
	//config circle 1
	Circle* circle1 = new Circle();
	circle1->itsRadius = 13;
	circle1->itsType = ShapeType::circle;

	//list of pointers
	void* listPtrs[3];
	listPtrs[0] = square1;
	listPtrs[1] = square2;
	listPtrs[2] = circle1;

	DrawAllShapes(listPtrs, 3);

	cout << "HELLO WORLD!" << endl;
	return 0;
}
