#ifndef GEOMETRY_LINE_H
#define GEOMETRY_LINE_H
#include "point.h"

class Line
{
	public:
		Line(const Point& p1, const Point& p2);

		double GetSlope() const;
		double GetIntercept() const;
		Point GetP1() const {return itsP1};
};
