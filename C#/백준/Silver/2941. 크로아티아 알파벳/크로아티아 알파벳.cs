string input = Console.ReadLine(); // 너무 어려워서 Ai 도움좀 받음
int point = 0;

for (int i = 0; i < input.Length; i++)
{
    if (i < input.Length - 1)
    {
        if (input[i] == 'c' && (input[i + 1] == '=' || input[i + 1] == '-'))
        {
            i++;
        }
        else if (input[i] == 'd')
        {
            if (i < input.Length - 2 && input[i + 1] == 'z' && input[i + 2] == '=')
            {
                i += 2;
            }
            else if (input[i + 1] == '-')
                i++;
        }
        else if ((input[i] == 'l' || input[i] == 'n')&& input[i + 1] == 'j')
        {
            i++;
        }
        else if ((input[i] == 's' || input[i] == 'z') && input[i +1] == '=')
        {
            i++;   
        }
    }
        
    point++;
}

Console.WriteLine(point);