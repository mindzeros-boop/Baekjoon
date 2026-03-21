string[] str1 = Console.ReadLine().Split(" ");
int[] arr1 = new int[str1.Length];
arr1 = Array.ConvertAll(str1, int.Parse);

string[] str2 = Console.ReadLine().Split(" ");
int[] arr2 = new int[str2.Length];
arr2 = Array.ConvertAll(str2, int.Parse);

for(int i=0; i < arr1[0]; i++)
{
    if(arr2[i] < arr1[1])
    {
        Console.Write(arr2[i] + " ");
    }
}