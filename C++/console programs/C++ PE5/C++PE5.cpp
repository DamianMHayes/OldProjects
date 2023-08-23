// ******************************************************************************
// C++ Programming Exercise 5
// Damian M Hayes
// 4/12/2022
// Count 1 through 15
// ******************************************************************************

/*
count 1 - 15
multiply number by 10
multiply number by 100
*/

#include <iostream>

using namespace std;

int main()

{
	int loopCount;

	cout << "This program counts to 15 and shows the number multiplied by 10 and 100." << endl;

	for (loopCount = 1; loopCount <= 15; loopCount++) {
		cout << "number:            " << loopCount << endl;
		cout << "number times 10:   " << loopCount * 10 << endl;
		cout << "number times 100:  " << loopCount * 100 << endl << endl;
	}

	return 0;

}