#include <iostream>
#include <string>
using namespace std;
#include "Stack.h"
int main()
{
	Stack<char> StackItem;
	int index = 0;
	char exp[50];
	cout << "\nEnter an arithmetic expression: ";
	cin.getline(exp, 50);
	while (index < strlen(exp))
	{
		switch (exp[index])
		{
		case'(':
			StackItem.Push(exp[index]);
			break;
		case ')':
			
			if (!StackItem.Underflow())

				StackItem.Pop();
			else
			{
				cout << "Error : missing left parenthesis " << endl;

			}
			
		}

		index++;
	}
	if (!StackItem.Underflow() && StackItem.TopStack() == '(') 
		cout << "Missing right parenthesis";

	return 0;
}