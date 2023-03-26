void Zapol(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
int Schet(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            n++;
    }
    return n;
}
Console.Clear();
Console.WriteLine("Сколько элементов в массиве Вы хотите?: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];
Zapol(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"В Вашем массиве {Schet(array)} четных элементов");