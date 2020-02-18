// program that imitates using a stack to store data

#include "Stack.h"
#include <iostream>
using namespace std;

int main()
{
	int selection, valuePopped;
	int number; // store how many integers are planned to push or pop
	int item; // an integer planned to push
	Stack stack1; // create a Stack object and assign it to "stack1"

	do
	{
		system("cls"); // clear the screen

		cout << "  1. Initialise the position of the top of the \"stack\"\n"
			 << "  2. Push new data to the \"stack\"\n"
			 << "  3. Pop data from the \"stack\"\n"
			 << "  4. Show data in the \"stack\"\n"
			 << "  0. Exit\n"
			 << "Choose the operation on the \"stack\": ";
		cin >> selection;

		switch (selection)
		{
		case 1:
			stack1.Initialise(); // call the specified function in struct Stack to initialise the position of the top of the "stack"
			cout << "\nSuccessfully initialised!" << endl;
			system("pause"); // display the result before clearing the screen
			break;

		case 2:
			cout << "\nEnter how many integers are planned to push: ";
			cin >> number;
			for (int count = 0; count < number; count++)
			{
				// call the specified function in struct Stack to check if the "stack" is full
				if (stack1.IsFull())
				{
					cout << "Error! The \"stack\" is full. End pushing." << endl;

					break;
				}
				else
				{
					cout << "Enter an integer for Position " << stack1.top << ": ";
					cin >> item;

					stack1.Push(item); // call the specified function in struct Stack to push new data to the "stack"
				} // end if...else
			} // end for
			system("pause");
			break;

		case 3:
			cout << "\nEnter how many integers are planned to pop: ";
			cin >> number;
			for (int count = 0; count < number; count++)
			{
				// call the specified function in struct Stack to check if the "stack" is empty
				if (stack1.IsEmpty())
				{
					cout << "Error! The \"stack\" is empty. End popping." << endl;

					break;
				}
				else
				{
					valuePopped = stack1.Pop(); // call the specified function in struct Stack to pop data from the "stack"

					cout << "Successfully popped the value \"" << valuePopped << "\" at Position " << stack1.top << "!" << endl;
				} // end if...else
			} // end for
			system("pause");
			break;

		case 4:
			cout << endl;
			stack1.ShowStack(); // call the specified function in Struct Stack to show data in the "stack"
			system("pause");
			break;

		case 0:
			break;

		default:
			cout << "\nError! No such selection." << endl;
			system("pause");
		} // end switch-case
	} while (selection);

	return 0;
} // end main