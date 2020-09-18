
#include <iostream>
#include <cstring>
#include <cmath>
#include<algorithm>
using namespace std;

int main()
{
	int cases;
	cin >> cases;
	while (cases--)
	{
		unsigned long long int x, y, k;
		cin >> x >> y >> k;
		unsigned long long int sticks = (y * k);
		sticks += k;

		sticks--;

		unsigned long long int t = sticks / (x - 1);

		if (t * (x - 1) != sticks)
		{
			t++;
		}

		cout << t + k << endl;

	}
}

