// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

// int[,] ChangeRows(int[,] array, int firstString, int secondString)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int temp = array[secondString, i];
//         array[secondString, i] = array[firstString, i];
//         array[firstString, i] = temp;
//     }

//     return array;
// }

// Console.Write("Необходимо определить размер массива. Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("А теперь введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Какую строчку вы хотите заменить?: ");
// int o = Convert.ToInt32(Console.ReadLine());
// Console.Write("Какую строчку вы хотите заменить?: ");
// int p = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n);
// Show2dArray(myArray);
// Show2dArray(ChangeRows(myArray, o, p));

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

// int[,] Transporate2dArray(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//         Console.WriteLine("Массив задан неверно");
//     return array;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             int temp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = temp;
//         }

//     return array;
// }

// Console.Write("Необходимо определить размер массива. Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("А теперь введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n);
// Show2dArray(myArray);
// Show2dArray(Transporate2dArray(myArray));

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

// void ShowShortArray(int[,] array, int rowIgnore, int columnIgnore) // Метод игнора строчек, которые до этого занулили
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (i == rowIgnore) continue;

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == columnIgnore) continue;
//             Console.Write(array[i, j] + " ");
//         }

//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < newArray.GetLength(0); i++)
//         for (int j = 0; j < newArray.GetLength(1); j++)
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);

//     return newArray;
// }

// int[,] DelMinStrings(int[,] array)
// {
//     int minI = 0, minJ = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 1; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < array[minI, minJ])
//             {
//                 minI = i;
//                 minJ = j;
//             }
//         }

//     for (int j = 0; j < array.GetLength(1); j++) array[minI, j] = 0;
//     for (int i = 0; i < array.GetLength(0); i++) array[i, minJ] = 0;

//     return array;
// }

// Console.Write("Необходимо определить размер массива. Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("А теперь введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// ShowShortArray(myArray, 3, 4);
