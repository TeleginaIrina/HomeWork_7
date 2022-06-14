// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
var arr = new int[3, 5];
Random randomNumber = new Random();

void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(1, 100);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void AverageSum()
{
    double result = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            result = result + arr[i, j];
        }
        Console.WriteLine($"Средняя арифметическая {j + 1} столбца = {result / arr.GetLength(0):F2}"); // :F2 - Помогает откинуть лишние цифры после запятой
    }
}

Console.WriteLine("Даны столбцы: ");
FillArray();
PrintArray();
Console.WriteLine("========================");
AverageSum();
