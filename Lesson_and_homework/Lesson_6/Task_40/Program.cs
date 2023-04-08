Console.Clear();
Console.WriteLine("Введите первую сторону: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую сторону: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третью сторону: ");
int c = int.Parse(Console.ReadLine()!);
if (a > b + c || b > a + c || c > a + b)
    Console.WriteLine("Такой треугольник существовать не может");
else
    Console.WriteLine("Ваш треугольник может существовать");