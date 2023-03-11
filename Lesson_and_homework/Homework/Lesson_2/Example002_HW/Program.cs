// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Программа выведет Вам третью цифру любого числа");
Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine()!);
string abs = Convert.ToString(a);
if (a < 0)
    {
        if(a > -100)
            Console.WriteLine("Третьей цифры нет");
        else if(a > -1000)
                Console.WriteLine(abs[1]);
        else
                Console.WriteLine(abs[3]);
    }
else if (a > 0)
    {
        if(a < 100)
            Console.WriteLine("Третьей цифры нет");
       else if(a < 1000)
                Console.WriteLine(abs[0]);
        else
                Console.WriteLine(abs[2]);
    }
else
    Console.WriteLine("Зачем вы ввели 0? ");