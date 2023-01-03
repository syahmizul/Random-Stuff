//List.h
//Declaration of class List

#ifndef LIST_H
#define LIST_H

template<class DataType>
class List
{
private:
	class Node
	{
	public:
		DataType data;
		Node* link;
	};

	Node* pHead;
	Node* pCurr;
	int numItem;

public:
	List();
	~List();
	void AddToFront();
	void DeleteMiddle();
	void printData();
	int NumberOfItem();
};
#endif

//Define the implementation of all methods in class List

template<class DataType>
List<DataType>::List()
{
	numItem = 0;
	pHead = 0;
}

template<class DataType>
List<DataType>::~List() {}

template<class DataType>
void List<DataType>::AddToFront()
{
	DataType item;
	Node* pNew = new Node;
	cout << "Enter data : ";
	cin >> item;
	pNew->data = item;
	pNew->link = pHead;
	pHead = pNew;
	numItem++;
}

template<class DataType>
void List<DataType>::DeleteMiddle()
{
	char item;
	Node* pNew = new Node;
	cout << "Delete item : ";
	cin >> item;
	pHead->link = pHead->link->link;
	numItem--;
	cout << "One item is deleted" << endl;
}

template<class DataType>
void List<DataType>::printData()
{
	pCurr = pHead;
	while (pCurr != 0)
	{
		cout << pCurr->data << " ";
		pCurr = pCurr->link;
	}
	cout << "\n";

}

template<class DataType>
int List<DataType>::NumberOfItem()
{
	return numItem;
}