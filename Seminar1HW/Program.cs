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
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());

int num1 = N / 10;
int num2 = num1 % 10;

Console.WriteLine($"Вторая цифра числа {N}, {num2}.");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N > 99)
{
    Console.WriteLine($"Третья цифра в числе " + N.ToString() + " = " + N.ToString()[2]);
}
else
{
    Console.WriteLine($"Третьей цифры в числе " + N.ToString() + " не существует.");
}
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели: ");
int N = int.Parse(Console.ReadLine());

string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
int num = N - 1;

if (num > 0 && num < 6)
{
    Console.WriteLine($"Сегодня {days[num]}, иди работай !");
}
else if (num > 5 && num < 8)
{
    Console.WriteLine($"Сегодня {days[num]}, наконец-то выходной !!!");
}
else
{
    Console.WriteLine($"Это тебе не календарь! Какой сегодня день недели ?");
}
