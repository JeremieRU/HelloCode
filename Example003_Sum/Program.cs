int numberA = new Random().Next(1, 10); // 0 1 2 3 4 ... 9
int numberB = new Random().Next(1, 10);
Console.Write(numberA);
Console.Write("+");
Console.Write(numberB);
int result = numberA + numberB;
Console.WriteLine("=");
Console.WriteLine(result);