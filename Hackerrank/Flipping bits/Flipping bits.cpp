// Flipping bits.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

int main()
{
	int cases;
	cin >> cases;
	while (cases--)
	{
		unsigned int a;
		cin >> a;

		for (int i = 0; i < 32; i++)
		{
			a ^= (1 << i);
		}

		cout << a << "\n";
	}

}
