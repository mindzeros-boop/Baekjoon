using System.Security.Cryptography;

string[] str = Console.ReadLine().Split();
int[] dice =  new int[str.Length];
dice=Array.ConvertAll(str, int.Parse);

if (dice[0] == dice[1] && dice[0] == dice[2])
{
    Console.WriteLine(10000 + dice[0] * 1000);
}
else if (dice[0] == dice[1])
{
    Console.WriteLine(1000 + dice[1] * 100);
}
else if (dice[0] == dice[2])
{
    Console.WriteLine(1000 + dice[0] * 100);
}
else if (dice[1] == dice[2])
{
    Console.WriteLine(1000 + dice[2] * 100);
}
else
{
    if (dice[0] > dice[1] && dice[0] > dice[2])
    {
        Console.WriteLine(dice[0] * 100);
    }
    else if (dice[1] > dice[2] && dice[1] > dice[0])
    {
        Console.WriteLine(dice[1] * 100);
    }
    else
    {
        Console.WriteLine(dice[2] * 100);
    }
}