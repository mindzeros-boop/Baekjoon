int n = int.Parse(Console.ReadLine());

string[] a = Console.ReadLine().Split();
int[] size = new int[6];
size = Array.ConvertAll(a, int.Parse);

string[] b = Console.ReadLine().Split();
int[] bundle = new int[2];
bundle = Array.ConvertAll(b, int.Parse);

int output1 = 0;
for (int i = 0; i < 6; i++)
{
    if (size[i] > 0)
    {
        output1 += (size[i] + bundle[0] - 1) / bundle[0];
    }
}

int output2 = n / bundle[1];

int output3 = n % bundle[1];

Console.WriteLine(output1);
Console.WriteLine(output2 + " " + output3);