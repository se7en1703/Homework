// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine("Введите координату X(1): ");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y(1): ");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z(1): ");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X(2): ");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y(2): ");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z(2): ");
double z2 = double.Parse(Console.ReadLine()!);
double s = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между Вашими точками равно {Math.Round(s, 2)}");
