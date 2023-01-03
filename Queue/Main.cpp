// Utama.h
#include <iostream>
using namespace std;
#include "Queue.h"

void main()
{
	Queue <char> MyQ; // Create object MyQ
	char i;
	cout << "\nPlease insert a data, 1 to Dequeue data or 0 to stop: ";
	cin >> i;
	while (i != '0')
	{
		if (i == '1')
			MyQ.Dequeue();
		else
			MyQ.Enqueue(i);
		if (!MyQ.Empty())
		{
			cout << "\nQueue front now is: " << MyQ.QueueFront();
			cout << "\nQueue rear now is: " << MyQ.QueueRear();
		}
		cout << endl;
		cout << "\nPlease insert a data, 1 to Dequeue data or 0 to stop: ";
		cin >> i;
	} // end while
	cout << endl;
	MyQ.PrintArray();
} // end main*/