#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;

    int ans = 0;
    if (n >= 5)
    {
        for (int i = 5; i <= n; i += 5)
        {
            int temp = i;
            while (temp % 5 == 0)
            {
                ans++;
                temp /= 5;
            }
        }
    }

    cout << ans << endl;
}
