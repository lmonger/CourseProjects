/*
Lorrie Monger
PRG 204
Chapter 5
You Do It
*/

#include <iostream>
using namespace std;

int main()
{
	const int NUM_SCORES = 10;
	int score[NUM_SCORES];
	int sub = 0;
	double total = 0;
	double average = 0;
	for (sub = 0; sub < NUM_SCORES; ++sub)

	{
		cout << "Enter score #" << (sub + 1) << " ";
		cin >> score[sub];
	}
		cout << endl << "The scores are:" << endl;
	for (sub = 0; sub < NUM_SCORES; ++sub)
	{
		total += score[sub];
		cout << score[sub] << " ";
	}
	cout << endl;
	average = total / NUM_SCORES;
	cout << "The average score is " << average << endl;
	return 0;
}
