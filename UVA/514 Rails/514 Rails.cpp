// 514 Rails.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

//#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <stack>
#include <vector>
#include <sstream>
#include <string>
#include <cstring>

using namespace std;

int main()
{
	//freopen("input.txt", "r", stdin);
	//freopen("output.txt", "w", stdout);
	
	vector<int> input;
	int n;

	while (cin >> n)
	{
		if (n == 0)
		{
			return 0;
		}
		while (true)
		{
			stack<int> s1;
			stack<int> s2;

			for (int i = n; i >= 1; i--)
			{
				s1.push(i);
			}

			int temp = -1;
			bool possible = true;
			bool isContinue = false;
			for (int i = 0; i < n; i++)
			{
				cin >> temp;
				if (isContinue)
				{
					continue;
				}

				if (temp == 0)
				{
					break;
				}

				if (!s2.empty() && temp == s2.top())
				{
					s2.pop();
				}
				else if (!s2.empty() && temp < s2.top())
				{
					possible = false;
					isContinue = true;
				}
				else
				{
					while (s1.top() != temp)
					{
						s2.push(s1.top());
						s1.pop();
					}
					s1.pop();
				}
			}

			if (temp == 0)
			{
				cout << endl;
				break;
			}

			if (possible)
			{
				cout << "Yes" << endl;
			}
			else
			{
				cout << "No" << endl;
			}
		}
	}
}