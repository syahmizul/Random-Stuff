//ListMain.cpp

#include<iostream>
#include<string>
using namespace std;
#include "List.h"

void main()
{
	List<char> x;

	for (int i = 1; i < 4; i++)
	{
		x.AddToFront();
	}
	cout << "\nNumber of Item Now : " << x.NumberOfItem();
	cout << "\nThe list are : " << endl;
	x.printData();

	x.DeleteMiddle();
	cout << "\nNumber of Item Now : " << x.NumberOfItem();
	cout << "\nThe list are :" << endl;
	x.printData();

}