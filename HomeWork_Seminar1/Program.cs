// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
int min = num2;

if (num1 > max)
{
    max = num1;
    min = num2;
}
if (num2 > max)
{
    max = num2;
    min = num1;
}

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);

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

int n;
int current = 1;

Console.Write("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

while (current <= n)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
        current+=2;
    }
    else
    {
        current++;
    }
}
