using System.Numerics;

int cost = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int total = 0;
for(int i = 0; i <n ; i++)
{
    string[] str = Console.ReadLine().Split(' ');
    int[] arr = new int[2];
    arr = Array.ConvertAll(str, int.Parse);
    total += arr[0] * arr[1];
}

if(cost == total)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}