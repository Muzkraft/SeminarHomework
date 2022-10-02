// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int count = 0;
int[] array = RandomArray(5);
Console.WriteLine(string.Join(" ", array));
        
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] % 2 == 0)
    {
        count++;
    }
            
}
Console.Write($"В данном массиве количество четных чисел равняется {count}");

int[] RandomArray(int size)
{
    int[] Rarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Rarray[i] = new Random().Next(99, 1000);
    }
    return Rarray;
}
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int Sum = 0;
int[] array = RandomArray(5);
Console.WriteLine(string.Join(" ", array));
        
for (int i = 0; i < array.Length; i++)
{
    
    if (i % 2 == 1)
    {
        Sum += array[i] ;
    }
            
}
Console.Write($"Сумма элементов стоящих на нечетных позициях равняется {Sum}");

int[] RandomArray(int size)
{
    int[] Rarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Rarray[i] = new Random().Next(0, 1000);
    }
    return Rarray;
}
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] array = RandomArray(5);
double minValue = array[0];
double maxValue = array[0];
Console.WriteLine(string.Join(" ", array));
        
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] < minValue)
    {
        minValue = array[i];
    }
}

for (int j = 0; j < array.Length; j++)
{    
    if (array[j] > maxValue)
    {
        maxValue = array[j];
    }        
}

Console.Write($"Разность максимального и минимального элемента массива равна {maxValue - minValue}");

double[] RandomArray(int size)
{
    double[] Rarray = new double[size];
    for (int i = 0; i < size; i++)
    {
        Rarray[i] = new Random().Next(0, 100);
    }
    return Rarray;
}