﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

string number = "нечётное";

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) 
{
    number = "чётное";
}

Console.WriteLine($"Число {number}");

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.