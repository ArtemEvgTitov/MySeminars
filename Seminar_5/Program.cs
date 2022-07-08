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

int[] CreateRandomArray0(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}
void ShowArray0(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int[] ReversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;
    return array;
}
int[] myArray0 = CreateRandomArray0(12, -9, 9);
ShowArray0(myArray0);
ReversArray(myArray0);
ShowArray0(myArray0);


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool presNum(int[] array)
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    bool found = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            found = true;
            break;
        }
    }
    if (found == true) Console.WriteLine("Введённое число присутствует в заданном массиве");
    if (found == false) Console.WriteLine("Введённое число отсутствует в заданном массиве"); 
    return found;
}

int[] givArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
presNum(givArray);


// Задайте одномерный массив из 20 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateRandomArray2(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}
int FoundElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= 10 && array[i] <= 99) count += 1;
    return count;
}
void ShowArray2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] myArray2 = CreateRandomArray2(20, 0, 1000);
ShowArray2(myArray2);
Console.WriteLine($"В массиве {FoundElements(myArray2)} элементов лежат в отрезке от 10 до 99");
