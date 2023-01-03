#include <iostream>
using namespace std;
#include "Sequential.h"

int main()
{
	int target, i;
	bool found;
	Sequential SS;

	cout << "The Data\n";
	for (i = 0; i < SIZE; i++)
		SS.array[i] = rand() % 500 + 1;

	for (i = 0; i < SIZE; i++)
		cout << SS.array[i] << " ";
	cout << endl;
	cout << "Insert a target,or 0 to stop: ";
	cin >> target;
	do {
		found = SS.SequentialSearch(SS.array, SIZE, target, SS.locationWanted);
		if (found)
			cout << "\tFound " << target << " at index " << SS.locationWanted << endl;
		else
			cout << "\tTarget not found" << endl;
		cout << "\nInsert a target,or 0 to stop: ";
		cin >> target;

	} while (target != 0);
}