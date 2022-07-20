// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// void ShowNumbers(int N)
// {
//     if (N > 1) ShowNumbers(N - 1);

//     Console.Write(N + " ");
// }

// ShowNumbers(5);
// Console.WriteLine();

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfDigits(int n)
{
    if (n > 0)
    {
        return SumOfDigits(n / 10) + n % 10;
    }
    return n;
}

Console.Write(SumOfDigits(12345));
Console.WriteLine();

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNumbers(int N, int M)
{
    if (N > M) ShowNumbers(N - 1, M);

    Console.Write(N + " ");
}

ShowNumbers(15, 5);
Console.WriteLine();

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int numDegree(int a, int b)
{
    if (b > 1) 
    {
        return a * numDegree(a, b - 1);
    }
    return a;
}

Console.WriteLine(numDegree(2, 3));