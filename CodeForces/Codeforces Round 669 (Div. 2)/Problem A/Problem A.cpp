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
		int a;
		int b;
		cin >> a;
		vector<int>x;
		while (a--)
		{
			cin >> b;
			x.push_back(b);
		}

		int count0 = 0;
		int count1 = 0;

		for (auto p : x)
		{
			if (p == 0)
			{
				count0++;
			}
			else
			{
				count1++;
			}
		}

		if (count0 >= count1)
		{
			cout << count0 << endl;
			for (int i = 0; i < count0; i++)
			{
				cout << "0 ";
			}
		}
		else if(count1 % 2 == 0)
		{
			cout << count1 << endl;
			for (int i = 0; i < count1; i++)
			{
				cout << "1 ";
			}
		}
		else
		{
			count1--;
			cout << count1 << endl;
			for (int i = 0; i < count1; i++)
			{
				cout << "1 ";
			}
		}
		
		cout << endl;
	}
}
