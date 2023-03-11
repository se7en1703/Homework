// Программа нахождения кратности одного числа другому
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if(a % b == 0)
    Console.WriteLine($"Число {a} кратно числу {b}");
else
    Console.WriteLine($"Число {a} не кратно числу {b},\nостаток от деления равен {a % b}");