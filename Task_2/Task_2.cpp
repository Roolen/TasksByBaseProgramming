#include "pch.h"
#include <iostream>
#include <vector>

class Program
{
public:
	Program()
	{
		std::cout << "Enter numbers for one array: " << std::endl;
		Insert_Numbers_In_Array(array_one, 6);

		std::cout << "Enter numbers for two array: " << std::endl;
		Insert_Numbers_In_Array(array_two, 8);
	}

	void Output_Numbers()
	{
		std::cout << std::endl;

		int32_t last = INT32_MIN;
		while (last < array_one[0] || last < array_two[0])
		{
			int32_t min = INT32_MAX;

			for (int i = 0; i < 6; i++)
			{
				if (array_one[i] < min && array_one[i] > last)
				{
					min = array_one[i];
				}
			}

			for (int i = 0; i < 8; i++)
			{
				if (array_two[i] < min && array_two[i] > last)
				{
					min = array_two[i];
				}
			}

			last = min;
			std::cout << last << " ";
		}
	}
private:
	int32_t array_one[6]; 
	int32_t array_two[8];
	 

	static void Insert_Numbers_In_Array(int32_t array[], int32_t size_array)
	{
		for (int i = 0; i < size_array; i++)
		{
			std::cout << i+1 << ":";

			int32_t number_temp = 0;
			std::cin >> number_temp;
			if (i > 0 && number_temp >= array[i-1])
			{
				std::cout << "You enter invalid number. Enter less number." << std::endl;
				i--;
			}
			else
			{
				array[i] = number_temp;
			}
		}
	}
};

int main()
{
	Program program;
	program.Output_Numbers();
}