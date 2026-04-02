using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
{

    int num = int.Parse(sr.ReadLine());
    int[] arr = new int[10001];

    for (int i = 0; i < num; i++)
    {
        int input = int.Parse(sr.ReadLine());
        arr[input]++;
    }

    for (int i = 1; i <= 10000; i++)
    {
        for (int j = 0; j < arr[i]; j++)
        {
            sw.WriteLine(i);
        }
    }
}