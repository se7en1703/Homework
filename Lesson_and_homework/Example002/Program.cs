Console.Clear();
Console.WriteLine("Введите первое число ");
string a = Console.ReadLine();
double adouble = Convert.Todouble32(a);
Console.WriteLine("Введите второе число ");
string b = Console.ReadLine();
double bdouble = Convert.Todouble32(b);
if (adouble > bdouble) 
{ Console.Write("Наибольшее число ");
           Console.Write(adouble);
}
else 
{ Console.Write("Наибольшее число ");
     Console.WriteLine(bdouble);
}