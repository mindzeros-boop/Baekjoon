int num = int.Parse(Console.ReadLine());
for(int i = 0; i < num; i++)
{
    int point = 0;
    int output = 0;
    string input = Console.ReadLine();
    int[] arr = new int[input.Length];
    for(int j = 0; j < input.Length; j++)
    {
        if (input[j] == 'O')
        {
            point += 1;
            arr[j] += point;
        }
        else if (input[j] == 'X')
        {   
            point = 0;
        }
    }

    for(int j = 0; j < input.Length; j++)
        output += arr[j];
    Console.WriteLine(output);
}