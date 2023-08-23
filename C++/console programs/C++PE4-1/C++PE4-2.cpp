// C++ Programming Exercise 4 #2
// Damian Hayes
// 4/3/2022
// Salesperson calculator
// *********************************************************************

#include <iostream>

using namespace std;

// main program
int main()
{
	//Declarations
	int shirts;
	string salesPerson;
	float totalValue;
	// housekeeping
	cout << "Enter the sales person's name: ";
	cin >> salesPerson;

	// detail
	cout << "Enter the number of shirt sold: ";
	cin >> shirts;
	totalValue = shirts * 30;
	cout << "Sales person's name: " << salesPerson << endl <<
	"Number of sweetshirts sold: " << shirts << endl <<
	"Total value of sales: " << totalValue << endl;
	if (totalValue > 7000) {
		cout << "High performer!" << endl;
	}

	// end-of job
	cout << "Thanks for using this program";

	return 0;
}