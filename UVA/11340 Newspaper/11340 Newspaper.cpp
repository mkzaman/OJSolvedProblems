// 11340 Newspaper.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

//#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <iomanip>
#include <cmath>
#include <cstdlib>
#include <ctime>
#include <vector>
#include <list>
#include <deque>
#include <queue>
#include <stack>
#include <map>
#include <set>
#include <bitset>
#include <cctype>
#include <cstring>
#include <typeinfo>
#include <exception>
#include <stdexcept>
#include <memory>
#include <fstream>
#include <string>
#include <sstream>
#include <functional>
#include <iterator>
#include <algorithm>
#include <cassert>
#include <cfloat>
#include <climits>
#include <cstdio>
#include <locale>
#include <limits>
#include <utility>

using namespace std;



int main()
{
	//freopen("input.txt", "r", stdin);
	//freopen("output.txt", "w", stdout);
	int cases;
	scanf("%d", &cases);
	while (cases > 0)
	{
		cases--;
		int num_of_values;
		scanf("%d", &num_of_values);
		getchar();
		int value_mapping[256] = {};
		while (num_of_values--)
		{
			unsigned char c;
			int value;
			scanf("%c %d", &c, &value);
			getchar();
			value_mapping[(int)c] = value;
		}

		int num_of_line;
		scanf("%d", &num_of_line);
		getchar();

		unsigned long long int result_in_cents = 0;
		while (num_of_line > 0)
		{
			num_of_line--;
			string s;
			getline(cin, s);

			for (int i = 0; i < s.size(); i++)
			{
				int char_value = (int)s[i];
				if (char_value < 0)
				{
					char_value += 256;
				}
				result_in_cents += value_mapping[char_value];
			}
		}
		printf("%0.2lf$\n", result_in_cents / 100.0);
	}
	return 0;
}
