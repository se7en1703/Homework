// Программа нахождения кратности одного числа другому
Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 161 == 0)
    Console.WriteLine($"Число {a} кратно числам 7 и 23");
else
    Console.WriteLine($"Число {a} не кратно числам 7 и 23");
