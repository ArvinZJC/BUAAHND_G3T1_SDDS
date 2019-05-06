// header file that contains functions to imitate using a stack to store data

#ifndef STACK_H
#define STACK_H
#include <iostream>
using namespace std;
constexpr auto STACKSIZE = 10; // determine that the position of the top of the "stack" ranges from 0 to 9 (not equal to "STACKSIZE")

struct Stack
{
	int top = 0; // initialise the position of the top of the "stack" to 0 to avoid any unknown error if the user forgets to initialise it

	/* Initialise the position of the top of the "stack". */
	void Initialise()
	{
		top = 0;
	} // end function Initialise

	/* Show data in the "stack". */
	void ShowStack()
	{
		// call the specified method to check if the "stack" is empty
		if (IsEmpty())
			cout << "Error! No data in the \"stack\"." << endl;
		else
		{
			cout << "(The position of the top: " << top - 1 << ")" << endl;

			for (int count = 0; count < top; count++)
				cout << "Position " << count << ": " << data[count] << endl;
		} // end if...else
	} // end function ShowStack

	/* Check if the "stack" is full. */
	bool IsFull()
	{
		// since "top++" is in function Push, "top" can be equal to "STACKSIZE" although it is illegal
		if (top >= STACKSIZE)
			return true;
		else
			return false;
	} // end function IsFull

	/* Check if the "stack" is empty. */
	bool IsEmpty()
	{
		if (top <= 0)
			return true;
		else
			return false;
	} // end function IsEmpty

	/* Push (insert) new data to the "stack". */
	void Push(int item)
	{
		data[top++] = item;
	} // end function Push

	/* Pop (delete) data from the "stack". */
	int Pop()
	{
		return data[--top];
	} // end function Pop

private:
	int data[STACKSIZE]; // an array representing a stack
}; // end struct Stack
#endif