string[] a = Console.ReadLine().Split(" ");
int[] arr = new int[2];
arr = Array.ConvertAll(a, int.Parse);

string[] b = Console.ReadLine().Split(" ");
int[] arr2 = new int[arr[0]];
arr2 = Array.ConvertAll(b, int.Parse);


for (int i = 0; i < arr[0]; i++)
{
    if(arr[1] > arr2[i])
    {
        Console.Write(arr2[i] + " ");
    }
}