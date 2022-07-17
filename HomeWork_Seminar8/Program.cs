// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandom2dArray(int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < newArray.GetLength(0); i++)
//         for (int j = 0; j < newArray.GetLength(1); j++)
//             newArray[i, j] = new Random().Next(0, 10);

//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// int[,] SortingArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//         }
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] CreateRandom2dArray(int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < newArray.GetLength(0); i++)
//         for (int j = 0; j < newArray.GetLength(1); j++)
//             newArray[i, j] = new Random().Next(0, 10);

//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// int[,] sumString(int[,] array)
// {
//     int[] sumArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             sumArray[j] += array[i, j];
//     }

//     return sumArray;
// }

// Console.Write("Необходимо определить размер массива. Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("А теперь введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n);
// Show2dArray(myArray);
// Show2dArray(sumString(myArray));

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] CreateRandom2dArray(int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < newArray.GetLength(0); i++)
//         for (int j = 0; j < newArray.GetLength(1); j++)
//             newArray[i, j] = new Random().Next(0, 10);

//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// void UltraMatrix(int[,] array1, int[,] array2)
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//         for (int j = 0; j < array1.GetLength(1); j++)
//             array1[i, j] *= array2[i, j];
//             Console.Write(array1[i, j] + " ");
//         Console.WriteLine();
// }

// Console.Write("Необходимо определить размер обеих матриц. Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("А теперь введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray1 = CreateRandom2dArray(m, n);
// int[,] myArray2 = CreateRandom2dArray(m, n);
// Show2dArray(myArray1);
// Show2dArray(myArray2);

// UltraMatrix(myArray1, myArray2);

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3dArray(int m, int n, int l)
{
    int[,,] newArray = new int[m, n, l];

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            for (int k = 0; k < newArray.GetLength(2); k++)
            newArray[i, j, k] = new Random().Next(10, 100);

    return newArray;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, j, k] + " ");
        Console.WriteLine();

    Console.WriteLine();
}

Console.Write("Необходимо определить размер массива (m x n x l). Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Теперь введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Ну а теперь введите l: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(m, n, l);
Show3dArray(myArray);

// Задача 62. Заполните спирально массив 4 на 4.
