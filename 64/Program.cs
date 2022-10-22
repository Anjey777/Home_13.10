/*
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int n = InputInt("Введите число N  ");
int m = 1;
Console.WriteLine($"n={n}, m={m}");

Console.WriteLine(recursion(n, m));

int recursion(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{recursion(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}