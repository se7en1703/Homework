int f(int a, int b)
{
    if (b == a)
        return a;
    return f(a, b - 1) + b;
}
Console.Clear();
Console.Write("Введите начальное число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(a, b));