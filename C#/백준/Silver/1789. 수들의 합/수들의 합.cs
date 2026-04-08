long S = long.Parse(Console.ReadLine());
long sum = 0;
long i = 0;
while(true)
{
    i++;
    sum += i;
    if (sum == S)
    {
        Console.WriteLine(i);
        break;
    }
    else if (sum > S)
    {
        Console.WriteLine(i - 1);
        break;
    }
}