uint f(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m > 0) && (n == 0))
        return f(m - 1, 1);
    else
        return f(m - 1, f(m, n - 1));
}
Console.Clear();
Console.Write("Введите начальное число: ");
uint a = uint.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число: ");
uint b = uint.Parse(Console.ReadLine()!);
Console.WriteLine(f(a, b));