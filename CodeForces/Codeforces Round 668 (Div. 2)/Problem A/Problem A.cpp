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
		int n;
		cin >> n;
		vector<int> x;
		while (n--)
		{
			int temp;
			cin >> temp;
			x.push_back(temp);
		}
		reverse(x.begin(), x.end());

		for (auto p : x)
		{
			cout << p << " ";
		}
		cout << endl;
	}
}
