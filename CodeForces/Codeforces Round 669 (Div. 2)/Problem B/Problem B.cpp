#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>
#include <string> 

using namespace std;

bool cmp(int a, int b)
{
	return to_string(a) < to_string(b);
}

int gcd(int a, int b)
{
	if (b == 0)
	{
		return a;
	}
	return gcd(b, a % b);
}

int main()
{
	int cases;
	cin >> cases;
	while (cases--)
	{
		int a;
		cin >> a;
		vector<int> x;
		while (a--)
		{
			int t;
			cin >> t;
			x.push_back(t);
		}
		
		vector<int>result;
		int m = *max_element(x.begin(), x.end());
		result.push_back(m);
		x.erase(remove(x.begin(), x.end(), m), x.end());

		int g = m;
		while (x.size() != 0)
		{
			int max_gcd = 0;
			int mm = 0;
			for (int i = 0; i < x.size(); i++)
			{
				int s = gcd(max(g, x[i]), min(g, x[i]));
				if (s > max_gcd)
				{
					max_gcd = s;
					mm = x[i];
				}
				if (s == max_gcd)
				{
					if (to_string(x[i]) > to_string(mm))
					{
						mm = x[i];
					}
				}
			}

			if (max_gcd == 0 || max_gcd == 1)
			{
				break;
			}
			else
			{
				result.push_back(mm);
				g = max_gcd;
				x.erase(remove(x.begin(), x.end(), mm), x.end());
			}
		}

		sort(x.begin(), x.end());

		for (auto p : result)
		{
			cout << p << " ";
		}

		if (x.size() > 0)
		{
			for (auto p : x)
			{
				cout << p << " ";
			}
		}
		cout << endl;
	}
}