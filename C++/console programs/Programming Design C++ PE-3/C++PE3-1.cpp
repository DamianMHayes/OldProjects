// *********************************************************************
// Damian M Hayes
// 3/20/2022
// This program takes how many miles were traveled along with gallons of gas consumed, then outputs the miles-per-gallon
// *********************************************************************

#include <iostream>

using namespace std;

int main()

{
	double miles;
	double gallons;
	double mpg;
	cout << "Enter how many miles you traveled: " << endl;
	cin >> miles;
	cout << "Enter how many gallons of gas were used : " << endl;
	cin >> gallons;
	mpg = gallons / miles;
	cout << "Your miles - per - gallon is " << mpg;
	return 0;

}

/*
Psuedocode
	start
	input decimal miles "Enter how many miles you traveled: "
	input decimal gallons "Enter how many gallons of gas were used: "
	mpg = gallons / miles
	output "Your miles-per-gallon is " + mpg
	stop
*/