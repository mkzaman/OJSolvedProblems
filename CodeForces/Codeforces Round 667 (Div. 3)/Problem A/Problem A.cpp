#include <iostream>
#include <cstdio>
#include <algorithm>
#include <vector>
#include <cmath>

using namespace std;

int main()
{
    int cases;
    cin >> cases;
	while (cases--)
	{
		int a, b;
		cin >> a >> b;
		int r = 0;
		
		if (a != b)
		{
			int t = abs(a - b);
			t /= 10;
			int x = min(a, b);
			int y = max(a, b);
			if ((x + t * 10) != y)
			{
				t++;
			}
			r = t;
		}
		
		cout << r << endl;
	}
}