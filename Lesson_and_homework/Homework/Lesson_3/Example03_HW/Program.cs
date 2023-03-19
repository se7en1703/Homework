// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string b = Convert.ToString(a);
string z = new string(b.Reverse().ToArray());
if (b == z)
    Console.WriteLine($"Число {a} - является полиндромом");
else
    Console.WriteLine($"Число {a} - не является полиндромом");
