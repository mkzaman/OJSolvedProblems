#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>

using namespace std;

#define lli long long int

int main()
{
	int cases;
	cin >> cases;
	vector<int> x;
	while (cases--)
	{
		int temp;
		cin >> temp;
		x.push_back(temp);
	}

	sort(x.begin(), x.end());

	int ans = ceil(x.size() / 2.0) -1;

	cout << ans << endl;

	vector<int> a;
	vector<int> b;
	for (int i = 0; i < x.size(); i++)
	{
		if (ans != 0)
		{
			a.push_back(x[i]);
			ans--;
		}
		else
		{
			b.push_back(x[i]);
		}
	}

	for (int i = 0; i < b.size(); i++)
	{
		cout << b[i] << " ";
		if (i < a.size())
		{
			cout << a[i] << " ";
		}
	}
}
