#include <iostream>
using namespace std;
#include "Sequential.h"

bool Sequential::SequentialSearch(int array[], int SIZE, int target, int& locWanted)
{
	array[SIZE] = target;
	int index = 0;
	bool found = false;
	while (array[index] != target)
	{
		index++;
		if (index != SIZE)
		{
			found = true;
			locWanted = index;
		}
			
		
	}
	return found;
}