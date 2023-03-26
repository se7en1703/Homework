void Zapol(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}
int Schet(int[] array)
{
    int n = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        n = n + array[i];
    }
    return n;
}
Console.Clear();
Console.WriteLine("Сколько элементов в массиве Вы хотите?: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];
Zapol(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($" Cумма элементов, стоящих на нечётных позициях равна {Schet(array)}");