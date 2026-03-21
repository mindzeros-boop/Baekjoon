using System.Numerics;

string str = Console.ReadLine();
str=str.ToUpper();
int[] cnt = new int[127];

for(int i = 0; i < str.Length; i++)
{
    cnt[str[i]]++;
}

int max = cnt[0];

for (int i = 0; i < cnt.Length; i++)
{
    if (max < cnt[i])
    {
        max = cnt[i];
    }
}

int[] arr = new int[cnt.Length];

for (int i = 0; i <  cnt.Length; i++)
{
    arr[i] += cnt[i];
}

int cnt2 = 0;
char ans='a';
for(char i = 'A'; i <='Z'; i++)
{
    if (max == cnt[i])
    {
        ans = i;
        cnt2++;
        if (cnt2 >= 2)
        {
            Console.WriteLine('?');
            break;
        }
    }
}
if (cnt2 == 1)
{ 
   Console.WriteLine(ans.ToString());
}
