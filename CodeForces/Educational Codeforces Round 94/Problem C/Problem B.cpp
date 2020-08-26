
#include <iostream>
#include <cstring>
#include <cmath>
#include <algorithm>
#include <string>

using namespace std;

int main()
{
	int cases;
	cin >> cases;
	while (cases--)
	{
		string s;
		cin >> s;

		int a;
		cin >> a;

		int ss = s.size();

		string result = string(ss, '1');

		for (int i = 0; i < ss; i++)
		{
			if (s[i] == '0')
			{
				if (i < a )
				{
					result[i + a] = '0';
				}
				else if (i > (ss - a -1))
				{
					result[i - a] = '0';
				}
				else
				{
					result[i - a] = '0';
					result[i + a] = '0';
				}
			}
		}

		bool isPossible = true;
		for (int i = 0; i < ss; i++)
		{
			if (s[i] == '1')
			{
				if (i < a)
				{
					if (result[i + a] == '0')
					{
						isPossible = false;
					}
				}
				else if (i > (ss - a - 1))
				{
					if (result[i - a] == '0')
					{
						isPossible = false;
					}
				}
				else
				{
					if (result[i - a] == '0' && result[i + a] == '0')
					{
						isPossible = false;
					}
				}
			}
		}

		if (isPossible)
		{
			cout << result;
		}
		else
		{
			cout << "-1";
		}
		cout << "\n";
	}
	
}

