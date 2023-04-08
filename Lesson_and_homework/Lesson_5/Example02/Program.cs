void SvapElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
}
void MasssPol(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

Console.Clear();
Console.WriteLine("Сколько элементов массива Вы хотите получить?: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];
MasssPol(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
SvapElements(array);
Console.WriteLine($"[{String.Join(", ", array)}]");