// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} ");
//         Console.WriteLine();
//     }
// }

// void FillArray(double[,] array)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = Math.Round((new Random().Next(-10, 10) + rand.NextDouble()),1);
//     }
// }

// Console.WriteLine("Необходимо определить размер массива (m x n). Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("А теперь введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m, n];

// FillArray(array);
// PrintArray(array);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    }
}

void SearchNumber(int[,] array)
{
    Console.WriteLine("Необходимо указать координаты искомого числа (m x n)");

    Console.WriteLine("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m >= array.GetLength(0) || n >= array.GetLength(1)) 
        Console.WriteLine("Координаты введены неверно");
    else Console.WriteLine($"Искомое число равно " + array[m, n]);
}

int[,] array = new int[4, 4];

FillArray(array);
PrintArray(array);
SearchNumber(array);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} ");

//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
//     }
// }

// void AverageNumber(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
//         Console.WriteLine($"Среднее арифметическое чисел {i + 1} строки равно: {sum / array.GetLength(1)}");
//     }

//     Console.WriteLine();

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++) sum += array[i, j];
//         Console.WriteLine($"Среднее арифметическое чисел {j + 1} столбца равно: {sum / array.GetLength(0)}");
//     }
// }

// int[,] array = new int[4, 4];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// AverageNumber(array);