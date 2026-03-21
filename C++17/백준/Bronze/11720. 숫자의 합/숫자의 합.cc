#include <iostream>

using namespace std;

int main()
{
    int cnt, total = 0;
    string number;
    cin >> cnt;
    cin >> number;
    for(int i = 0; i < cnt; i++)
    {
        total += number[i] - '0';
    }
    cout << total;
}
