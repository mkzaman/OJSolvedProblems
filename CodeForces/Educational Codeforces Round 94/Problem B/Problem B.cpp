
#include <iostream>
#include <cstring>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
	int cases;
	cin >> cases;
	while (cases--)
	{
		int p, f;
		cin >> p >> f;

		int cnts, cntw;
		cin >> cnts >> cntw;

		int s, w;
		cin >> s >> w;

		int result;

		if (s > w) {
			swap(s, w);
			swap(cnts, cntw);
		}

		int temp = min(p / s, cnts);

		int ans = 0;

		for (int i = 0; i <= temp; i++)
		{
			int w1 = min(cntw, (p - (i*s)) / w);
			int s2 = min(cnts - i, f / s);
			int w2 = min(cntw - w1, (f - (s2 * s)) / w);
			ans = max(ans, i + w1 + s2 + w2);
		}

		cout << ans << "\n";
	}
}

