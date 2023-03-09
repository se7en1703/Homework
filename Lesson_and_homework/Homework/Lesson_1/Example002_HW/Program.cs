// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число ");
int c = int.Parse(Console.ReadLine()!);
int d = a;
if (a == b & a == c) 
            Console.Write($"Числа {a}, {b}, {c} являются одинаковыми");
else if (a == b)
    d = a;
else if (a < b)
    d = b;
if (c > d)
    d = c;
Console.WriteLine($"Число {d} является наибольшим");
