// *********************************************************************
// Damian M Hayes
// 3/20/2022
// PThis program converts tablespoons to teaspoons
// *********************************************************************

#include <iostream>

using namespace std;

int main()

{
	double teaspoons;
	double tablespoons;
	cout << "Enter number of tablespoons: ";
	cin >> tablespoons;
	teaspoons = tablespoons * 3;
	cout << "The number of teaspoons is " << teaspoons;

	return 0;

}