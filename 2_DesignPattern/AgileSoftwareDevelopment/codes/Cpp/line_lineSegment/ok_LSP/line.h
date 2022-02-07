#ifndef GEOMETRY_LINE_H
#define GEOMETRY_LINE_H
#include "point.h"
#include "linearobj.h"

class Line : public LinearObject
{
	public:
		Line(const Point& p1, const Point& p2);
		virtual bool IsOn(const Point&) const;
};

#endif
