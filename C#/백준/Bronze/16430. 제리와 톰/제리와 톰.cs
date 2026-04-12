string[] tmp = Console.ReadLine().Split(' ');
int[] arr = new int[tmp.Length];
arr = Array.ConvertAll(tmp, int.Parse);

int a = arr[0];
int b = arr[1];

Console.WriteLine(arr[1] - arr[0] + " " + arr[1]);