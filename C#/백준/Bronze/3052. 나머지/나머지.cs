int[] numbers = new int[10];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine()) % 42;
}

Console.WriteLine(numbers.Distinct().Count());