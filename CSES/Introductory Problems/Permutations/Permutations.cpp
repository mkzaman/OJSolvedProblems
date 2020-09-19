#include <iostream>


using namespace std;

int main()
{
    int n;
    cin >> n;
    if (n == 1)
    {
        cout << n;
    }
    if (n < 4)
    {
        cout << "NO SOLUTION";
    }
    else
    {
        int x;
        if (n % 2 == 0)
        {
            x = n - 2;
        }
        else
        {
            x = n - 1;
        }

        while (x != 0)
        {
            cout << x << " ";
            x -= 2;
        }

        cout << n << " ";

        x = 1;
        while (x < n)
        {
            cout << x << " ";
            x += 2;
        }
    }
    cout << endl;
}

