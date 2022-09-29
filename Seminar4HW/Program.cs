// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
double result = 0;
Console.Write($"Натуральная степень числа {A} = {Stepen(result)}");

double Stepen(double result)
{
    
    result = Math.Pow(A, B);
    return result;
}
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Write("Введите число : ");
int A = int.Parse(Console.ReadLine()!);
int Sum = A; 
Console.Write($"Сумма цифр в числе {A} = {GetSum(Sum)}");

int GetSum(int Sum)
{
    if (Sum < 10)
    return Sum;
    
    int digit = Sum % 10;
    int tempSum = Sum / 10;
    return digit + GetSum(tempSum);
}
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

int[] array =  RandomArray();
Console.WriteLine($"[{String.Join(",", array)}]");

int[] RandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1000);
    }
    return array;
}
