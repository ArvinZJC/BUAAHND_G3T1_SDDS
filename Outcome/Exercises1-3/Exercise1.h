/*
 * @Description: cpp header file that contains 2 ADTs respectively for an integer stack and a set
 * @Version: 2.0
 * @Author: Arvin Zhao
 * @Date: 2018-12-03 18:53:44
 * @Last Editors: Arvin Zhao
 * @LastEditTime: 2019-05-06 19:48:03
 */

#ifndef EXERCISE1_H
#define EXERCISE1_H
#include <iostream>

/* (Interface) Struct that contains functions for operating an integer stack. */
struct StackADT
{
    /**
     * (Pure Virtual Function) Add an integer to the list appropriately for the stack.
     * @param value the integer added to the list
     */
    virtual void push(int value) = 0;

    /**
     * (Pure Virtual Function) Remove and return an integer from the list.
     * @return the integer removed from the list
     */
    virtual int pop() = 0;

    /**
     * (Pure Virtual Function) Check if the stack is empty.
     * @return the bool value true if the stack is empty, or false if the stack is not empty
     */
    virtual bool isEmpty() = 0;

    /**
     * (Pure Virtual Function) Get the stack size.
     * @return the number of items in the stack
     */
    virtual int size() = 0;
}; // end struct StackADT

/* (Template) Struct that contains functions for operating a set. */
template <typename T>
struct SetADT
{
    /**
     * (Prototype) Add an object of a specified type to the set.
     * @param o the object of the specified type added to the set
     */
    void add(T o);

    /**
     * (Prototype) Remove an object of a specified type from the set.
     * @param o the object of the specified type removed from the set
     */
    void remove(T o);

    /**
     * (Prototype) Set this set to the intersection of itself and "s".
     * @param s the SetADT object used for getting the intersection
     */
    void intersection(SetADT<T> s);

    /**
     * (Prototype) Set this set to the difference between itself and "s".
     * @param s the SetADT used for getting the difference
     */
    void difference(SetADT<T> s);

    /**
     * (Prototype) Get the set size.
     * @return the number of objects in the set
     */
    int size();

    /**
     * Check if the set is empty. 
     * @return the bool value true if the set is empty, or false if the set is not empty
     */
    bool isEmpty()
    {
        // call the specified function to assist to validate if the set size is 0
        if (size() == 0)
            return true;
        else
            return false;
    } // end function isEmpty
}; // end struct SetADT 
#endif