/*
 Lorrie Monger
 PRG 204
 Chapter 4
 Execise 1
*/

#include <iostream>
using namespace std;


int main()
{
	int number = 0;
	const int NUM_LOOPS = number;
	int count = 0;
	cout << "Please enter the number of times you want the greeting to display. ";
	cin >> count;
	while (count > NUM_LOOPS)
	{
		cout << "Greetings User" << endl;
		--count;
	}
};




