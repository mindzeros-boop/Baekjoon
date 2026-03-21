string a = Console.ReadLine();
int k = int.Parse(a);
if(k >= 90)
{
    Console.WriteLine('A');
}
else if (k >= 80)
{
    Console.WriteLine('B');
}
else if ( k >= 70)
{
    Console.WriteLine('C');
}
else if ( k >= 60)
{
    Console.WriteLine('D');
}
else
{
    Console.WriteLine('F');
}