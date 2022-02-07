#ifndef GEOMETRY_LINESEGMENT_H
#define GEOMETRY_LINESEGMENT_H
class LineSegment : public Line
{
        public:
        LineSegment(const Point& p1, const Point& p2);
        double GetLength() const;
        virtual bool IsOn(const Point&) const;
};
#endif