/******************************************************************************

							  Online C++ Compiler.
			   Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <iostream>
#include <array>
#include <string>
#include <vector>
#include <cstdlib>
using namespace std;


int main()
{
	int test[5] = { 6,3,4,5,3 };
	string teststr[5] = { "Text1","Text2","Text3","Text4","Text5" };
	InsertionSort(test,teststr);
	for (size_t i = 0; i < 5; i++)
	{
		cout << test[i] << teststr[i] << endl;
	

	}

	return 0;
}
