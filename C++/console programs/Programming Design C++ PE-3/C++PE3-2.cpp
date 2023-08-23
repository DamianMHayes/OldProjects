// *********************************************************************
// Damian M Hayes
// 3/20/2022
// THis program takes the user's monthly rent and number of days in a month, then outputs how much the user pays each day
// *********************************************************************

#include <iostream>

using namespace std;

int main()

{
	double monthRent;
	int days;
	double daily;
	cout << "Enter your monthly rent cost (DO NOT INCLUDE DOLLAR SIGN): " << endl;
	cin >> monthRent;
	cout << "Enter how many days are in the month: " << endl;
	cin >> days;
	daily = monthRent / days;
	cout << "your daily rent is $" << daily;

	return 0;

}