using System.Numerics;
using System.Security.Authentication;
namespace _2026_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] input2 = input.Split(' ');

            BigInteger cash = BigInteger.Parse(input2[0]);
            BigInteger nanugi = BigInteger.Parse(input2[1]);
            
            Console.WriteLine(cash / nanugi);
            Console.WriteLine(cash % nanugi);
        }
    }
}