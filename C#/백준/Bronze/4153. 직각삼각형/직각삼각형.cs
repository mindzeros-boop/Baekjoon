for (; ; )
{
    string[] a = Console.ReadLine().Split();
    int[] arr = new int[a.Length];
    arr = Array.ConvertAll(a, int.Parse);
    Array.Sort(arr);

    if (arr[0] == 0 && arr[1] == 0 && arr[2] == 0)
    {
        break;
    }

    int A = arr[0];
    int B = arr[1];
    int C = arr[2];

    if (A*A +  B*B == C*C)
    {
        Console.WriteLine("right");
    }
    else
    {
        Console.WriteLine("wrong");
    }
}