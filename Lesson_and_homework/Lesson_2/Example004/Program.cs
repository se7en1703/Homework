Console.Clear();
int a = new Random().Next(10, 1000);
int b = a / 100;
int c = a % 10;
int d = b * 10 + c;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);