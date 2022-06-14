
// 47. Показать двумерный массив размером m×n заполненный случайными вещественными числами

Console.Clear();

double[,] array = new double[4, 4];
Random number = new Random();

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(number.NextDouble() * 100, 2);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

FillArray();
PrintArray();
