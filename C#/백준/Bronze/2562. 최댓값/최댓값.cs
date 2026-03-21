int[] str = new int[9];
for (int i = 0; i < 9; i++)
{
    str[i] = int.Parse(Console.ReadLine());
}

int fir = str[0];

for(int i = 0; i < 9;i++)
{
    if (fir < str[i])
    {
        fir = str[i];
    }
}

int las = 0;

for(int i =0; i < 9;i++)
{
    if(str[i] ==  fir)
    {
        las = i;
    }
}

Console.WriteLine(fir);
Console.Write(las + 1);