/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;
using static System.Console;

Clear();

Write("введите количество строк - ");
int rows = int.Parse(ReadLine());

Write("введите количество столбцов - ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Write($"среднее арифметическое каждого столбца --> ");
PrintArray1(SrAr(array));

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

double[] SrAr (int [,] inArray)
{
   double[] Result = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i,j];
        }
        Result [j] = sum/inArray.GetLength(0);
    }
    return Result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

void PrintArray1(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($" {inArray[i]} ");
    }
    Console.WriteLine();
}
