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
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//         return array;
// }

// Console.WriteLine();
// Console.WriteLine("Необходимо определить размер массива.");
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("А теперь введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] myArray = CreateRandom2dArray(m, n);
// Console.WriteLine("Заданный массив: ");
// Show2dArray(myArray);
// Console.WriteLine("Отсортированный массив: ");
// Show2dArray(SortingArray(myArray));

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

// void ShowSum(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.WriteLine($"Сумма {i + 1} строки равна {array[i]} ");

//     Console.WriteLine();
// }

// int[] sumString(int[,] array)
// {
//     int[] sumArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             sumArray[i] += array[i, j];
//     }

//     return sumArray;
// }

// int minSum(int[] array)
// {
//     int min = 0;
//     for (int i = 1; i < array.Length; i++)
//         if (array[i] < array[min]) min = i;

//     return min + 1;
// }

// Console.WriteLine();
// Console.WriteLine("Необходимо определить размер массива.");
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("А теперь введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] myArray = CreateRandom2dArray(m, n);
// Console.WriteLine("Заданный массив: ");
// Show2dArray(myArray);
// ShowSum(sumString(myArray));
// Console.WriteLine($"В заданном массиве наименьшая сумма в строке {minSum(sumString(myArray))}");


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
//         {
//             array1[i, j] *= array2[i, j];
//             Console.Write(array1[i, j] + " ");
//         }
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

// int[,,] CreateRandom3dArray(int m, int n, int l)
// {
//     int[,,] newArray = new int[m, n, l];
//     int[] tempArray = new int[newArray.GetLength(0) * newArray.GetLength(1) * newArray.GetLength(2)];
//     int number;

//     for (int i = 0; i < tempArray.GetLength(0); i++)
//     {
//         tempArray[i] = new Random().Next(10, 100);
//         number = tempArray[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (tempArray[i]==tempArray[j])
//                     tempArray[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = tempArray[i];
//                 number = tempArray[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < newArray.GetLength(0); x++)
//     {
//         for (int y = 0; y < newArray.GetLength(1); y++)
//         {
//             for (int z = 0; z < newArray.GetLength(2); z++)
//                 newArray[x,y,z] = tempArray[count];
//                 count++;
//         }
//     }

//     return newArray;
// }

// void Show3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(2); k++)
//                 Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k});");
//     Console.WriteLine();

//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine("Необходимо определить размер массива (m x n x l).");
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Теперь введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ну а теперь введите l: ");
// int l = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,,] myArray = CreateRandom3dArray(m, n, l);
// Show3dArray(myArray);

// Задача 62. Заполните спирально массив 4 на 4.

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();

//     Console.WriteLine();
// }

// int[,] spiralFilling(int[,] array)
// {
//     int count = 1;
//     int i = 0;
//     int j = 0;

//     while (count <= array.GetLength(0) * array.GetLength(1))
//         array[i, j] = count;
//         count++;
//         if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
//         else if (i < j && i + j >= array.GetLength(0) - 1) i++;
//         else if (i >= j && i + j > array.GetLength(1) - 1) j--;
//         else i--;

//     return array;
// }

// Console.WriteLine();
// int[,] newArray = new int[4, 4];
// Console.WriteLine("Заполненный массив: ");
// Show2dArray(spiralFilling(newArray));
