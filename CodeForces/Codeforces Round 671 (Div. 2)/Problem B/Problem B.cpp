#include <iostream>
#include <vector>
#include <cmath>
#include <cstdio>
using namespace std;

#define lli long long int
int main()
{
    vector<lli> storage(30, 0);
    storage[0] = 1;
    lli temp = 1;
    for (int i = 1; i <= 29; i++)
    {
        temp += pow(2, i);

        lli t = (temp * (temp + 1)) / 2;
        storage[i] = (t + storage[i - 1]);
    }

    int cases;
    cin >> cases;
    while (cases--)
    {
        lli x;
        cin >> x;
        int ans = 30;
        for (int i = 0; i <= 30; i++)
        {
            if (storage[i] == x)
            {
                ans = i + 1;
                break;
            }
            else if (storage[i] > x)
            {
                ans = i;
                break;
            }
        }
        cout << ans << endl;
    }

    return 0;
}
