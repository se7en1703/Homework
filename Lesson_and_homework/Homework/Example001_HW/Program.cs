// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
if (a > b) 
     Console.Write($"Наибольшее число {a}, наименьшее число {b}");       
else if (b > a)
     Console.Write($"Наибольшее число {b}, наименьшее число {a}");
else
      Console.Write("Введенные числа равны");