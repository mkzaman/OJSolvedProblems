// A. Boy or Girl.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

//define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <string>
#include <set>
#include <cstring>

using namespace std;
int main()
{
    string s;
    cin >> s;
    set<char> st;
    for (int i = 0; i < s.size(); i++)
    {
        st.insert(s[i]);
    }

    if (st.size() % 2 == 0)
    {
        cout << "CHAT WITH HER!\n";
    }
    else
    {
        cout << "IGNORE HIM!\n";
    }
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
