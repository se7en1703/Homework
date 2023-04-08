int SumPositiveNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sum += array[i];
    return sum;
}
int SumNegativeNumbers(int[] array)
{
    int sumn = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sumn += array[i];
    return sumn;
}
Console.Clear();
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine(SumPositiveNumbers(array));
Console.WriteLine(SumNegativeNumbers(array));
