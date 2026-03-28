int num = int.Parse(Console.ReadLine());
for(int k = 0; k < num; k++)
{
    string[] tmp = Console.ReadLine().Split();
    int[] arr = new int[3];
    arr = Array.ConvertAll(tmp, int.Parse);
    int x = 0;
    int y = 0;
    int H = arr[0];
    int W = arr[1];
    int N = arr[2];

    if (N % H != 0)
    {
        y = N % H;
        x = (N / H) + 1;
    }
    else
    {
        y = H;
        x = N / H;
    }

    Console.WriteLine(y *100 + x);
}