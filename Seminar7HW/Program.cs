// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n, 0, 100);
PrintArray(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }        
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.WriteLine("Место в строке: ");
int i = int.Parse(Console.ReadLine()!);

Console.WriteLine("Место в столбце: ");
int j = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] array = GetArray(5, 5, 0, 100);
PrintArray(array);
Console.WriteLine();
PrintElement(array, i, j);

void PrintElement(int[,] array, int i, int j)
{
    if(i <= array.GetLength(0) && j <= array.GetLength(1))
    {
        Console.WriteLine($"Элемент с индексами i = {i}, j = {j} -> {array[i, j]}");    
    }

    else
    {
        Console.WriteLine($"Элемента с индексами i = {i}, j = {j} в массиве не существует.");
    }
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }        
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

Console.WriteLine();

double[] result = new double[n];
SredneeArif(result);


void SredneeArif(double[] result)
{
    
    for (int j = 0; j < m; j ++)
    {
        for (int i = 0; i < n; i ++)
        {
            result[i] += array[j, i];    
        }   
    }
    
    foreach (double elem in result)
    {
        Console.Write($"{elem / n}; ");
    }   
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] random = new int[rows, columns];
    
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
            random[i, j] = new Random().Next(minValue, maxValue);
        }        
    }
    return random;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
