//**********************************************************
// Project Part 5 - C++ Coding
// Damian Hayes
// 4/28/2022
// This program records patron ratings until a negative is entered. Outputs number of patrons, average of all the ratings, and a message based on the average rating.
//**********************************************************

#include <iostream>

using namespace std;

// main program

int main()

{

	//Declarations
	int patrons = 0;
	int tempRating = 0;
	float totalRating = 0;
	float avgRating = 0;
	string outputMessage = "";
	string INPUT_REQUEST = "Enter a rating for the movie (0 - 4): ";
	string OUTPUT_PATRONS = "Number of ratings: ";
	string OUTPUT_AVG = "The average of the ratings is : ";


	//housekeeping()
	cout << INPUT_REQUEST;
	cin >> tempRating;

	//detailLoop()
	while (tempRating >= 0) {
		if (tempRating > 4) {
			tempRating = 0;
			cout << "Invalid entry. Please try again.";
			cout << INPUT_REQUEST;
			cin >> tempRating;
		} 
		else {
			totalRating += tempRating;
			patrons++;
			cout << INPUT_REQUEST;
			cin >> tempRating;
			
		}

		
	}

	//average()
	if (totalRating == 0) {
		avgRating = 0;
		cout << "No ratings made" << endl;
	}
	else {
		avgRating = totalRating / patrons;
		if (avgRating >= 3) {
			outputMessage = "Great movie choice";
		}
		else if (avgRating >= 2) {
			outputMessage = "Good movie choice";
		}
		else if (avgRating >= 1) {
			outputMessage = "Not a good movie choice";
		}
		else {
			outputMessage = "Bowling would have been a better choice";
		}
	}

	//finishUp()
	cout << OUTPUT_PATRONS << patrons << endl;
	cout << OUTPUT_AVG << avgRating << endl;
	cout << outputMessage;


	return 0;

}

