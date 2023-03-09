Console.Clear();
Console.WriteLine("Введите первое число ");
string a = Console.ReadLine();
int aInt = Convert.ToInt32(a);
Console.WriteLine("Введите второе число ");
string b = Console.ReadLine();
int bInt = Convert.ToInt32(b);
if (aInt > bInt) 
{ Console.Write("Наибольшее число ");
           Console.WriteLine(aInt);
           Console.Write("Наименьшее число ");
           Console.WriteLine(bInt);
}
else 
{ Console.Write("Наибольшее число ");
     Console.WriteLine(bInt);
     Console.Write("Наименьшее число ");
     Console.WriteLine(aInt);
}
