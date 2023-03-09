// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
while (a <= 0)
{
    Console.Write("Ваше число меньше единицы!\nВведите число: ");
    a = int.Parse(Console.ReadLine()!);
}
for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0)
     Console.Write($" {i} ");
}
