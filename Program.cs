// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Array = GetArray(3, 4, -10, 10);
// PrintArray(Array);
// Console.WriteLine();

// double[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble() * 10;
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write(string.Format("  {0:F2}",  Array[i, j]));
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2


// Console.WriteLine("Строка: ");
// int rows = int.Parse(Console.ReadLine()!) - 1;

// Console.WriteLine("Столбец: ");
// int colums = int.Parse(Console.ReadLine()!) - 1;

// int[,] Array = GetArray(3, 3, 0, 10);
// PrintArray(Array);

// if (rows < 0 | rows > Array.GetLength(0) - 1 | colums < 0 | colums > Array.GetLength(1) - 1)
// {
//     Console.WriteLine("Элемент не существует");
// }
// else
// {
//     Console.WriteLine($"Значение элемента массива =  {Array[rows, colums]}");
// }

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"  {Array[i, j]}");
        }
        Console.WriteLine();
    }
}

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Array = GetArray(3, 3, 0, 10);
PrintArray(Array);

for (int j = 0; j < Array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        sum += Array[i, j];
    }
    Console.Write($"{ sum / Array.GetLength(0)}; ");
}