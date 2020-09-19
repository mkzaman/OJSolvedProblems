#include <iostream>

using namespace std;

#define lli long long int

int main()
{
    lli x;
    cin >> x;

    while (x != 1)
    {
        cout << x << " ";

        if (x % 2 == 1)
        {
            x *= 3;
            x++;
        }
        else
        {
            x /= 2;
        }
    }
    cout << x;
    cout << endl;
}

