// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

string Num(int n, int minValue)
{
    if (n == 1)
    {
        return n.ToString();
    }
    return (n + " " + Num(n - 1 , 1));
}
Console.WriteLine(Num(n, 1));
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

int Sum(int m, int n)
{
    if (m == n) return n;
    return m + Sum(m + 1, n);
}
Console.Write(Sum(m, n));
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

int Akkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine(Akkerman(m, n));