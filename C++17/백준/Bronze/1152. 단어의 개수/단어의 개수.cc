#include <iostream>
using namespace std;

int main()
{
    string a;
    getline(cin,a);
    int cnt=0;
    for(int i = 0; i < a.size(); i++)
    {

        if(a[i] == ' ')
        {
            cnt++;
        }
    }
    if(a[0] == ' ')
    {
        cnt--;
    }
    if(a[a.size() - 1] == ' ')
    {
        cnt--;
    }
    cout << cnt+1;
}
