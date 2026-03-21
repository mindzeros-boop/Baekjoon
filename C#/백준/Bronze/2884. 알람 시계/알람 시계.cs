string[] str = Console.ReadLine().Split();
int[] time =  new int[str.Length];
time=Array.ConvertAll(str, int.Parse);

if (time[1] >= 45)
{
    Console.Write(time[0] + " ");
    Console.Write(time[1] -45);
}
else
{
    if (time[0] == 0)
    {
        Console.Write(23 + " ");
        Console.Write(time[1] + 15);
    }
    else
    {
        Console.Write(time[0] - 1 + " ");
        Console.Write(time[1] + 15);
    }
}
