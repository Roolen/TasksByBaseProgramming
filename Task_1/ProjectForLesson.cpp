#include "pch.h"
#include <iostream>
#include <ctime>

using namespace std;

class Program
{
private:
	bool array[30];
	int dayFirstViolation = 0;

	void Def_Violation()
	{
		for (int i = 0; i < 30; i++)
		{
			if (array[i] == 1)
			{
				dayFirstViolation = i+1;
				break;
			}
		}
	}

public:
	Program()
	{
		srand(time(0));

		for (int i = 0; i < 30; i++)
		{
			array[i] = rand() % 2;
			cout << array[i] << " ";
		}

		Def_Violation();
	}

	void Output_Day_First_Violation()
	{
		cout << endl;

		if (dayFirstViolation > 0)
		{
			cout << dayFirstViolation << " Day" << endl;
		}
		else
		{
			cout << "No violations" << endl;
		}
	}
};

int main()
{
	Program program;

	program.Output_Day_First_Violation();
}