int num = int.Parse(Console.ReadLine());
for(int i = 1; i <= num; i++)
{
    for (int j = num - i; j > 0; j--)
    {
        Console.Write(" ");
    }
    for(int j = 0; j < i; j++)
    Console.Write("*");
    Console.WriteLine();
}