// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int i = 1;
double s = 0;
string n = "";
while(i <= a)
{
    s = Math.Pow(i, 3);
    Convert.ToString(s);
    n = n + s +", ";
    i++;
}
int len = n.Length;
n = n.Remove(len - 2) + ".";
Console.WriteLine($"{n}");
