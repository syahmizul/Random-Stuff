#include <iostream>
#include <thread>
using namespace std;

void TestFunc1()
{


}

int main()
{
	typedef void (*TestFunc)();
	TestFunc{ &TestFunc1 };

	TestFunc();

}