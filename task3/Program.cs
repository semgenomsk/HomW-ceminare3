﻿// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: "); 
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (N > 0)
{
    while (i <= N)
    {
        Console.Write(i*i*i + " ");
        i++;
    }
}
else
{
    Console.WriteLine("Введенное число должно быть больше 0!");
}