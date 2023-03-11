// Напишите программу, которая на вход принимает два числа и проверяет, является ли 
// первое число квадратом второго.
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (b == a * a)
    Console.Write($"Число {a} является квадратом числа {b}");
else 
    Console.Write($"Число {a} не является квадратом числа {b}");
