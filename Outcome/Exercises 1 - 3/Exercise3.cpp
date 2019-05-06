/*
 * @Description: program that implements a specified ADT using a linked list data structure and simply tests it
 * @Version: 1.0
 * @Author: Arvin Zhao
 * @Date: 2018-12-04 18:47:44
 * @Last Editors: Arvin Zhao
 * @LastEditTime: 2019-05-06 19:49:34
 */

#include "Exercise1.h"
#include <iostream>
using namespace std;

/* Struct that is used as a linked list of type integer. */
struct IntLinkedList
{
    int data; // store an integer for the current node
    IntLinkedList* next; // a pointer for the next node
}; // end struct IntLinkedList

/* Implementing struct StackADT, this class contains a linked stack of type integer and relevant functions. */
class MyLinkedStack : public StackADT
{
    IntLinkedList* list; // a pointer for the top node

    /**
     * Print elements in the stack reversingly.
     * This is an iterative function which is used to print the element in a head node inside the function.
     * @param p the current head node
     */
    void printReversingly(IntLinkedList* p)
    {
        if (p->next != NULL)
            printReversingly(p->next); // call the specified function to print the element in a new head node 
        
        cout << "Value: " << p->data << endl;
    } // end function printReversingly

public:
    MyLinkedStack()
    {
        list = new IntLinkedList; // instance an IntLinkedList object for the top node
        list->data = 0;
        list->next = NULL;
    } // end constructor MyLinkedStack

    ~MyLinkedStack()
    {
        delete list; // delete the top node to try to avoid resource leak or any other problem
    } // end destructor MyLinkedStack

    /**
     * Add an integer to the list appropriately for the stack.
     * @param value the integer added to the list
     */
    void push(int value)
    {
        IntLinkedList* p = list; // initialise the current head node to a specified node
        IntLinkedList* newNode = new IntLinkedList; // a new node for the integer added to the list
        newNode->data = value;
        newNode->next = NULL;
        
        // loop to find the buttom node
        while (p->next != NULL)
            p = p->next;
            
        p->next = newNode; // a new buttom node
    } // end function push

    /**
     * Remove and return an integer from the list.
     * Before calling this function, check if the stack is empty first!
     * @return the integer removed from the list
     */
    int pop()
    {
        int valuePopped; // record the value popped from the stack
        IntLinkedList* p = list; // initialise the current head node to a specified node
        IntLinkedList* pTemp = NULL; // record the node before the bottom node

        // loop to find the bottom node and the node before it
        while (p->next != NULL)
        {
            pTemp = p;
            p = p->next;
        } // end while

        valuePopped = p->data;
        delete p; // delete the bottom node
        p = NULL;
        pTemp->next = NULL; // the node before the original buttom node now becomes the buttom node

        return valuePopped;
    } // end function pop

    /**
     * Check if the stack is empty.
     * @return the bool value true if the stack is empty, or false if the stack is not empty
     */
    bool isEmpty()
    {
        if (list->next == NULL)
            return true;
        else
            return false;
    } // end function isEmpty

    /**
     * Get the stack size.
     * @return the number of items in the stack
     */
    int size()
    {
        int count = 0; // a count for counting the number of items in the stack
        IntLinkedList* p = list->next; // initialise the current head node to a specified node

        while (p != NULL)
        {
            count++;
            p = p->next; // specify a new head node
        } // end while

        return count;
    } // end function size

    /**
     * Display the information of the stack.
     */
    void display()
    {
        int stackSize = size(); // call the specified function to get the stack size

        cout << "The list has " << stackSize << " item(s)." << endl;
        
        printReversingly(list->next); // call the specified function to print elements in the stack reversingly
    } // end function display
}; // end class MyLinkedStack

int main()
{
    MyLinkedStack astack; // instant a MyLinkedStack object for testing an integer stack
    int valuePopped; // record the value popped from the stack

    cout << "***** Testing an integer stack *****\n"
         << "The stack is empty? " << boolalpha << astack.isEmpty() << endl; // call the specified function in class MyLinkedStack to check if the stack is empty
    
    for (int value = 1; value < 6; value++)
        astack.push(value); // call the specified function in class MyLinkedStack to add an integer to the list appropriately for the stack
    
    cout << "After pushing values, the stack size: " << astack.size() << endl; // call the specified function in class MyLinkedStack to get the stack size

    astack.display(); // call the specified function in class MyLinkedStack to display the information of the stack.
    valuePopped = astack.pop(); // call the specified function in class MyLinkedStack to remove and return an integer from the list

    cout << "Popping the value of " << valuePopped << ".\n"
         << "The value of " << valuePopped << " should have been removed." << endl;
    
    astack.display(); // call the specified function in class MyLinkedStack to display the information of the stack.
} // end main