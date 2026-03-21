string[] test = Console.ReadLine().Split(' ');
int[] str = new int[8];
str = Array.ConvertAll(test, int.Parse);

int[] ascending = new int[8];
for(int i = 0; i < 8; i++)
{
    ascending[i] = str[0] +i;
}

int[] descending = new int[8];
for (int i = 0; i < 8; i++)
{
    descending[i] = str[0] -i;
}

string result1 = string.Join(" ", str.Select(x => x.ToString()));
string result2 = string.Join(" ", ascending.Select(x => x.ToString()));
string result3 = string.Join(" ", descending.Select(x => x.ToString()));

for (int i = 0; i < 8; i++)
{
    if (result1 == result2)
    {
        Console.Write("ascending");
        break;
    }
    else if (result1 == result3)
    {
        Console.Write("descending");
        break;
    }
    else
    {
        Console.Write("mixed");
        break;
    }
}