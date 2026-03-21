using System.Text;

namespace _2026_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder num = new StringBuilder();

            for (int i = 0; i < a; i++)
            {
                num.Append(i + 1 + "\n");
            }
            Console.WriteLine(num);
        }
    }
}