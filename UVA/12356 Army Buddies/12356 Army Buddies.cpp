// 12356 Army Buddies.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <vector>
#include <numeric>
#include <algorithm>
#include <iterator>

using namespace std;
int main()
{
	int s, b;
	while (scanf("%d %d", &s ,& b))
	{
		if (s == 0 && b == 0)
		{
			return 0;
		}
		else
		{
			vector<int> a(s);
			iota(a.begin(), a.end(), 1);
			for (int x = 0; x < b; x++)
			{
				int y, z;
				scanf("%d %d", &y, &z);
				vector<int>::iterator it1, it2;
				it1 = find(a.begin(), a.end(), y);
				it2 = find(a.begin(), a.end(), z);

				it2++;
				if (it1 == a.begin())
				{
					printf("* ");
				}
				else
				{
					printf("%d ", *--it1);
					it1++;
				}


				if (it2 == a.end())
				{
					printf("*");
				}
				else
				{
					printf("%d", *it2);
				}

				a.erase(it1, it2);
				printf("\n");
			}
			printf("-\n");
		}
	}
	return 0;
}