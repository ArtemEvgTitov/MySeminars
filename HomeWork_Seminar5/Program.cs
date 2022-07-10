// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray()
{
    Console.WriteLine("Введите желаемый размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int PositiveNum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] threeDigitArray = CreateArray();
ShowArray(threeDigitArray);
Console.WriteLine($"В сгенерированном массиве количество чётных чисел равно {PositiveNum(threeDigitArray)}");

// Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray2()
{
    Console.WriteLine("Введите желаемый размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное число в массиве: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное число в массиве: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);

    return array;
}

void ShowArray2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumNum(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] myArray = CreateArray2();
ShowArray2(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumNum(myArray)}");

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray3()
{
    Console.WriteLine("Введите желаемый размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное число в массиве: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное число в массиве: ");
    int max = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1) + rand.NextDouble();

    return array;
}

void ShowArray3(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double diff = max - min;
    return diff;
}

double[] realNum = CreateArray3();
ShowArray3(realNum);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {Difference(realNum)}");