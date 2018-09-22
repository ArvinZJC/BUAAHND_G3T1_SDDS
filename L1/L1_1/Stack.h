//2018.09.17, header file containing functions to imitate using stack to store data

#ifndef STACK_H
#define STACK_H
constexpr auto STACKSIZE = 10;
#include <iostream>
using namespace std;

struct Stack
{
	int top = 0;
	int data[ STACKSIZE ]; //an array to present stack

	/*Initialise the position storing data.*/
	void Initialise()
	{
		top = 0;
	} //end function Initialise

	/*Show data stored.*/
	void ShowData()
	{
		for( int counter = 0; counter < top; counter++ )
			cout << "Position " << counter << ": " << data[ counter ] << "\n";
	} //end function ShowData

	/*Check if the number of data planned to pop is more than that of data stored in the "stack".*/
	int IsEnough( int number )
	{
		//return 0 if "number" is equal to "top" because "top++" is in function Push() which means the value of "top" here is equal to the amount of data in the "stack"
		if( number <= top )
			return 0;
		else
			return 1;
	} //end function IsEnough

	/*Check if space required is more than the maximum size or the remaining size of the "stack".*/
	int IsFull( int number )
	{
		if( number <= STACKSIZE - top )
			return 0;
		else
			return 1;
	} //end function IsFull

	/*Push (insert) new data to the "stack".*/
	void Push( int item )
	{
		data[ top++ ] = item;
	} //end function Push

	/*Pop (delete) data from the "stack".*/
	int Pop()
	{
		return data[ --top ];
	} //end function Pop
}; //end struct Stack
#endif