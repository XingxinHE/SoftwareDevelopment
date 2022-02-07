#ifndef GEOMETRY_LINESEGMENT_H
#define GEOMETRY_LINESEGMENT_H
#include "point.h"
#include "linearobj.h"

class LineSegment : public LinearObject
{
        public:
                LineSegment(const Point& p1, const Point& p2);
                double GetLength() const;
                virtual bool IsOn(const Point&) const;
};

#endif