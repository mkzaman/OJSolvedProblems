// 11933 Splitting Numbers.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <cmath>
#include <vector>

using namespace std;

int main()
{
    int n;
    while (cin >> n)
    {
        if (n == 0) 
        {
            return 0;
        }


        int n_bit = log2(n) + 1;

        vector<int> pos;

        for (int i = 0; i < n_bit; i++)
        {
            int temp = n & (1 << i);
            if (temp != 0)
            {
                pos.push_back(i);
            }
        }

        int a=0, b=0;

        for (int i = 0; i < pos.size(); i++)
        {
            if (i % 2 == 0)
            {
                a |= (1 << pos[i]);
            }
            else
            {
                b |= (1 << pos[i]);
            }
        }

        cout << a << " " << b << "\n";
    }

    return 0;
}
