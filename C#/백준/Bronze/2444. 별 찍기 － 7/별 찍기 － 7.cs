int input = int.Parse(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    for (int j = input - 1; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i*2; j++)
    { 
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = 1; i < input; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int j = input*2-i-1; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}