﻿ // Задача 23: Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while (count <= N)
// {
// System.Console.Write(Math.Pow(count, 3) + ", ");
// count+++;
// }

for (int count = 1; count <= N; count++)
{
System.Console.Write(Math.Pow(count, 3) + ", ");
}