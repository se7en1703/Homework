//Программа поиска наибольшей цифры в двухзначном числе
Console.Clear();
int a = new Random().Next(10, 100);
int b = a / 10;
int c = a % 10;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
if(b > c)
    Console.Write($"Наибольшая цифра в числе {b} ");
else if (b < c)
     Console.Write($"Наибольшая цифра в числе {c} ");
else
    Console.Write("Цифры в числе одинаковые");
