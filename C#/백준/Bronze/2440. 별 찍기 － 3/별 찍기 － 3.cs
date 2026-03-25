int num = int.Parse(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    for (int j = num; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}