Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
if (a > b) 
{ Console.Write("Наибольшее число ");
           Console.WriteLine(a);
           Console.Write("Наименьшее число ");
           Console.WriteLine(b);
}
else 
{ Console.Write("Наибольшее число ");
     Console.WriteLine(b);
     Console.Write("Наименьшее число ");
     Console.WriteLine(a);
}
