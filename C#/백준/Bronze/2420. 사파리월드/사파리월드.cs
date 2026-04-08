using System.Diagnostics;
using System.Numerics;
namespace _2026_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            BigInteger[] arr = new BigInteger[2];
            arr = Array.ConvertAll(a, BigInteger.Parse);
            Array.Sort(arr);

            Console.WriteLine(arr[1] - arr[0]);
        }
    }
}