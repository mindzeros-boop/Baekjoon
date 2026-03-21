string str = Console.ReadLine();
int total = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == 'A' || str[i] == 'B' || str[i] == 'C')
    {
        total += 2;
    }
    else if (str[i] == 'D' || str[i] == 'E' || str[i] == 'F')
    {
        total += 3;
    }
    else if (str[i] == 'G' || str[i] == 'H' || str[i] == 'I')
    {
        total += 4;
    }
    else if (str[i] == 'J' || str[i] == 'K' || str[i] == 'L')
    {
        total += 5;
    }
    else if (str[i] == 'M' || str[i] == 'N' || str[i] == 'O')
    {
        total += 6;
    }
    else if (str[i] == 'P' || str[i] == 'Q' || str[i] == 'R' || str[i] == 'S')
    {
        total += 7;
    }
    else if (str[i] == 'T' || str[i] == 'U' || str[i] == 'V')
    {
        total += 8;
    }
    else
    {
        total += 9;
    }
}
Console.Write(total + str.Length);