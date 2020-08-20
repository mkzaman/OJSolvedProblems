#define _CRT_SECURE_NO_WARNINGS

#include<vector>
#include<string>
#include<map>
#include<iostream>

using namespace std;

int main()
{
    //freopen("input.txt", "r", stdin);
    //freopen("output.txt", "w", stdout);

    int cases;
    cin >> cases;
    vector<int>result;
    vector<int>tracker(1000000, 0);
    map<int, int> m;
    while (cases--)
    {
        int a, b;
        cin >> a >> b;
        if (a == 1) {
            if (m[b] != 0) {
                tracker[m[b]]--;
            }
            m[b]++;
            tracker[m[b]]++;
        }
        else if (a == 2) {
            if (m[b] == 0) {
                continue;
            }
            tracker[m[b]]--;
            m[b]--;
            tracker[m[b]]++;
        }
        else if (a == 3) {
            if (b > 100000 || tracker[b] == 0) {
                cout << 0 << endl;
            }
            else {
                cout << 1 << endl;
            }
        }
    }
    return 0;
}