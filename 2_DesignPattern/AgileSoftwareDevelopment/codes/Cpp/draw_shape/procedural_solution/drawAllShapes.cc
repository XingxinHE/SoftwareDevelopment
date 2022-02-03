//
//Procedural Solution to the Square/Circle Problem
//--drawAllShapes.cc-------------------------------
//
//

typedef struct Shape* ShapePointer;

void DrawAllShapes(ShapePointer list[], int n)
{
	int i;
	for(i=0; i<n; i++)
	{
		struct Shape* s = list[i];
		switch(s -> itsType)
		{
			case square:
				DrawSquare((struct Square*)s);
				break;
			case circle:
				DrawCircle((struct Circle*)s);
				break;
		}
	}
}
