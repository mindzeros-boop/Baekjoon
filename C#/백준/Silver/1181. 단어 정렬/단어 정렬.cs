int T = int.Parse(Console.ReadLine());

List<string> arr = new List<string>();
for(int k = 0; k < T; k++)
{
    arr.Add(Console.ReadLine());
}

arr = arr.Distinct().ToList();
arr = arr.OrderBy(x => x.Length).ThenBy(x => x).ToList();

for(int i = 0; i <arr.Count; i++)
{
    Console.WriteLine(arr[i]);
}