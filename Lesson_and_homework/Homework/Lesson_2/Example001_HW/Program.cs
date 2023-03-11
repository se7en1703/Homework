//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Программа выведет Вам любую цифру трехзначного числа");
Console.WriteLine("Введите любое трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
if (a < 0)
    {
        if(a > -100 || a < -1000)
            Console.WriteLine("Введенное число не трехзначное!!! ");
        else
            {
                int c = (a / 10) % 10;
                Console.WriteLine(Math.Abs(c));
            }
    }
else if (a > 0)
    {
        if(a > 1000 || a < 100)
            Console.WriteLine("Введенное число не трехзначное!!! ");
        else
            {
                int c = (a / 10) % 10;
                Console.WriteLine(c);
            }
    }
else
    Console.WriteLine("Зачем вы ввели 0? ");
// string a = Console.ReadLine();
// int abs = a.Length;
// if (abs == 3)
// {
//     int aI = Convert.ToInt32(a);
//     int c = (aI / 10) % 10;
//     Console.WriteLine(aI);
//     Console.WriteLine(c);
// }
// else
//     Console.WriteLine("Введенное число не трехзначное");