int num = int.Parse(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    string[] a = Console.ReadLine().Split();
    int[] input = new int[2];
    input = Array.ConvertAll(a, int.Parse);
    Console.WriteLine($"Case #{i + 1}: {input[0]} + {input[1]} = {input[0] + input[1]}");
}
