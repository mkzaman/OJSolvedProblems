// 541 Error Correction.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>

using namespace std;

int main()
{
	int n = 0;
	while (cin >> n)
	{
		if (n == 0)
		{
			return 0;
		}
		vector<int> row_data(n, 0);
		vector<int> column_data(n, 0);
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				int temp;
				cin >> temp;
				if (temp == 1)
				{
					row_data[i]++;
					column_data[j]++;
				}
			}
		}

		vector<int> odd_row;
		vector<int> odd_column;

		for (int i = 0; i < n; i++)
		{
			if (row_data[i] % 2 == 1)
			{
				odd_row.push_back(i + 1);
			}
		}

		for (int i = 0; i < n; i++)
		{
			if (column_data[i] % 2 == 1)
			{
				odd_column.push_back(i + 1);
			}
		}

		if (odd_row.size() > 1 || odd_column.size() > 1)
		{
			cout << "Corrupt" << endl;
		}
		else if (odd_row.size() == 1 || odd_column.size() == 1)
		{
			cout << "Change bit (" << odd_row[0] << "," << odd_column[0] << ")" << endl;
		}
		else
		{
			cout << "OK" << endl;
		}
	}
}