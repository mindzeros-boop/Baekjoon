string input = Console.ReadLine();
string str = "";

for(int i = input.Length - 1; i >= 0; i--)
{
    str += input[i];
}

if( input == str)
{
    Console.WriteLine('1');
}
else
{
    Console.WriteLine('0');
}    