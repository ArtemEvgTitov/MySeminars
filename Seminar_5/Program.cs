// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] CreateRandomArray(int size, int min, int max) // Создание массива из случайных чисел
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);

    return array;
}

int[] CreateArray() // Создание массива из введённых пользователем чисел
{

    Console.WriteLine("Welcome to array creating program!");
    Console.WriteLine("Input number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Inpet {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void ShowArray(int[] array) // Вывод массива в терминал
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindSum(int[] array, bool isPositive) // Сложение чисел
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0 && isPositive) sumPositive += array[i];
        else if (array[i] < 0 && !isPositive) sumNegative += array[i];

    return isPositive ? sumPositive : sumNegative;
}

bool positive = true;

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

Console.WriteLine(FindSum(myArray, positive));
Console.WriteLine(FindSum(myArray, !positive));

// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.



// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.



// Задайте одномерный массив из 20 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].