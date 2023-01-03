#include <iostream>
using namespace std;
#include "List.h"

List::List() 
{
	size = 0;
}

List::~List()
{

}

int List::numberOfItem() {
	return size;
}

void List::addItem(int item)
{
	if (size == maxSize)
	{
		cout << "***There is no more place left*****\n";
		return;
	}
	array[size] = item;
	size++;
}

void List::addItem(int item,int position)
{
	if (size == maxSize)
	{
		cout << "***There is no more place left*****\n";
		return;
	}
	array[position] = item;
	size++;
}

void List::deleteItem(int position)
{
	size--;
	array[position] = 0;
}

int List::total()
{
	int total = 0;
	for (int i = 0; i < maxSize; i++)
		total += array[i];
		
	return total;

}

int List::findItem(int item) 
{
	for (int i = 0; i < maxSize; i++)
	{
		if (array[i] == item)
			return i;
	}
	return -1;
}

void List::printItem()
{
	for (int i = 0; i < maxSize; i++)
	{
		cout << array[i] << "	";
	}
		
	cout << "\n";
}