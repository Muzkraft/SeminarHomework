// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Обозначте размер массива: ");
double size = double.Parse(Console.ReadLine()!);

double[] array = new double[size];

for (double i = 0; i < size; i++)
{
    Console.WriteLine($"Введите значение элемента массива {i + 1}");
    array[i] = double.Parse(Console.ReadLine()!);
}
Console.WriteLine(String.Join(" ", array));

double count = 0;
for (double i = 0; i < size; i ++)
{
    if(array[i] > 0)
    {
        count ++;
    }
}
Console.WriteLine($"В заданном массиве {count} элементов больше нуля.");
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите координату b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату k2: ");
double k2 = double.Parse(Console.ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
double y2 = k2 * x + b2;

if (y == y2)
{
    Console.Write($"Координаты точки пересечения двух прямых -> [{x}; {y}]");
}
else
{
    Console.Write("Прямые не пересекаются");
}