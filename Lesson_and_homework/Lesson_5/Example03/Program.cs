int Schet(int[] array)
{
    int sumn = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 && array[i] >= 10)
            sumn++;
    }
    return sumn;
}
Console.Clear();
int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"{Schet(array)}");