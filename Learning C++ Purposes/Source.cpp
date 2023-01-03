#include <iostream>
#include <vector>
using namespace std;

void Print(int key)
{
	cout << key;

}

void ForEach(std::vector<int>Table,void(*func)(int))
{
	for (int i : Table)
		func(i);
}

void TestFunc(int key)
{
}

int main()
{
	using ValidateFunction = void(*)(int);
	void (*funcptr)(int);
	funcptr = &Print;
	
	ValidateFunction Test = &Print;
	Test(2);
	funcptr(2);
	
	typedef void(*funcptrdef)(int);

	funcptrdef testdef{ &TestFunc };
	testdef(2);

	std::vector<int> Table = { 1,2,3,4,5 };
	ForEach(Table, Print);

	
}