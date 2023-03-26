void Zapol(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2);
}
double MaxEl(double[] array)
{
    double n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > n)
            n = array[i];
    }
    return n;
}
double MinEl(double[] array)
{
    double n = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < n)
            n = array[i];
    }
    return n;
}
double Difference(double a, double b)
{
    double n = a - b;
    return n;
}
Console.Clear();
Console.WriteLine("Сколько элементов в массиве Вы хотите?: ");
int a = int.Parse(Console.ReadLine()!);
double[] array = new double[a];
Zapol(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Максимальный элемент равен: {MaxEl(array)}");
Console.WriteLine($"Минимальный элемент равен: {MinEl(array)}");
Console.WriteLine($"Разница Максимального и минимального элементов равна {Difference(MaxEl(array), MinEl(array))}");