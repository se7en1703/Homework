//Программа для поиска квадрата числа
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (b * b == a)
    Console.WriteLine($"Число {a} является квадратом числа {b}");
else
    Console.WriteLine($"Число {a} не является квадратом числа {b}");