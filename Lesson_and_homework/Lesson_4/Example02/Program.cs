Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!), count = 1, fac = 1;
while(count <= a)
{
    fac = fac * count;
    count++;
}
Console.WriteLine(fac);
