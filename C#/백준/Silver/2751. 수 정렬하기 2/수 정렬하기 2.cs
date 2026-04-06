using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
{
    int num = int.Parse(sr.ReadLine());
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
    {
        arr[i] = int.Parse(sr.ReadLine());
        Math.Abs(arr[i]);
    }
    Array.Sort(arr);

    for (int i = 0; i < num; i++)
    {
        sw.WriteLine(arr[i]);
    }
}