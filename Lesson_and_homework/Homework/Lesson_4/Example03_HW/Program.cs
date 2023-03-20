Console.Clear();
int a = new Random().Next(1,21);
int[] array = new int[a];
for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 31);
Console.WriteLine($"[{string.Join(", ", array)}]");