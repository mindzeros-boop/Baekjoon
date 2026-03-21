int fir = int.Parse(Console.ReadLine());
string[] str = Console.ReadLine().Split(" ");
int[] arr = new int[str.Length];
arr = Array.ConvertAll(str, int.Parse);

int max, min ;
max = min = arr[0];
for(int i = 0; i < arr.Length; i++)
{
    if(max < arr[i])
    {
        max = arr[i];
    }
    if(min > arr[i])
    {
        min = arr[i];
    }
}

Console.WriteLine(min + " " + max);