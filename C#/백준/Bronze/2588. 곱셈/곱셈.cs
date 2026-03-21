
string n1 = Console.ReadLine();
string n2 = Console.ReadLine();
int a, b, c;
int a1, b1, c1;
a = n1[2] - '0';
b = n1[1] - '0';
c = n1[0] - '0';
a1 = n2[2] - '0';
b1 = n2[1] - '0';
c1 = n2[0] - '0';
int k1 = (c * 100 + b * 10 + a) * a1;
int k2 = (c * 100 + b * 10 + a) * b1;
int k3 = (c * 100 + b * 10 + a) * c1;
Console.WriteLine(k1);
Console.WriteLine(k2);
Console.WriteLine(k3);
Console.WriteLine(k1 + k2*10 + k3*100);