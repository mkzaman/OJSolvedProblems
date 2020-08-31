#include <iostream>
#include <vector>
#include <cstring>
#include <string>
#include <algorithm>
#include <cmath>
#include <cstdio>

using namespace std;

int main()
{
	vector<int> input;
    int cases;
    cin >> cases;
	int tempc = cases;
	while (cases--)
	{
		int temp;
		cin >> temp;
		input.push_back(temp);
	}

	sort(input.begin(), input.end());

	int a = input[tempc - 1];
	int b = tempc - 1;

	double x = pow(a, 1.0 / b);

	int temp = ceil(x);

	int xi = 0;

	unsigned long long int min_value = 0;
	for (int i = 1; i <= temp; i++)
	{
		unsigned long long int temp_result = 0;
		for (int j = 0; j < input.size(); j++)
		{
			int x = pow(i, j);
			temp_result += abs(x - input[j]);
		}
		if (i == 1)
		{
			min_value = temp_result;
		}
		else
		{
			min_value = min(min_value, temp_result);
			xi = i;
		}
	}

	cout << min_value << xi << endl;
}