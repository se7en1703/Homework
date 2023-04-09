void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int SummStrMatrix(int[,] matrix)
{
    int k = 0;
    int b = 1000;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int a = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            a += matrix[i, j];
            k++;
        }
        if (a < b)
            b = a;
    }
    return b;
}
int NumStrMatrix(int[,] matrix)
{
    int b = 1000;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int a = 0;
        int k = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            a += matrix[i, j];
            k++;
        }
        if (a < b)
            b = k;
    }
    return b;
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
while (size[0] == size[1])
{
    Console.Write("Матрица не прямоугольная!!!!\nВведите новый размер: ");
    size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Самая меньшая сумма элементов в {NumStrMatrix(matrix)} строке равна - {SummStrMatrix(matrix)}");