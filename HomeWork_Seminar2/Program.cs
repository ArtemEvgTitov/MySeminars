// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNum(int num)
{
    int del = num / 10;
    int res = del % 10;
    return res;
}
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 999)
{
    Console.WriteLine("Число введено некорректно");
    return;
}
if (num < 100)
{
    Console.WriteLine("Число введено некорректно");
    return;
}
int result = SecondNum(num);
Console.WriteLine($"Вторая цифра введённого числа равна {result}");

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNum(int num1)
{
    int res = num1 % 10;
    return res;
}
int num1 = new Random().Next(10, 100000);
Console.WriteLine(num1);
if (num1 < 100)
{
    Console.WriteLine($"У числа {num1} нет третьей цифры");
    return;
}
while (num1 > 999)
{
    num1 = num1 / 10;
}
int result1 = ThirdNum(num1);
Console.WriteLine($"Третья цифра равна {result1}");

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekday(int num2)
{
    if (num2 == 6) return true;
    if (num2 == 7) return true;
    else return false;
}
Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 > 7)
{
    Console.WriteLine("Такого дня недели не существует");
    return;
}
bool result2 = Weekday(num2);
if (result2 == true) Console.WriteLine("Ура! Сегодня выходной!");
else Console.WriteLine("Опять работать?");
