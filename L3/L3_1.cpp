// program that uses bubble sort and binary search in programmer-declared functions to find the specified key in a list

#include <iostream>
using namespace std;

int list[] = {23, 1, 46, 102, -98, -1, -7, 45, 0, 79, 66};
int listLength = sizeof(list) / sizeof(list[0]);

/* Use bubble sort to sort a list in ascending order. */
void BubbleSort()
{
	bool isSwapped;
	
	do
	{
		isSwapped = false;

		for (int count = 0; count < listLength - 1; count++)
		{
			if (list[count] > list[count + 1])
			{
				int temp = list[count + 1];
				list[count + 1] = list[count];
				list[count] = temp;
				isSwapped = true;
			} // end if
		} // end for
	} while (isSwapped == true); // if bubble sort doesn't perform any swaps, then the list is in sorted order
} // end function BubbleSort

/* Use binary search to find the specified key in a list. */
int BinarySearch(int key)
{
	int low = 0, high = listLength - 1, middle;

	// all the integers in the list have been searched when high < low
	while (high >= low)
	{
		middle = (low + high) / 2;

		if (key < list[middle])
			high = middle - 1; // perhaps key ∈ [low, middle - 1]
		else if (key > list[middle])
			low = middle + 1; // perhaps key ∈ [middle + 1, high]
		else
			return middle; // the key is found and the index value is equal to the value of the variable "middle"
	} // end while

	return -1;
} // end function BinarySearch

/* Output the searching result. */
void OutputResult(int index)
{
	if (index == -1)
		cout << "  Not found in the list." << endl;
	else
		cout << "  Index in the list: " << index << endl;
} // end function OutputResult

int main()
{
	BubbleSort(); // call the specified function to use bubble sort to sort the array named list in ascending order

	cout << "The list after sorting in ascending order:" << endl;

	for (int count = 0; count < listLength; count++)
		cout << "  " << list[count];

	cout << "\nThe key: 2" << endl;

	OutputResult(BinarySearch(2)); // first, call the specified function to use binary search to find 2 in the array named list; then, call the specified function to output the searching result

	cout << "The key: -7" << endl;

	OutputResult(BinarySearch(-7)); // first, call the specified function to use binary search to find -7 in the array named list; then, call the specified function to output the searching result

	system("pause");
	return 0;
} // end main