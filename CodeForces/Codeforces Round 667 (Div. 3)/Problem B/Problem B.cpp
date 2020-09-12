#include <iostream>
#include <cstdio>
#include <algorithm>
#include <vector>

using namespace std;

long long int result(long long int a, long long int b, long long int x, long long int y, long long int n)
{
	long long int ans1;

	if (a - x <= n)
	{
		int temp = n - (a - x);
		if (b - y > temp)
		{
			ans1 = x * (b - temp);
		}
		else
		{
			ans1 = x * y;
		}

	}
	else
	{
		ans1 = (a - n) * b;
	}
	return ans1;
}

int main()
{
	int cases;
	cin >> cases;
	while (cases--)
	{
		long long int a, b, x, y, n;
		cin >> a >> b >> x >> y >> n;

		long long int ans1, ans2;


		ans1 = result(a, b, x, y, n);
		ans2 = result(b, a, y, x, n);

		cout << min(ans1, ans2) << endl;
	}
}