#include <cstdint>
#include <string>

struct ChimicalElement
{
public:
	std::string Name;

	int16_t GetProcent()
	{
		return procent;
	}
	void SetProcent(int16_t value)
	{
		if (value >= 0 && value <= 100)
			procent = value;
	}
private:
	int16_t procent = 0;
};

class Sample
{
public:
	int32_t number = 0;
	ChimicalElement *chimicalElements = new ChimicalElement[6];

	Sample()
	{
		for (int i = 0; i < 6; i++)
		{
			chimicalElements[i].Name = "";
		}
	}
};