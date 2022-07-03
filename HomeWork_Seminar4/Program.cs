// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int n)
{
    int result = 0;
    int rem = 0;
    while (n > 0)
    {
        rem = n % 10;
        result += rem;
        n /= 10;
    }

    return result;
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {n} равна " + SumNum(n));

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

ShowArray(array);