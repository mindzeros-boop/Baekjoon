while (true)
{
    string input = Console.ReadLine();
    
    if (input == null)
        break;
    
    string[] output = input.Split();
    int a = int.Parse(output[0]);
    int b = int.Parse(output[1]);
    
    Console.WriteLine(a + b);
}