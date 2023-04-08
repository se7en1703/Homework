Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
string result = string.Empty;
while (n > 0)
{
    result = Convert.ToString(n % 2) + result;
    n /= 2;
}
Console.WriteLine(result);