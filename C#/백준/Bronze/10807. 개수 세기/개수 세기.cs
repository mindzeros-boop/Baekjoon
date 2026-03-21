int num = int.Parse(Console.ReadLine());
string[] a = Console.ReadLine().Split(" ");
int[] arr = new int[num];
arr = Array.ConvertAll(a, int.Parse);
int ca = int.Parse(Console.ReadLine());
int cnt = 0;
for(int i = 0; i < num; i++)
{
    if(arr[i] ==  ca)
    {
       cnt++;
    }
}
Console.WriteLine(cnt);