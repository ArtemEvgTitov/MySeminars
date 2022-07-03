// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Lot(int n)
{
    int count = 0;
    while (n > 0)
    {
        n = n / 10;
        count++;
    }
    return count;
}
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {n} количество цифр равно " + Lot(n));

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Inc(int a)
{
    int inc = 1;
    for (int current = 1; current <= a; current++)
    {
        inc *= current;
    }
    return inc;
}

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {a} равно " + Inc(a));

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Rate(int j, int k)
{
    int result = 1;
    for (int current = 1; current <= k; current++) result *= j;

    return result;
}
Console.Write("Введите число ");
int j = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{j} в степени {k} равно " + Rate(j, k));

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateBinaryArray(int size)

{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Inpur number of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateBinaryArray(size);
ShowArray(myArray);