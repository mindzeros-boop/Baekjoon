while (true)
{
    string[] tmp = Console.ReadLine().Split(' ');
    int[] input = new int[2];
    input = Array.ConvertAll(tmp, int.Parse);
    if (input[0] == 0 && input[1] == 0)
    {
        break;
    }
    else if (input[0] > input[1])
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}