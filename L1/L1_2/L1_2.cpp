//2018.09.17, program that imitates using heap to store data

#include "Heap.h"
#include <iostream>
using namespace std;

int main()
{
	int selection, valuePopped;
	int number; //store how many integers are planned to push or pop
	int item; //an integer planned to push
	Stack user1; //create a Stack object and assign it to "user1"

	do
	{
		system("cls");

		cout << "  1. Initialise the position storing data\n"
			<< "  2. Push new data to the \"stack\"\n"
			<< "  3. Pop data from the \"stack\"\n"
			<< "  4. Show data stored\n"
			<< "  0. Exit\n"
			<< "Choose the operation on the \"stack\": ";
		cin >> selection;

		switch (selection)
		{
		case 1:
			user1.Initialise(); //call the specified function in struct Stack to initialise the position storing data
			cout << "\nSuccessfully initialised!" << endl;
			system("pause");
			break;

		case 2:
			cout << "\nEnter how many integers are planned to push: ";
			cin >> number;
			//call the specified function in struct Stack to check if space required is more than the maximum size or the remaining size of the "stack".
			if (user1.IsFull(number))
				cout << "Error! Space required is more than the maximum size or the remaining size of the \"stack\"." << endl;
			else
			{
				for (int counter = 0; counter < number; counter++)
				{
					cout << "Enter an integer for Position " << user1.top << ": ";
					cin >> item;

					user1.Push(item); //call the specified function in struct Stack to push new data to the "stack"
				} //end for
			} //end if...else
			system("pause");
			break;

		case 3:
			cout << "\nEnter how many integers are planned to pop: ";
			cin >> number;
			//call the specified function in struct Stack to check if the number of data planned to pop is more than that of data stored in the "stack"
			if (user1.IsEnough(number))
				cout << "Error! The number of data planned to pop is more than that of data stored in the \"stack\"." << endl;
			else
			{
				for (int counter = 0; counter < number; counter++)
				{
					valuePopped = user1.Pop();

					cout << "The value \"" << valuePopped << "\" at Position " << user1.top << " has been successfully popped." << endl; //call the specified function in struct Stack to pop data from the "stack"
				} //end for
			} //end if...else
			system("pause");
			break;

		case 4:
			cout << endl;
			user1.ShowData(); //call the specified function in Struct Stack to show data stored
			system("pause");
			break;

		case 0:
			break;

		default:
			cout << "\nError! No such selection." << endl;
		} //end switch-case
	} while (selection);

	return 0;
} //end main