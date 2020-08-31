#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

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
		
		int up = 1;
		int left = 1;
		int right = 2;
		int down = 2;
		
		int column = center;
		int line = center;
		
		unsigned long long int step = 1;
		bool found = false;
		while (1) 
		{
			if (number == 1)
			{
				break;
			}
			for (int i = 0; i < up; i++)
			{
				line++;
				step++;
				if (step == number)
				{
					found = true;
					break;
				}
			}

			if (found)
			{
				break;
			}

			up += 2;

			for (int i = 0; i < left; i++)
			{
				column--;
				step++;
				if (step == number)
				{
					found = true;
					break;
				}
			}

			if (found)
			{
				break;
			}

			left += 2;

			for (int i = 0; i < down; i++)
			{
				line--;
				step++;
				if (step == number)
				{
					found = true;
					break;
				}
			}

			if (found)
			{
				break;
			}

			down += 2;

			for (int i = 0; i < right; i++)
			{
				column++;
				step++;
				if (step == number)
				{
					found = true;
					break;
				}
			}

			if (found)
			{
				break;
			}

			right += 2;
		}

		cout << "Line = " << line << ", column = " << column << "." <<"\n";
	}
}

