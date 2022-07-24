//  Массивы строк

// Написать программу, определяющую кол-во слов, размером не менее пяти символов в исходном массиве строк.

int LongWorlCounter(string[] words, int wordLenght)
{
    int counter = 0;

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length >= wordLenght)
            counter++;
    }
    return counter;
}

// char cymbol = '%';

string[] names = { "Leonid", "Natalya", "Maxim", "Lubov", "Jhon", "Tom", "Jan" };

// Console.WriteLine("Number of long words is " + LongWorlCounter(names, 5));
Console.WriteLine();

// Написать программу, принимающую на вход массив строк и генерирующую новый массив, состоящий из элементов, начинающихся на символ s1 и заканчивающихся на символ s2

void ShowArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] CreateStringArray(int number)
{
    string[] pupkaAlupka = new string[number];
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"Введите {i + 1} слово: ");
        pupkaAlupka[i] = Console.ReadLine();
    }
    return pupkaAlupka;
}

string[] ArrayFromS1TOS2(string[] array, int s1, int s2)
{
    string[] array2 = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i][0] == s1 && array[i][array[i].Length - 1] == s2) array2[i] = array[i];
    }

    return array2;
}

Console.WriteLine("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());

// ShowArray(ArrayFromS1TOS2(CreateStringArray(number), 'a', 'b'));

// Написать программу, принимающую на вход два массива строк и генерирующую новый массив, состоящий из попарно объединенных исходных элементов

string[] CombineArray(string[] array1, string[] array2)
{
    string[] newArray = new string [array1.Length];
    if (array1.Length != array2.Length)
    {
        Console.WriteLine("Массивы не равны!");
        return newArray;
    }

    for (int i = 0; i < array1.Length; i++)
    {
        newArray[i] = array1[i] + array2[i];
    }

    return newArray;
}

string[] myArray1 = CreateStringArray(3);
string[] myArray2 = CreateStringArray(3);
string[] myArray3 = CombineArray(myArray1, myArray2);

ShowArray(myArray1);
ShowArray(myArray2);
ShowArray(myArray3);