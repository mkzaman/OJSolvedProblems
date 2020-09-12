#include <iostream>
#include <cstdio>
#include <algorithm>
#include <vector>

using namespace std;

int main()
{
	int cases;
	cin >> cases;
	while (cases--)
	{
		int n, x, y;

		cin >> n >> x >> y;

		if (x - n <= 0)
		{
			cout << x;
			int t = y - x;
			for (int i = 0; i < n-1; i++)
			{
				cout << x + t;
			}
			cout << endl;
		}

		int temp = y - x;
		int a = n;
		while (temp / a  > n - 1)
		{
			a++;
		}
	}
}