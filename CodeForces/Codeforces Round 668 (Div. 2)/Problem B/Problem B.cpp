#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>

using namespace std;

int main()
{
	int cases;
	cin >> cases;
	while (cases--)
	{
		int t;
		cin >> t;

		long long int neg = -1;
		long long int pos = 0;
		long long int ans = 0;

		for (int i = 0; i < t; i++)
		{
			long long int a;
			cin >> a;

			if (a < 0)
			{
				if (pos + a < 0)
				{
					pos = 0;
				}
				else
				{
					pos += a;
				}
			}
			else
			{
				pos += a;
			}

		}
		cout << pos << endl;
	}
}