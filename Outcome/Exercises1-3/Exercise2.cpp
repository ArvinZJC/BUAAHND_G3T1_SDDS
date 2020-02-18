/*
 * @Description: program that implements a specified ADT using an array data structure and simply tests it
 * @Version: 2.0
 * @Author: Arvin Zhao
 * @Date: 2018-12-04 09:12:47
 * @Last Editors: Arvin Zhao
 * @LastEditTime: 2020-02-18 19:00:46
 */

#include "Exercise1.h"
#include <iostream>
using namespace std;

/* Struct that is used as an array list of type integer. */
struct IntArrayList
{
    int* data; // a pointer for a data storage area
    int head; // the position of the head ranges from 0 to "maximumSize - 1" (not equal to "maximumSize")
}; // end struct IntArrayList

/* Implementing struct StackADT, this class contains an integer stack and relevant functions. */
class MyStack : public StackADT
{
    IntArrayList list; // instant an IntArrayList object as an integer stack

public:
    MyStack()
    {
        list.data = new int[20](); // create an integer array with the maximum size of 20 and the initial element value of 0
        list.head = 0; // initialise the position of the head to 0
    } // end constructor MyStack

    ~MyStack()
    {
        delete[] list.data; // delete the array to try to avoid resource leak or any other problem
    } // end destructor MyStack
    
    /**
     * Add an integer to the array appropriately for the stack.
     * Before calling this function, check if the stack is full first!
     * @param value the integer added to the array
     */
    void push(int value)
    {
        list.data[list.head++] = value;
    } // end function push

    /**
     * Remove and return an integer from the array.
     * Before calling this function, check if the stack is empty first!
     * @return the integer removed from the array
     */
    int pop()
    {
        return list.data[--list.head];
    } // end function pop

    /**
     * Check if the stack is empty.
     * @return the bool value true if the stack is empty, or false if the stack is not empty
     */
    bool isEmpty()
    {
        if (list.head <= 0)
			return true;
		else
			return false;
    } // end function isEmpty

    /**
     * Check if the stack is full.
     * @return the bool value true if the stack is full, or false if the stack is not full
     */
    bool isFull()
    {
		// since "head++" is in function push in class MyStack, "head" can be equal to the maximum size although it is illegal
        if (list.head >= 20)
			return true;
		else
			return false;
    } // end function isFull

    /**
     * Get the stack size.
     * @return the number of items in the stack
     */
    int size()
    {
        return list.head; // since "head++" is in function push in class MyStack, "head" is equal to the stack size
    } // end function size

    /**
     * Display the information of the stack.
     */
    void display()
    {
        int stackSize = size(); // call the specified function to get the stack size

        cout << "The list has " << stackSize << " item(s)." << endl;
        
        for (int count = stackSize - 1; count >= 0; count--)
			cout << "Value: " << list.data[count] << endl;
    } // end function display
}; // end class MyStack

int main()
{
    MyStack astack; // instant a MyStack object for testing an integer stack
    int valuePopped; // record the value popped from the stack
    
    cout << "***** Testing an integer stack *****\n"
         << "The stack is empty? " << boolalpha << astack.isEmpty() << endl; // call the specified function in class MyStack to check if the stack is empty
    
    for (int value = 1; value < 6; value++)
        astack.push(value); // call the specified function in class MyStack to add an integer to the array appropriately for the stack
    
    cout << "After pushing values, the stack size: " << astack.size() << endl; // call the specified function in class MyStack to get the stack size

    astack.display(); // call the specified function in class MyStack to display the information of the stack.
    valuePopped = astack.pop(); // call the specified function in class MyStack to remove and return an integer from the array

    cout << "Popping the value of " << valuePopped << ".\n"
         << "The value of " << valuePopped << " should have been removed." << endl;
    
    astack.display(); // call the specified function in class MyStack to display the information of the stack

    return 0;
} // end main