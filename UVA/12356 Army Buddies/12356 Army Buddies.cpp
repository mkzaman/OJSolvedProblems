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
			vector<int>left(s);
			vector<int>right(s);

			iota(left.begin(), left.end(), 0);
			iota(right.begin(), right.end(), 2);
			right[s - 1] = 0;

			for (int x = 0; x < b; x++)
			{
				int y, z;
				scanf("%d %d", &y, &z);

				if (left[y - 1] != 0) {
					right[left[y - 1] - 1] = right[z - 1];
				}
				
				if (right[z - 1] != 0) {
					left[right[z - 1] - 1] = left[y - 1];
				}

				if (left[y - 1] == 0)
				{
					printf("* ");
				}
				else {
					printf("%d ", left[y - 1]);
				}

				if (right[z - 1] == 0)
				{
					printf("*");
				}
				else
				{
					printf("%d", right[z - 1]);
				}
				printf("\n");
			}
			
			printf("-\n");
		}
	}
	return 0;
}