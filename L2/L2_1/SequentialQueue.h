//2018.10.08, header file containing functions to imitate using a sequential queue to store data

#ifndef SEQUENTIALQUEUE_H
#define SEQUENTIALQUEUE_H
constexpr auto QUEUESIZE = 10; //determine that the position of the tail of the "queue" ranges from 0 to 9 (not equal to "QUEUESIZE")
#include <iostream>
using namespace std;

struct SequentialQueue
{
	int tail = 0; //initialise the position of the tail of the "queue" to 0 to avoid any unknown error if the user forgets to initialise it
	int data[ QUEUESIZE ]; //an array to present a sequential queue

	/*Initialise the position of the tail of the "queue".*/
	void Initialise()
	{
		tail = 0;
	} //end function Initialise

	/*Show data in the "queue".*/
	void ShowQueue()
	{
		//call the specified method to check if the "queue" is empty
		if( IsEmpty() )
			cout << "Error! No data in the \"queue\"." << endl;
		else
		{
			cout << "(The position of the tail: " << tail - 1 << ")" << endl;

			for( int counter = 0; counter < tail; counter++ )
				cout << "Position " << counter << ": " << data[ counter ] << endl;
		} //end if...else
	} //end function ShowQueue

	/*Check if the "queue" is full.*/
	bool IsFull()
	{
		//since "tail++" is in function Push(), "tail" can be equal to "QUEUESIZE" although it is illegal
		if( tail >= QUEUESIZE )
			return true;
		else
			return false;
	} //end function IsFull

	/*Check if the "queue" is empty.*/
	bool IsEmpty()
	{
		if( tail <= 0 )
			return true;
		else
			return false;
	} //end function IsEmpty

	/*Push (insert) new data to the "queue".*/
	void Push( int item )
	{
		data[ tail++ ] = item;
	} //end function Push

	/*Pop (delete) data from the "queue".*/
	int Pop()
	{
		int valuePopped = data[ 0 ];

		/* loop to move forward all the remaining elements
		   "counter < tail - 1" since "tail++" is in function Push() */
		for( int counter = 0; counter < tail - 1; counter++ )
			data[ counter ] = data[ counter + 1 ];

		tail--;

		return valuePopped;
	} //end function Pop
}; //end struct SequentialQueue
#endif