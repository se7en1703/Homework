int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
int n = array.Length;
Console.WriteLine("Введите число от 1 до 9: ");
int a = int.Parse(Console.ReadLine()!);
int index = 0;
while(index < n)
{
    if(array[index] == a)
    {
    Console.WriteLine(index);
    break;
    }
    index++;
}