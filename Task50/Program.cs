/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using System;
using static System.Console;

Clear();

Write("Введите индекс строки - ");
int rows = int.Parse(ReadLine());

Write("Введите индекс столбца - ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(5, 5, -10, 10);
PrintArray(array);

if (rows < array.GetLength(0) && columns < array.GetLength(1))
    Write($"Элемент с индексом {rows}{columns} --> {array[rows, columns]}");
else Write($"{rows}{columns} -> Такого числа в массиве нет");

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
