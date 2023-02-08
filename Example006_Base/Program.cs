int a = new Random().Next(1, 11);
Console.Write("a=");
Console.WriteLine(a);

int b = new Random().Next(1, 11);
Console.Write("b=");
Console.WriteLine(b);

int c = new Random().Next(1, 11);
Console.Write("c=");
Console.WriteLine(c);

int d = new Random().Next(1, 11);
Console.Write("d=");
Console.WriteLine(d);

int e = new Random().Next(1, 11);
Console.Write("e=");
Console.WriteLine(e);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("maximum = ");
Console.WriteLine(max);
