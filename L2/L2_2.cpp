// program that imitates using a circular queue to store data

#include "CircularQueue.h"
#include <iostream>
using namespace std;

int main()
{
	int selection, valuePopped;
	int number; // store how many integers are planned to push or pop
	int item; // an integer planned to push
	CircularQueue queue1; // create a CircularQueue object and assign it to "queue1"

	do
	{
		system("cls");

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
			queue1.Initialise(); // call the specified function in struct CircularQueue to initialise the positions of the head and the tail of the "queue", and the count for recording the number of integers stored
			cout << "\nSuccessfully initialised!" << endl;
			system("pause");
			break;

		case 2:
			cout << "\nEnter how many integers are planned to push: ";
			cin >> number;
			for (int count = 0; count < number; count++)
			{
				// call the specified function in struct CircularQueue to check if the "queue" is full
				if (queue1.IsFull())
				{
					cout << "Error! The \"queue\" is full. End pushing." << endl;

					break;
				}
				else
				{
					cout << "Enter an integer for Position " << queue1.tail << ": "; // call the specified function in struct CircularQueue to get the real position of the tail of the "queue"
					cin >> item;

					queue1.Push(item); // call the specified function in struct CircularQueue to push new data to the "queue"
				} // end if...else
			} // end for
			system("pause");
			break;

		case 3:
			cout << "\nEnter how many integers are planned to pop: ";
			cin >> number;
			for (int count = 0; count < number; count++)
			{
				// call the specified function in struct CircularQueue to check if the "queue" is empty
				if (queue1.IsEmpty())
				{
					cout << "Error! The \"queue\" is empty. End popping." << endl;

					break;
				}
				else
				{
					valuePopped = queue1.Pop(); // call the specified function in struct CircularQueue to pop data from the "queue"

					cout << "Successfully popped the value \"" << valuePopped << "\" at Position " << queue1.getPositionOfValuePopped() << "!" << endl; // call the specified function in struct CircularQueue to get the position of the value planned to pop
				} // end if...else
			} // end for
			system("pause");
			break;

		case 4:
			cout << endl;
			queue1.ShowQueue(); // call the specified function in Struct CircularQueue to show data in the "queue"
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