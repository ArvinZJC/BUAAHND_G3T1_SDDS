//2018.09.17, header file containing functions to imitate using heap to store data

#ifndef HEAP_H
#define HEAP_H
constexpr auto HEAPSIZE = 10;
#include <iostream>
using namespace std;

struct Heap
{
	int top = 0;
	int data[HEAPSIZE]; //an array to present heap

	/*Initialise the position storing data.*/
	void Initialise()
	{
		top = 0;
	} //end function Initialise

	/*Show data stored.*/
	void ShowData()
	{
		for (int counter = 0; counter < top; counter++)
			cout << "Position " << counter << ": " << data[counter] << "\n";
	} //end function ShowData

	/*Check if the number of data planned to pop is more than that of data stored in the "stack".*/
	int IsEnough(int number)
	{
		//return 0 if "number" is equal to "top" because "top++" is in function Push() which means the value of "top" here is equal to the amount of data in the "stack"
		if (number <= top)
			return 0;
		else
			return 1;
	} //end function IsEnough

	/*Check if space required is more than the maximum size or the remaining size of the "stack".*/
	int IsFull(int number)
	{
		if (number <= STACKSIZE - top)
			return 0;
		else
			return 1;
	} //end function IsFull

	/*Push (insert) new data to the "stack".*/
	void Push(int item)
	{
		data[top++] = item;
	} //end function Push

	/*Pop (delete) data from the "stack".*/
	int Pop()
	{
		return data[--top];
	} //end function Pop
}; //end struct Heap
#endif