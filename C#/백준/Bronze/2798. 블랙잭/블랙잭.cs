string[] a = Console.ReadLine().Split(' ');
int[] num = new int[2];
num = Array.ConvertAll(a, int.Parse);

string[] b = Console.ReadLine().Split(' ');
int[] input = new int[num[0]];
input = Array.ConvertAll(b, int.Parse);

int sum = 0;
int max = 0;

for(int i = 0; i < num[0]; i++)
{
    for(int j = i + 1; j < num[0]; j++)
    {
        for (int k = j + 1; k < num[0]; k++)
        {
            sum = (input[i] + input[j] + input[k]);
            if (sum <= num[1])
            {
                if (sum > max)
                max = sum;
            }
        }
    }
}

Console.WriteLine(max);