﻿Console.Clear();
Console.Write("Введите число:");
int number;
number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");
int sqr1 = Convert.ToInt32(Math.Pow(number, 3));
Console.WriteLine($"Квадрат числа {number} равен {sqr1}");