string[] str = Console.ReadLine().Split(" ");
int[] arr =  new int[str.Length];
arr = Array.ConvertAll(str, int.Parse);

int[] output = new int[arr[0]];

for(int i = 0; i < arr[0]; i++)
{
    output[i] = i + 1;
}

int tmp = 0;

for(int i = 0; i < arr[1]; i++)
{
    string[] str1 = Console.ReadLine().Split(" ");
    int[] input = new int[str1.Length];
    input = Array.ConvertAll(str1, int.Parse);

    tmp = output[input[0]-1];
    output[input[0]-1] = output[input[1] - 1];
    output[input[1]-1] = tmp;
}

for(int i = 0; i < arr[0]; i++)
{
    Console.Write(output[i] + " ");
}