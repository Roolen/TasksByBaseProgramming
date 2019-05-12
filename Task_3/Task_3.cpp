#include "Task_3.h"
#include <iostream>
#include <vector>
#include <random>

class Program
{
private:
	static std::vector<Sample> samples();

	std::random_device rd;
	std::mt19937 *random;

	Program()
	{
		random = new std::mt19937(rd);
	}
};

int main()
{
    std::cout << "Hello World!\n";
	return 0;
}