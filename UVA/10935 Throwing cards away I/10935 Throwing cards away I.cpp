//#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <queue>

using namespace std;

int main()
{
	//freopen("input.txt", "r", stdin);
	//freopen("output.txt", "w", stdout);

	int n;

	while (cin >> n)
	{
		if (n == 0)
		{
			return 0;
		}

		queue<int> q;

		for (int i = 1; i <= n; i++)
		{
			q.push(i);
		}

		cout << "Discarded cards:";
		while (q.size() != 1)
		{
			cout << " " <<q.front();
			q.pop();
			q.push(q.front());
			q.pop();
			if (q.size() != 1)
			{
				cout << ",";
			}
		}
		cout << endl;

		cout << "Remaining card: " << q.front() << endl;
	}
}
