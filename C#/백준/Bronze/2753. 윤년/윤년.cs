string year = Console.ReadLine();
int num = int.Parse(year);

if(num % 4 == 0 && num % 100 != 0 || num % 400 == 0)
{
    Console.WriteLine('1');
}
else
{
    Console.WriteLine('0');
}