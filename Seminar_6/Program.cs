// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int[] ReversArray(int[] array)
// {
//     for (int i = 0; j = array.Length - 1; i < j; i++; j--;)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
//     return array;
// }
// int[] myArray = {1,2,3,4,5,6};
// Console.WriteLine(ReversArray(myArray));

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string CovvertNumber(int num)
{
    string ConNum = string.Empty;
    while (num > 0)
    {
        ConNum = num % 2 + ConNum;
        num = num / 2;
    }
    return ConNum;
}
Console.WriteLine(CovvertNumber(10));

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int[] Fibonacci(int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
ShowArray(Fibonacci(10));

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. // A < B + C

bool isTriangle(int n1, int n2, int n3)
{
    return n1 < n2 + n3 && n2 < n1 + n3 && n3 < n2 + n1;
    // if(n1 < n2 + n3 && n2 < n1 + n3 && n3 < n2 + n1) return true;
    // else return false;
}
Console.WriteLine("Введите 1 число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isTriangle(n1, n2, n3));