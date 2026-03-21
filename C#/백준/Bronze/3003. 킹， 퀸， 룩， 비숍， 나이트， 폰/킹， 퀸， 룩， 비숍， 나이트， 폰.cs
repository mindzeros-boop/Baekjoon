
int[] a = new int[6];
int[] b = new int[] { 1, 1, 2, 2, 2, 8};
string[] temp = Console.ReadLine().Split(" ");
a = Array.ConvertAll(temp, int.Parse);
for (int i = 0; i < 6; i++)
{
    Console.Write(b[i] - a[i] + " ");
}    