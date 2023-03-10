/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using System;
using static System.Console;

Clear();

Write("введите количество строк - ");
int rows = int.Parse(ReadLine());

Write("введите количество столбцов - ");
int columns = int.Parse(ReadLine());

double[,] array = GetArray(rows, columns, -100, 100);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)

{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           /// result[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) / 10;
            result[i, j] = new Random().NextDouble()*(maxValue - minValue)+ minValue;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           Write($"{inArray[i, j] = Math.Round(inArray[i, j],2)} "); //
        }
        WriteLine();
    }
}
