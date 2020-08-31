#include <iostream>
#include <vector>
#include <algorithm>
#include <cstring>
#include <string>
#include <map>

using namespace std;

int main()
{
    int cases;
    cin >> cases;
	while (cases--)
	{
		int a;
		cin >> a;
		int temp = a;
		map<char, int> m;
		while (a--)
		{
			string s;
			
			cin >> s;
			for (int i = 0; i < s.size(); i++)
			{
				m[s[i]]++;
			}
		}

		string ans = "YES";
		for (auto x : m)
		{
			if (x.second % temp != 0)
			{
				ans = "NO";
			}
		}
		cout << ans << "\n";
	}
}