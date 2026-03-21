string a = Console.ReadLine();
string[] arr = a.Split(" ");
int n1 = int.Parse(arr[0]);
int n2 = int.Parse(arr[1]);
if(n1 > n2)
{
    Console.WriteLine('>');
}
else if (n1 < n2)
{
    Console.WriteLine('<');
}
else
{
    Console.WriteLine("==");
}