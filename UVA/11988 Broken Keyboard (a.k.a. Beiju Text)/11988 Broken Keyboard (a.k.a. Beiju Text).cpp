//#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <queue>
#include <string>
#include <cstring>
#include <list>

using namespace std;

int main()
{
	//freopen("input.txt", "r", stdin);
	//freopen("output.txt", "w", stdout);
	
	string s;
	while (cin >> s)
	{
		list<char> result;

		list<char>::iterator it;

		bool isPushBack = true;

		for (int i = 0; i < s.size(); i++)
		{
			if (s[i] == '[')
			{
				isPushBack = false;
				it = result.begin();

			}
			else if (s[i] == ']')
			{
				isPushBack = true;
			}
			else
			{
				if (isPushBack)
				{
					result.push_back(s[i]);
				}
				else
				{
					result.insert(it, s[i]);
				}
			}
		}

		for (auto x : result)
		{
			cout << x;
		}
		cout << endl;
	}
}
