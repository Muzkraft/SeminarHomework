// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int mun = 0;
int num2 = num;

while (num2 > 0 || num2 < 0)
{
    mun *= 10;
    mun += num2 % 10;
    num2 = num2 / 10; 
}

if (num == mun)
{
    Console.Write($"Число {num} является палиндромом");
}
else
{
    Console.Write($"Число {num} не является палиндромом");
}
*/
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Write("Введите координаты точки x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки z: ");
int z = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки z1: ");
int z1 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2) + Math.Pow(z1 - z, 2));

Console.WriteLine($"Расстояние между точками -> {Math.Round(result, 2)}");
*/
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int index = 1; index <= number; index++)
{
double result = Math.Pow(index, 3);
Console.Write($"{result} ");
}