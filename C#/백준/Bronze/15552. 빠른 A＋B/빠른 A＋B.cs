using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
{
    int num = int.Parse(sr.ReadLine());
    for (int i = 0; i < num; i++)
    {
        string[] a = sr.ReadLine().Split();
        int[] arr = new int[2];
        arr = Array.ConvertAll(a, int.Parse);

        sw.WriteLine(arr[0] + arr[1]);
    }
}