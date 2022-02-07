template <typename P>
class Lessp
{
	public:
		bool operator()(const P p, const P q){return (*p) < (*q)};
};
