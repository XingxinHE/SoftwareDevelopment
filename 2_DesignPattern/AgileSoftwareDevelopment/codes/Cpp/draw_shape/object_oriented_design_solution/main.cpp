#include <iostream>
#include <vector> 
using namespace std;
#include "shape.h"
#include "circle.h"
#include "square.h"

void DrawAllShapes(vector<Shape*>& list);

int main()
{
        //Starting the program
        cout << "OOD solution to Square/Circle problem." << endl;

        //declare bunch of circle and square
        Circle* c1 = new Circle();
        Circle* c2 = new Circle();
        Circle* c3 = new Circle();
        Square* s1 = new Square();
        Square* s2 = new Square();

        //put into vector
        vector<Shape*> shapeList;
        shapeList.insert(shapeList.end(), {s1, c2, c3, s2, c1});

        //use it
        DrawAllShapes(shapeList);

        return 0;
}

void DrawAllShapes(vector<Shape*>& list)
{
        vector<Shape*>::iterator i;
        for (i = list.begin(); i !=list.end(); i++)
        {
                (*i) ->Draw();
        }
}