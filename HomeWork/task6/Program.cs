﻿//Напишите программу, которая на вход принимает число и выдает, является ли число четным.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 2) == 0)
{
    Console.WriteLine($"Число {number} является четным");
}
else Console.WriteLine($"Число {number} не является четным");