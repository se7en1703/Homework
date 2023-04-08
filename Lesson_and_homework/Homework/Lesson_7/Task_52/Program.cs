void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // От 1 до 10
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");

        Console.WriteLine();
    }
}
void Arifmet(int[,] matrix)
{
    double sr = 0;
    double z = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sr = sr + matrix[i, j];
            z++;
        }
        sr = Math.Round((sr / z), 2);
        if (j == matrix.GetLength(1) - 1)
            Console.Write($"{sr}. \t");
        else
            Console.Write($"{sr}; \t");
        sr = 0;
        z = 0;
    }
}
Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
Arifmet(matrix);