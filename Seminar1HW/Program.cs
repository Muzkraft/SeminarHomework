// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"a = {a}, b = {b}, {a} максимальное");
} 
else
{
    Console.WriteLine($"a = {a}, b = {b}, {b} максимальное");
}
*/
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;
{
    Console.WriteLine($"a = {num1}, b = {num2}, c = {num3}, {max} максимальное число.");
}
*/
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.WriteLine($"Число {num1} четное.");
}
else
{
    Console.WriteLine($"Число {num1} не четное.");
}
*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write("{0} ", i);
    }
}
*/
