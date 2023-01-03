#include <iostream>
using namespace std;
#include "List.h"

int main()
{
	int item;
	int position;
	int option;
	List ItemList;
	while(true)
	{
		system("cls");
		cout << "Now there are : " << ItemList.numberOfItem() << " item in the list\n\n";
		cout << "The list are : \n";
		ItemList.printItem();
		cout << "\nWhat operation would you like to do?\n\n1.Add item to array with specific position\n2.Delete item from array with specific position\n3.Calculate the total of the array.\n4.Finding item in the array.\n";
		cout << "\nEnter an option ( 1 , 2 , 3 , 4 ) : "; cin >> option;
	
		switch (option) {
		case 1:
			cout << "Enter a digit : "; cin >> item;
			cout << "Enter a position : "; cin >> position;
			ItemList.addItem(item, position);
			system("cls");
			cout << "Now there are : " << ItemList.numberOfItem() << " item in the list \n\n";
			system("pause");
			break;
		case 2:
			cout << "Enter a position : "; cin >> position;
			ItemList.deleteItem( position);
			system("cls");
			cout << "Now there are : " << ItemList.numberOfItem() << " item in the list \n\n";
			system("pause");
			break;
		case 3:
			system("cls");
			cout << "The total of the array is : " << ItemList.total() << endl;
			system("pause");
			break;
		case 4:
			cout << "Input the item : "; cin >> item;
			if (ItemList.findItem(item) != -1)
				cout << "The index for the item is : " << ItemList.findItem(item) << endl;
			else
				cout << "Item not found! \n";
			system("pause");
			break;
		default:
			return 0;
	}
		
	
	}
}