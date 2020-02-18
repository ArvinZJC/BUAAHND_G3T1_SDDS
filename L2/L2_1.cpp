// program that imitates using a sequential queue to store data

#include "SequentialQueue.h"
#include <iostream>
using namespace std;

int main()
{
	int selection, valuePopped;
	int number; // store how many integers are planned to push or pop
	int item; // an integer planned to push
	SequentialQueue queue1; // create a SequentialQueue object and assign it to "queue1"

	do
	{
		system("cls"); // clear the screen

		cout << "  1. Initialise the position of the tail of the \"queue\"\n"
			 << "  2. Push new data to the \"queue\"\n"
			 << "  3. Pop data from the \"queue\"\n"
			 << "  4. Show data in the \"queue\"\n"
			 << "  0. Exit\n"
			 << "Choose the operation on the \"queue\": ";
		cin >> selection;

		switch (selection)
		{
		case 1:
			queue1.Initialise(); // call the specified function in struct SequentialQueue to initialise the position of the tail of the "queue"
			cout << "\nSuccessfully initialised!" << endl;
			system("pause"); // display the result before clearing the screen
			break;

		case 2:
			cout << "\nEnter how many integers are planned to push: ";
			cin >> number;
			for (int count = 0; count < number; count++)
			{
				// call the specified function in struct SequentialQueue to check if the "queue" is full
				if (queue1.IsFull())
				{
					cout << "Error! The \"queue\" is full. End pushing." << endl;

					break;
				}
				else
				{
					cout << "Enter an integer for Position " << queue1.tail << ": ";
					cin >> item;

					queue1.Push(item); // call the specified function in struct SequentialQueue to push new data to the "queue"
				} // end if...else
			} // end for
			system("pause");
			break;

		case 3:
			cout << "\nEnter how many integers are planned to pop: ";
			cin >> number;
			for (int count = 0; count < number; count++)
			{
				// call the specified function in struct SequentialQueue to check if the "queue" is empty
				if (queue1.IsEmpty())
				{
					cout << "Error! The \"queue\" is empty. End popping." << endl;

					break;
				}
				else
				{
					valuePopped = queue1.Pop(); // call the specified function in struct SequentialQueue to pop data from the "queue"

					cout << "Successfully popped the value \"" << valuePopped << "\" at Position " << count << "!" << endl;
				} // end if...else
			} // end for
			system("pause");
			break;

		case 4:
			cout << endl;
			queue1.ShowQueue(); // call the specified function in Struct SequentialQueue to show data in the "queue"
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