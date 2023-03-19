Console.Clear();
Console.WriteLine("Введите сколько элементов массива необходимо?: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];
for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 31);
Console.WriteLine($"[{string.Join(", ", array)}]");