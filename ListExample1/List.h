#ifndef LIST_H
#define LIST_H

const int maxSize = 100;

class List 
{
public:
	List();
	~List();
	int numberOfItem();
	void addItem(int item);
	void addItem(int item, int position);
	void deleteItem(int position);
	void printItem();
	int total();
	int findItem(int item);

private:
	int size;
	int array[maxSize] = {};

};

#endif