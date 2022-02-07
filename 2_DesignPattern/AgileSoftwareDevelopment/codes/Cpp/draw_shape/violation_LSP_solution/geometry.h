//A violation of LSP causing a violation of OCP.
//----geometry.h--------------------------------

struct Point {double x,y;};
struct Shape 
{
	enum ShapeType {square, circle} itsType;

	Shape(ShapeType t) : itsType(t) {}
};

struct Circle : public Shape
{
	Circle() : Shape(circle) {};
	void Draw()
	{
		cout << "Drawing circle" << endl;
	}
	Point itsCenter;
	double itsRadius;
};

struct Square : public Shape
{
	Square() : Shape(square) {};
	void Draw()
	{
		cout << "Drawing square..." << endl;
	}
	Point itsTopLeft;
	double itsSide;
};
