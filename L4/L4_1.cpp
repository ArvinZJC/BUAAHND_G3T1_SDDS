// program that uses insert sort

#include <iostream>
using namespace std;

/* Output an array. */
void OutputArray(int array[], int arrayLength)
{
	for (int count = 0; count < arrayLength; count++)
		cout << array[count] << "  ";
} // end function OutputArray

int main()
{
	int array[] = {5, 5, 2, 5, 3, 14, 9, 0, -4, 15};
	int arrayLength = sizeof(array) / sizeof(array[0]), temp, j;

	cout << "Before sorting:" << endl;

	OutputArray(array, arrayLength); // call the specified function to output the array named array

	for (int i = 1; i < arrayLength; i++)
	{
		temp = array[i];

		for (j = i - 1; j >= 0 && temp < array[j]; j--)
			array[j + 1] = array[j];

		array[j + 1] = temp;
	} // end for

	cout << "\nAfter sorting:" << endl;

	OutputArray(array, arrayLength); // call the specified function to output the array named array

	cout << endl;

	return 0;
} // end main