#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <vector>
#include <string>

using namespace std;

int calculate_match(vector<string> L, vector<string> s)
{
	int N = L.size();
	int n = s.size();

	int result = 0;

	for (int i = 0; i <= N - n; i++)
	{
		for (int j = 0; j <= N - n; j++)
		{
			bool isMatch = true;
			for (int k = 0; k < n; k++)
			{
				string str = L[i+k].substr(j, n);
				if (str != s[k])
				{
					isMatch = false;
					break;
				}
			}
			if (isMatch)
			{
				result++;
			}
		}
	}
	return result;
}

int main()
{
	//freopen("input.txt", "r", stdin);
	//freopen("output.txt", "w", stdout);
    int N, n;
	while (cin>> N >> n)
	{
		vector<string> large_squre;
		vector<string> small_square;
		if (N == 0 && n == 0)
		{
			return 0;
		}

		for(int i=0; i<N; i++)
		{
			string temp;
			cin >> temp;
			large_squre.push_back(temp);
		}

		for(int i=0; i< n;i++)
		{
			string temp;
			cin >> temp;
			small_square.push_back(temp);
		}

		vector<string> small_square90;
		vector<string> small_square180;
		vector<string> small_square270;

		for (int i = 0, x = 0 ; i < n; i++, x++)
		{
			string temp;
			for (int j = 0, y = n-1 ;j < n; j++, y--)
			{
				temp.push_back(small_square[y][x]);
			}
			small_square90.push_back(temp);
		}

		for (int i = 0, x = n-1; i < n; i++, x--)
		{
			string temp;
			for (int j = 0, y = n - 1; j < n; j++, y--)
			{
				temp.push_back(small_square[x][y]);
			}
			small_square180.push_back(temp);
		}

		for (int i = 0, x = n-1; i < n; i++, x--)
		{
			string temp;
			for (int j = 0, y = 0; j < n; j++, y++)
			{
				temp.push_back(small_square[y][x]);
			}
			small_square270.push_back(temp);
		}

		int result[4];

		result[0] = calculate_match(large_squre, small_square);
		result[1] = calculate_match(large_squre, small_square90);
		result[2] = calculate_match(large_squre, small_square180);
		result[3] = calculate_match(large_squre, small_square270);

		for (int i = 0; i < 4; i++)
		{
			cout << result[i];
			if (i != 3)
			{
				cout << " ";
			}
		}
		cout << endl;
	}
}
