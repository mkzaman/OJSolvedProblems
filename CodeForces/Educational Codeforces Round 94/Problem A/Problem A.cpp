
#include <iostream>
#include <cstring>

using namespace std;

int main()
{
	int cases;
	cin >> cases;
	while (cases--)
	{
		int a;
		cin >> a;
		string s;
		cin >> s;
		char c = s[a - 1];

		for (int i = 0; i < a; i++)
		{
			cout << c;
		}
		cout << "\n";
	}
}

