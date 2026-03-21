#include <iostream>

using namespace std;

int main()
{
    string str;
    int cnt[26];
    cin >> str;
    for(int i = 0; i < 26; i++)
    {
        cnt[i] = -1;
    }
    for(int i=0;i<str.size();i++)
    {
        if(cnt[str[i]-'a']==-1){
            cnt[str[i]-'a']=i;
        }
    }
    for(int i=0;i<26;i++){
        cout << cnt[i] << " ";
    }
}
