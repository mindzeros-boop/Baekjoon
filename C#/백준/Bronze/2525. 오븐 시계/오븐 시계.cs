string[] str = Console.ReadLine().Split();
int[] time =  new int[str.Length];
time=Array.ConvertAll(str, int.Parse);

string a = Console.ReadLine();
int need = int.Parse(a);
int h = time[0];
int m = time[1];
int tm = m + need;
if ((tm) < 60)
{
    Console.Write($"{h} ");
    Console.Write($"{tm}");
}
else
{
    int th = h + ((tm) / 60);

    if (th/24 < 1)
    {
        Console.Write($"{th} ");
    }
    else
    {
        Console.Write($"{th%24} ");
    }
    Console.Write($"{(tm) % 60}");
}