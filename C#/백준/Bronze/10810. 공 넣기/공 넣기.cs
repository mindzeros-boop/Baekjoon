string[] str = Console.ReadLine().Split();
int[] arr = new int[str.Length];
arr = Array.ConvertAll(str, int.Parse);

int[] input = new int[arr[0]]; 

for(int i =0; i < arr[0]; i++)
{
    input[i] = 0;
}

for (int i = 0; i < arr[1]; i++)
{
    string[] str1 = Console.ReadLine().Split(" ");
    int[] cnt = new int[3];
    cnt = Array.ConvertAll(str1, int.Parse);

    for (int j = cnt[0]-1; j <= cnt[1]-1; j++)
    {
        input[j] = cnt[2];
    }
}

for(int i = 0; i < arr[0]; i++)
{
    Console.Write(input[i] + " ");
}