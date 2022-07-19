//  Задайте значение N. Напишите программу, которая найдет факториал числа N рекурсивным методом.

int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine();
Console.WriteLine("Напишите программу, которая найдет факториал числа N рекурсивным методом");
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n}! = {Factorial(n)}");
Console.WriteLine();

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNum(int m, int n)
{
    int sum = 0;
    if (m > n) return sum;
    else return m + SumNum(m + 1, n);
}
Console.WriteLine();
Console.WriteLine("Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от {M} до {N} равна {SumNum(M, N)}");
Console.WriteLine();