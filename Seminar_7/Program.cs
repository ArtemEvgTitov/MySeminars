// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] CreateRandom2dArray(int m, int n, int minValue, int maxValue)
{
    int[,] newArray = new int [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue+1);
    return newArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] +" ");
        Console.WriteLine();
    }
}

Console.WriteLine("Необходимо определить размер массива (m x n). Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А теперь введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, 1, 9);
PrintArray(myArray);

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = I + j. Выведите полученный массив на экран.



// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.



// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.