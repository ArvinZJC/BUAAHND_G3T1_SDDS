//2018.10.08, header file containing functions to imitate using a circular queue to store data

#ifndef CIRCULARQUEUE_H
#define CIRCULARQUEUE_H
#include <iostream>
using namespace std;
constexpr auto QUEUESIZE = 10;

struct CircularQueue
{	
	int head = 0, tail = 0, counterForItems = 0; //respectively initialise the positions of the head and the tail of the "queue", and the counter for recording the number of integers stored to 0 to avoid any unknown error if the user forgets to initialise them

	/*Get the position of the value planned to pop.*/
	int getPositionOfValuePopped() { return ( head + QUEUESIZE - 1 ) % QUEUESIZE; } //end function getPositionOfValuePopped

	/*Initialise the positions of the head and the tail of the "queue", and the counter for recording the number of integers stored.*/
	void Initialise()
	{
		head = 0;
		tail = 0;
		counterForItems = 0;
	} //end function Initialise

	/*Show data in the "queue".*/
	void ShowQueue()
	{
		//call the specified method to check if the "queue" is empty
		if( IsEmpty() )
			cout << "Error! No data in the \"queue\"." << endl;
		else
		{
			cout << "(The position of the head: " << head << "\n"
				 << " The position of the tail: " << ( tail + QUEUESIZE - 1 ) % QUEUESIZE << "\n"
				 << " The number of integers stored: " << counterForItems << ")" << endl;
			
			int position;

			for( int counterForPrintingTimes = 0; counterForPrintingTimes < counterForItems; counterForPrintingTimes++ )
			{
				position = ( head + counterForPrintingTimes ) % QUEUESIZE;

				cout << "Position " << position << ": " << data[ position ] << endl;
			} //end for	
		} //end if...else
	} //end function ShowQueue

	/*Check if the "queue" is full.*/
	bool IsFull()
	{
		if( counterForItems == QUEUESIZE )
			return true;
		else
			return false;
	} //end function IsFull

	/*Check if the "queue" is empty.*/
	bool IsEmpty()
	{
		if( counterForItems == 0 )
			return true;
		else
			return false;
	} //end function IsEmpty

	/*Push (insert) new data to the "queue".*/
	void Push( int item )
	{
		data[ tail ] = item;
		counterForItems++;
		/* "tail = ( tail + 1 ) % QUEUESIZE;" acts the same as the following code:
		       tail++;
		       
		       if( tail > QUEUESIZE - 1 )
			       tail = 0; */
		tail = ( tail + 1 ) % QUEUESIZE;
	} //end function Push

	/*Pop (delete) data from the "queue".*/
	int Pop()
	{
		int valuePopped = data[ head ];

		counterForItems--;
		/* "head = ( head + 1 ) % QUEUESIZE;" acts the same as the following code:
			   head++;

			   if( head > QUEUESIZE - 1 )
				   head = 0; */
		head = ( head + 1 ) % QUEUESIZE;

		return valuePopped;
	} //end function Pop

private:
	int data[ QUEUESIZE ]; //an array representing a circular queue
}; //end struct CircularQueue
#endif