﻿// Task 23
Console.Clear();
Console.WriteLine("Введите N: ");
double n = Convert.ToInt32(Console.ReadLine());
double i = 1;
while (i <= n)
{
    if (i != n) Console.Write($"{Math.Pow((i),3)}, ");
    else Console.Write($"{Math.Pow((i),3)}.");
    i++;
}