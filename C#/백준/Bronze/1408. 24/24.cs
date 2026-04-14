string[] tmp1 = Console.ReadLine().Split(':');
int[] t1 = new int[tmp1.Length];
t1 = Array.ConvertAll(tmp1, int.Parse);

string[] tmp2 = Console.ReadLine().Split(':');
int[] t2 = new int[tmp2.Length];
t2 = Array.ConvertAll(tmp2, int.Parse);

int[] output = new int[tmp2.Length];

output[2] = t2[2] - t1[2];
output[1] = t2[1] - t1[1];
output[0] = t2[0] - t1[0];
if (output[2] < 0)
{
    output[1]--;
    output[2] += 60;
}

if (output[1] < 0)
{
    output[1] += 60;
    output[0]--;
}

if (output[0] < 0)
{
    output[0] += 24;
}

string a = string.Format("{0:D2}", output[0]);
string b = string.Format("{0:D2}", output[1]);
string c = string.Format("{0:D2}", output[2]);

Console.WriteLine(a + ":" + b + ":" + c);