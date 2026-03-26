string[] tmp = Console.ReadLine().Split(' ');
int[] arr = new int[tmp.Length];
arr = Array.ConvertAll(tmp, int.Parse);

int total = arr[0];

for(int i = 0; i < arr[1]; i++)
{
    total += arr[0];
}

Console.WriteLine(total);