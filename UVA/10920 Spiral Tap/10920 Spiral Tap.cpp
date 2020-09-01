#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	freopen("input.txt", "r", stdin);
	freopen("output.txt", "w", stdout);

	int border;
	unsigned long long int number;
	while (cin>> border >> number)
	{
		if (border == 0 && number == 0)
		{
			return  0;
		}

		int center = (border / 2) + 1;

		double sq = sqrt(number);

		unsigned long long int sqc = ceil(sq);
		unsigned long long int sqf = floor(sq);

		sqf = sqf % 2 == 1 ? sqf : sqf - 1;

		int line = sqf, column = sqf;

		unsigned long long int steps = sqf * sqf;

		bool found = false;

		while (sqf != sqc)
		{
			line++;
			steps++;

			if (steps == number)
			{
				break;
			}

			for (int i = 0; i < sqf; i++)
			{
				column--;
				steps++;
				if (steps == number)
				{
					found = true;
					break;
				}
			}

			if (found)
			{
				break;
			}

			for (int i = 0; i <= sqf; i++)
			{
				line--;
				steps++;
				if (steps == number)
				{
					found = true;
					break;
				}
			}

			if (found)
			{
				break;
			}

			for (int i = 0; i <= sqf; i++)
			{
				column++;
				steps++;
				if (steps == number)
				{
					found = true;
					break;
				}

			}

			if (found)
			{
				break;
			}

			for (int i = 0; i <= sqf; i++)
			{
				column++;
				steps++;
				if (steps == number)
				{
					found = true;
					break;
				}
			}

			if (found)
			{
				break;
			}
		}

		cout << "Line = " << line << ", column = " << column << "." <<"\n";
	}
}

