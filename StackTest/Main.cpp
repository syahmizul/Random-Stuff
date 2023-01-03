#include "StackA.h"

int main()
{
	
	Stack<char> StackItem;
	int index = 0;
	char exp[50];
	cout << "\nEnter an arithmetic expression : ";
	cin.getline(exp, 50);
	while (index < strlen(exp))
	{
		switch (exp[index])
		{
		case '(': StackItem.Push(exp[index]); break;
		case ')': if (!StackItem.Underflow()) StackItem.Pop();
			else
			{
				cout << "Error : missing parenthesis" << endl;
				return 0;
			}
		}
		index++;
	}
	if (!StackItem.Underflow())
	{
		cout << "Error : missing parenthesis" << endl;
	}
	return 0;



}