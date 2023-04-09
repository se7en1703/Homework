string f(int a)
{
    if (a == 1)
        return $"1";
    return $"{a} " + f(a - 1);
}
Console.Clear();
Console.Write("Введите начальное число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(a));
