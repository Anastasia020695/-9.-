// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        RecursivePrint(N);
        Console.ReadKey();
    }

    static void RecursivePrint(int N)
    {
        if (N == 1) return;
        Console.WriteLine(N);
        RecursivePrint(N - 1);
    }
}