int num = int.Parse(Console.ReadLine());
for(int i = 0; i < num; i++)
{
    string[] str = Console.ReadLine().Split(' ');
    int[] plus  = new int[num];
    plus = Array.ConvertAll(str, int.Parse);

    Console.WriteLine(plus[0] + plus[1]);
}