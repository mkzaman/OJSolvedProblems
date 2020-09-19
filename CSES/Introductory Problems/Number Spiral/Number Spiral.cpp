#include <iostream>
#include <cmath>

using namespace std;

#define lli long long int

int main()
{
    int cases;
    cin >> cases;
    while (cases--)
    {
        lli y, x;
        cin >> y >> x;
        lli ans;
        if (x > y)
        {
            ans = x % 2 == 1 ? (x * x) - y + 1 : (x - 1) * (x - 1) + y;
        }
        else
        {
            ans = y % 2 == 1 ? (y - 1) * (y - 1) + x : (y * y) - x + 1;
        }
        
        cout << ans << endl;
    }
}