void Zapol(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}
void Three(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
            Console.Write($" {array[i]}");
    }
}
void Four(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            Console.Write($" {array[i]} ");
    }
}
string Difference(int[] array)
{
    int a = 0;
    int b = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 1)
            a++;
        else
            b++;
    if (a > b)
        return "NO";
    return "YES";
}
void Sort(int[] array)
{
    int c;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                c = array[j];
                array[j] = array[j + 1];
                array[j + 1] = c;
            }
        }
    }
}
void Nepovtor(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
            array[i + 1] = array[i + 1] + 1;
    }
}
Console.Clear();
Console.WriteLine("Сколько элементов в массиве Вы хотите?: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];
Zapol(array);
Sort(array);
Nepovtor(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
Three(array);
Console.WriteLine();
Four(array);
Console.WriteLine();
Console.WriteLine($"Может ли Вася расчитывать на 4? - {Difference(array)}");