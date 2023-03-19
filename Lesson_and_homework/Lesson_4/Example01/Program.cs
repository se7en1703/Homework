Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int i = 0;
while(a > 0)
{
    a = a / 10;
    i++;
}
Console.WriteLine(i);
