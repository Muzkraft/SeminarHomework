// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] array = GetArray(4, 5, 0, 10);
PrintArray(array);

Console.WriteLine();
Sort(array);
PrintArray(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] random = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            random[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return random;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1 ; k < array.GetLength(1); k++)
            { 
                if (array[i, k] > array[i, j])
                {
                    int minValue = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = minValue;         
                }    
            }
        }            
    }
    return array;
}
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] array = GetArray(7, 5, 0, 10);
PrintArray(array);

Console.WriteLine();
SumOfRows(array);


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] random = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            random[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return random;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumOfRows(int[,] array)
{
    int minSum = 100;
    int minLine = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        Console.WriteLine($"Строка {i + 1} : {sum}");

        if (sum < minSum)
        {
            minSum = sum;
            minLine = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов {minSum} находится в {minLine + 1} строке");       
}
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] arrayA = GetArray(3, 3, 0, 10);
int[,] arrayB = GetArray(3, 3, 0, 10);
int[,] arrayC = new int[arrayA.GetLength(0), arrayA.GetLength(1)];

PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);

Console.WriteLine();
Multiply(arrayA, arrayB);
PrintArray(arrayC);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] random = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            random[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return random;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Multiply(int[,] arrayA, int[,]arrayB)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(0); j++)
        {
            for (int k = 0 ; k < arrayB.GetLength(1); k++)
            { 
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }            
    }
    return arrayC;
}
*/
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] array = GetArray(2, 2, 2);
PrintArray(array);

static int[,,] GetArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int count = 10;

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = count;
                count = count + new Random().Next(1, 10);     
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");  
            }
            Console.WriteLine();    
        }    
    }   
}
*/
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            Console.Write("{0,3} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

int n = 4;

int[,] array = new int[n, n];

int i = 0;
int j = 0;
int value = 1;

while (n != 0)
{
    int k = 0;
    do 
    { 
        array[i, j++] = value++; 
    } 
    while (++k < n - 1);

    for (k = 0; k < n - 1; k++)
    {
        array[i++, j] = value++;
    }
    for (k = 0; k < n - 1; k++)
    {
        array[i, j--] = value++;
    }
    for (k = 0; k < n - 1; k++)
    {
        array[i--, j] = value++;
    }    
    ++i; ++j; n = n < 2 ? 0 : n - 2;
}

PrintArray(array);
*/
// Отсортировать нечетные столбцы массива по возрастанию.
// Вывести массив изначальный и массив с отсортированными нечетными столбцами

int[,] array = GetArray(5, 6, 0, 10);
PrintArray(array);

Console.WriteLine();
SortCol(array);
PrintArray(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] random = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            random[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return random;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortCol(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j ++)
    {
        if (j % 2 != 0)
        {
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int k = i ; k < array.GetLength(0) - 1; k++)
                {
                    if (array[k + 1, j] < array[i, j])
                    {
                        int maxValue = array[i, j];
                        array[i, j] = array[k + 1, j];
                        array[k + 1, j] = maxValue;         
                    }
                }
            }        
        }            
    }
    return array;
}
