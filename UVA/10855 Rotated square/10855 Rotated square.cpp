#include <iostream>
#include <vector>
#include <string>

using namespace std;

int main()
{
    int N, int n;
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
				temp.push_back(small_square[y][x]);
			}
			small_square180.push_back(temp);
		}

		for (int i = 0, x = 0; i < n; i++, x++)
		{
			string temp;
			for (int j = 0, y = n - 1; j < n; j++, y--)
			{
				temp.push_back(small_square[x][y]);
			}
			small_square270.push_back(temp);
		}

		for (int i = 0; i <= (N - n); i++)
		{
			for (int j = 0; j <= (N - n); j++) 
			{


			}
		}

	}
}
