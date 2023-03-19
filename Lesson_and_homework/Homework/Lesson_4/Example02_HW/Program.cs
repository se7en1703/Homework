Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("В какую степень его возвети?");
int b = int.Parse(Console.ReadLine()!);
int z = 1;
for(int i = 0; i < b; i++)
    z *= a;
Console.WriteLine(z);