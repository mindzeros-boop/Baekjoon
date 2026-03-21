string[] a = Console.ReadLine().Split(' ');
int[] arr = new int[5];
arr = Array.ConvertAll(a, int.Parse);

int total = 0;

for(int i = 0; i < arr.Length; i++)
{
    total += arr[i]*arr[i];
}

Console.WriteLine(total % 10);