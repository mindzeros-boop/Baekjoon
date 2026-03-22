int[] table = new int[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',};
int[] point = new int[10];

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int tmp = a * b * c;
string abc = tmp.ToString();

for(int i = 0; i < abc.Length; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (abc[i] == table[j])
        {
            point[j]++;
        }
    }
}
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(point[i]);
}