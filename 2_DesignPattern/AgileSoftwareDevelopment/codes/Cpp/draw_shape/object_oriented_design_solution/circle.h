//OOD solution to Square/Circle problem.
//----circle.h--------------------------

class Circle : public Shape
{
	public:
		void Draw() override
		{
		        cout << "Draw circle!" << endl;
		}
};

bool Circle::Precedes(const Shape& s) const
{
	if(dynamic_cast<Square*>(s))
	{
		return true;
	}
	else
	{
		return false;
	}
}
